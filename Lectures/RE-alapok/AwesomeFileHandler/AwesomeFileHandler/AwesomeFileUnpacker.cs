using System;
using System.IO;
using System.Text;

namespace AwesomeFileHandler
{
    public class AwesomeFileUnpacker : AwesomeFileHandleBase
    {
        public string PackedFilePath { get; }
        public string OutputFolderPath { get; }

        public AwesomeFileUnpacker(string packedFilePath, string outputFolderPath)
        {
            PackedFilePath = packedFilePath;
            OutputFolderPath = outputFolderPath;

            if (!Directory.Exists(OutputFolderPath))
                Directory.CreateDirectory(outputFolderPath);
        }

        public void Unpack()
        {
            using (var reader = new BinaryReader(new FileStream(PackedFilePath, FileMode.Open, FileAccess.Read, FileShare.Read), Encoding.Unicode, false))
            {
                reader.BaseStream.Seek(-4, SeekOrigin.End);

                var headerOffset = reader.ReadInt32();

                reader.BaseStream.Seek(headerOffset, SeekOrigin.Begin);

                if (reader.ReadInt32() != PackedFileMagicHeader)
                    throw new Exception("Packed file magic header is invalid!");

                if (reader.ReadInt32() != Version)
                    throw new Exception("Packed file version is invalid!");

                var entryCount = reader.ReadInt32();

                for (var i = 0; i < entryCount; ++i)
                {
                    var entry = new AwesomeFileEntry();

                    entry.ReadHeader(reader);

                    using (var fileStream = new FileStream(Path.Combine(OutputFolderPath, entry.Name), FileMode.Create, FileAccess.Write, FileShare.None))
                        entry.ReadData(reader, fileStream);
                }
            }
        }
    }
}
