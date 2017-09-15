using System;

using Microsoft.CodeAnalysis.CSharp.Scripting;

namespace HelloWorldCompile
{
    public class HelloWorld
    {
        public static void Magic()
        {
            CSharpScript.EvaluateAsync("System.Console.WriteLine(\"Hello world from dynamically compiled code!.\");").Wait();
        }
    }
}
