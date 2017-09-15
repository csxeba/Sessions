using System;
using System.IO;
using System.Text;

namespace AwesomeFileHandler
{
    public class AwesomeFileEntry
    {
        public const int EntryMagicHeader = 0x454C4946; // FILE

        public int Size { get; private set; }
        public int Offset { get; set; }
        public string Name { get; private set; }
        public string FilePath { get; }

        public AwesomeFileEntry()
        {
            Offset = 0;
            Size = 0;
            Name = null;
            FilePath = null;
        }

        public AwesomeFileEntry(string path)
            : this()
        {
            FilePath = path;
            Name = Path.GetFileName(FilePath);
        }

        public void ReadHeader(BinaryReader reader)
        {
            if (reader.ReadInt32() != EntryMagicHeader)
                throw new Exception("Invalid magic header found!");

            Size = reader.ReadInt32();
            Offset = reader.ReadInt32();

            int nameLength = reader.ReadInt32();
            if (nameLength > 0)
                Name = Encoding.UTF8.GetString(reader.ReadBytes(nameLength));
        }

        public void ReadData(BinaryReader reader, FileStream fileStream)
        {
            var previousPosition = reader.BaseStream.Position;

            reader.BaseStream.Seek(Offset, SeekOrigin.Begin);

            var data = reader.ReadBytes(Size);

            fileStream.Write(data, 0, data.Length);

            reader.BaseStream.Seek(previousPosition, SeekOrigin.Begin);
        }

        public void WriteHeader(BinaryWriter writer)
        {
            writer.Write(EntryMagicHeader);
            writer.Write(Size);
            writer.Write(Offset);
            writer.Write(Name.Length);

            if (Name.Length > 0)
                writer.Write(Encoding.UTF8.GetBytes(Name));
        }

        public void WriteData(BinaryWriter writer, FileStream fileStream)
        {
            Size = (int) fileStream.Length;

            fileStream.CopyTo(writer.BaseStream);
        }
    }
}
