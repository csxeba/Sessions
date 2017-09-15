using System;
using System.IO;
using System.Text;

namespace AwesomeFileHandler
{
    public class AwesomeFilePacker : AwesomeFileHandleBase
    {
        public string OutputFilePath { get; }

        public AwesomeFilePacker(string outputFilePath)
        {
            OutputFilePath = outputFilePath;
        }

        public void AddFileEntry(AwesomeFileEntry entry)
        {
            FileEntries.Add(entry);
        }

        public void Pack()
        {
            using (var writer = new BinaryWriter(new FileStream(OutputFilePath, FileMode.Create, FileAccess.Write, FileShare.None), Encoding.UTF8, false))
            {
                var offset = 0;

                foreach (var entry in FileEntries)
                {
                    using (var fileStream = new FileStream(entry.FilePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                        entry.WriteData(writer, fileStream);

                    entry.Offset = offset;

                    offset += entry.Size;
                }

                if (offset != writer.BaseStream.Position)
                    throw new Exception("Invalid size calculation, the offsets are not matching!");

                writer.Write(PackedFileMagicHeader);
                writer.Write(Version);
                writer.Write(FileEntries.Count);

                foreach (var entry in FileEntries)
                {
                    entry.WriteHeader(writer);
                }

                writer.Write(offset);
            }
        }
    }
}
