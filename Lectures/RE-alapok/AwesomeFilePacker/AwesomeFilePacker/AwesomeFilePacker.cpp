#include "stdafx.h"

AwesomeFilePacker::AwesomeFilePacker(const char* fileName)
    : m_fileName(fileName), m_file(nullptr), m_head(nullptr)
{
}

AwesomeFilePacker::~AwesomeFilePacker()
{
    ListEntry* iterator = m_head;
    while (iterator != nullptr)
    {
        ListEntry* next = iterator->next;

        delete iterator->entry;
        delete iterator;

        iterator = next;
    }
}

void AwesomeFilePacker::Open()
{
    if (m_file == nullptr)
        m_file = fopen(m_fileName, "wb");
}

void AwesomeFilePacker::Close()
{
    if (m_file != nullptr)
    {
        fclose(m_file);

        m_file = nullptr;
    }
}

void AwesomeFilePacker::WritePackedFile()
{
    int version = GetVersion();

    long entryCount = 0;

    ListEntry* iterator = m_head;
    while (iterator != nullptr)
    {
        long fileOff = ftell(m_file);

        iterator->entry->WriteData(m_file);
        iterator->entry->SetOffset(fileOff);
        iterator = iterator->next;

        ++entryCount;
    }

    long headerOff = ftell(m_file);

    fwrite("PACK", 1, 4, m_file);
    fwrite(&version, 1, sizeof(int), m_file);
    fwrite(&entryCount, 1, sizeof(long), m_file);

    iterator = m_head;
    while (iterator != nullptr)
    {
        iterator->entry->WriteHeader(m_file);
        iterator = iterator->next;
    }

    fseek(m_file, 0, SEEK_END);

    fwrite(&headerOff, 1, sizeof(long), m_file);
}

void AwesomeFilePacker::AddFile(AwesomeFileEntry* entry)
{
    if (entry == nullptr)
        return;

    if (m_head == nullptr)
    {
        m_head = new ListEntry();
        m_head->entry = entry;
        return;
    }

    ListEntry* latest = m_head;

    while (latest != nullptr && latest->next != nullptr)
        latest = latest->next;

    ListEntry* newEntry = new ListEntry();

    latest->next = newEntry;
    newEntry->previous = latest;
    newEntry->entry = entry;
}