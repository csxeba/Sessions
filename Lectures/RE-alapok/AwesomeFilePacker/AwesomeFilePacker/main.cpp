#include "stdafx.h"

int main(int argc, char* argv[])
{
    AwesomeFilePacker packer(argv[1]);

    for (int i = 2; i < argc; ++i)
    {
        AwesomeFileEntry* entry = new AwesomeFileEntry(argv[i]);
        entry->Open();
        entry->ReadContent();
        entry->Close();

        packer.AddFile(entry);
    }

    packer.Open();
    packer.WritePackedFile();
    packer.Close();

    return 0;
}

