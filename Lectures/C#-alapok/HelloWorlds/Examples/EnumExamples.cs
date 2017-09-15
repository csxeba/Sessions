using System;

namespace Examples
{
    public enum EnumExamples
    {
        None = 0,
        Shitty = 1,
        Poor = 2,
        Average = 3,
        Good = 4,
        Excellent = 5
    }

    

    [Flags]
    public enum SomeFlags : byte
    {
        None = 0,
        Read = 1,
        Write = 2,
        Execute = 4,
        Fuck = 4
    }

    public class CurrentExample
    {
        public EnumExamples CurrentExampleGrade = EnumExamples.Excellent;

        public void Test()
        {
            var flags = SomeFlags.Read | SomeFlags.Write;

            if ((flags & SomeFlags.Execute) == SomeFlags.Execute)
            {
                // Execute ...
            }

            var flags2 = Enum.Parse<SomeFlags>("Read");
            var flags3 = (SomeFlags) 7;
        }
    }
}
