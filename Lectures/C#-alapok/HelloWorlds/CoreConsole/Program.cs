using System;

namespace CoreConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorldStandard.HelloWorld.Magic();
            HelloWorldCore.HelloWorld.Magic();

            Console.ReadLine();
        }
    }
}
