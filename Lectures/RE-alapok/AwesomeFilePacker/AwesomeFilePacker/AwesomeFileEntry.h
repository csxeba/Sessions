#pragma once

class AwesomeFileEntry
{
private:
    const char* m_name;
    long m_size;
    long m_offset;
    char* m_data;
    bool m_ownsMemory;
    FILE* m_file;

public:
    AwesomeFileEntry(const char* name);
    virtual ~AwesomeFileEntry();

    virtual void SetData(char* data, bool ownsMemory);

    const char* GetName() { return m_name; }
    virtual long GetSize() { return m_size; }
    virtual long GetOffset() { return m_offset; }
    virtual void SetOffset(long offset) { m_offset = offset; }
    virtual const char* GetData() { return m_data; }
    virtual bool OwnsMemory() { return m_ownsMemory; }
    virtual void Open();
    virtual void Close();
    virtual void WriteHeader(FILE* file);
    virtual void WriteData(FILE* file);
    virtual int Read(char* dest, int size);
    virtual void ReadContent();
    virtual long GetFileSize();
};