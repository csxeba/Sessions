namespace Examples
{
    namespace Test
    {
        public class TestExample
        {
            public static void A()
            {

            }
        }
    }

    class NamespaceExample
    {
        public static void Test()
        {
            Examples.Test.TestExample.A();
        }
    }
}

namespace OtherExamples
{
    using Examples.Test;

    public class OtherExample
    {
        public static void Test()
        {
            TestExample.A();
        }
    }
}