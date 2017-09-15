using System;

namespace AwesomeFileHandler
{
    public class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Please specify an operation type: pack or unpack!");
                Console.WriteLine("Usage: AwesomeFileHandler.exe <pack|unpack> <other method dependent parameters...>");
                return;
            }

            if (args[0] == "unpack")
            {
                if (args.Length < 2)
                {
                    Console.WriteLine("No input file's path!");
                    Console.WriteLine("Usage: AwesomeFileHandler.exe unpack <input file path> <destination folder path>");
                    return;
                }

                if (args.Length < 3)
                {
                    Console.WriteLine("Please specify a destination folder to unpack to!");
                    Console.WriteLine("Usage: AwesomeFileHandler.exe unpack <input file path> <destination folder path>");
                    return;
                }

                var unpacker = new AwesomeFileUnpacker(args[1], args[2]);
                unpacker.Unpack();

                return;
            }

            if (args[0] != "pack")
            {
                Console.WriteLine("Only \"pack\" and \"unpack\" methods are supported!");
                Console.WriteLine("Usage: AwesomeFileHandler.exe <pack|unpack> <other method dependent parameters...>");
                return;
            }

            if (args.Length < 2)
            {
                Console.WriteLine("Please specify an output file path!");
                Console.WriteLine("Usage: AwesomeFileHandler.exe pack <files to be packed ...>");
                return;
            }

            if (args.Length < 3)
            {
                Console.WriteLine("Please specify input file(s) to pack!");
                Console.WriteLine("Usage: AwesomeFileHandler.exe pack <file 1 path> [<file 2 path> ...]");
                return;
            }

            var packer = new AwesomeFilePacker(args[1]);

            for (var i = 2; i < args.Length; ++i)
                packer.AddFileEntry(new AwesomeFileEntry(args[i]));

            packer.Pack();
        }
    }
}
