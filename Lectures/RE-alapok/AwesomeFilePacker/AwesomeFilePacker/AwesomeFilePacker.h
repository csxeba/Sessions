#pragma once

#include <string>
#include <cstdio>

class AwesomeFileEntry;

class AwesomeFilePacker
{
    struct ListEntry
    {
        ListEntry* previous;
        ListEntry* next;
        AwesomeFileEntry* entry;

        ListEntry()
            : previous(nullptr), next(nullptr), entry(nullptr)
        {
        }
    };

    const char* m_fileName;
    FILE* m_file;
    ListEntry* m_head;

public:
    AwesomeFilePacker(const char* fileName);
    virtual ~AwesomeFilePacker();

    void Open();
    void Close();
    void WritePackedFile();
    void AddFile(AwesomeFileEntry* entry);
    int GetVersion() const { return 1; }
};