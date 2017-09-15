#include "stdafx.h"
#include <string.h>
#include <stdlib.h>

AwesomeFileEntry::AwesomeFileEntry(const char* name)
    : m_name(name), m_file(nullptr)
{
}

AwesomeFileEntry::~AwesomeFileEntry()
{
    if (m_data != nullptr && m_ownsMemory)
        delete[] m_data;
}

void AwesomeFileEntry::SetData(char* data, bool ownsMemory)
{
    if (m_data != nullptr && m_ownsMemory)
        delete[] m_data;

    m_data = data;
    m_ownsMemory = ownsMemory;
}

void AwesomeFileEntry::Open()
{
    if (m_file == nullptr)
        m_file = fopen(m_name, "rb");
}

void AwesomeFileEntry::Close()
{
    if (m_file != nullptr)
    {
        fclose(m_file);
        m_file = nullptr;
    }
}

int AwesomeFileEntry::Read(char* dest, int size)
{
    return (int) fread(dest, 1, size, m_file);
}

void AwesomeFileEntry::WriteHeader(FILE* file)
{
    fwrite("FILE", 1, 4, file);
    fwrite(&m_size, 1, sizeof(long), file);
    fwrite(&m_offset, 1, sizeof(long), file);

    char fileName[256];
    char extension[256];
    char fileNameWExt[512];

    memset(fileName, 0, 256);
    memset(extension, 0, 256);
    memset(fileNameWExt, 0, 256);

    _splitpath(m_name, nullptr, nullptr, fileName, extension);

    sprintf(fileNameWExt, "%s%s", fileName, extension);

    int strLen = strlen(fileNameWExt);
    if (strLen > 0)
    {
        fwrite(&strLen, 1, sizeof(int), file);
        fwrite(fileNameWExt, 1, strLen, file);
    }
    else
    {
        int zero = 0;
        fwrite(&zero, 1, sizeof(int), file);
    }
}

void AwesomeFileEntry::WriteData(FILE* file)
{
    fwrite(m_data, 1, m_size, file);
}

void AwesomeFileEntry::ReadContent()
{
    long size = GetFileSize();

    m_data = new char[size];

    Read(m_data, size);

    m_size = size;
}

long AwesomeFileEntry::GetFileSize()
{
    long previousTell = ftell(m_file);

    fseek(m_file, 0, SEEK_END);

    long fsize = ftell(m_file);

    fseek(m_file, previousTell, SEEK_SET);

    return fsize;
}