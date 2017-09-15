using System;
using System.IO;

namespace Examples
{
    public static class FileIOExample
    {
        public static object ReadMyFormat(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("The file is missing!", Path.GetFileName(path));

            using (var br = new BinaryReader(new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read)))
            {
                if (br.ReadUInt32() != 0xDEADBEEFu) // Magic const header
                    return null;

                var count = br.ReadUInt32();
                for (var i = 0; i < count; ++i)
                {
                    var str = br.ReadString();
                }

                // ...
            }

            return new
            {
                path = path,
                data = 1
            };
        }

        public static void WriteMyFormat(string path)
        {
            if (File.Exists(path))
                Console.WriteLine("The file exists. Overwriting...");

            using (var bw = new BinaryWriter(new FileStream(path, FileMode.CreateNew, FileAccess.Write, FileShare.None)))
            {
                bw.Write(0xDEADBEEFu);
                bw.Write(12);

                for (var i = 0; i < 12; ++i)
                {
                    bw.Write("Data");
                }

                // ...
            }
        }

        public static void MiscFunctions(string path)
        {
            var allBytes = File.ReadAllBytes(path);
            var allLines = File.ReadAllLines(path);

            File.SetCreationTime(path, new DateTime(1996, 01, 01));

            File.Delete(path);
            File.Create(path);

            Directory.EnumerateDirectories(path);
            Directory.GetCreationTime(path);

            // ...
        }
    }
}
