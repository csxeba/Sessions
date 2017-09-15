using System.Collections.Generic;

namespace AwesomeFileHandler
{
    public abstract class AwesomeFileHandleBase
    {
        public const int PackedFileMagicHeader = 0x4B434150; // PACK

        public List<AwesomeFileEntry> FileEntries { get; } = new List<AwesomeFileEntry>();

        public int Version => 1;
    }
}
