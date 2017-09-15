using System;

namespace FrameworkConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorldStandard.HelloWorld.Magic();
            HelloWorldFramework.HelloWorld.Magic();

            Console.ReadLine();
        }
    }
}
