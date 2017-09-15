namespace Examples
{
    public interface ITestInterface
    {
        void A();
    }

    public struct Struct1 : ITestInterface
    {
        public Struct1()
        {

        }

        public void A()
        {

        }
    }

    public struct Struct2 : Struct1
    {

    }
    public class Hybrid : Struct1
    {

    }

    public class Class1 : ITestInterface
    {
        public void A()
        {

        }
    }

    public class Class2 : Class1
    {

    }

    public interface Interface
    {
        void Test();
    }

    public abstract class AbstractClass : Interface
    {
        public abstract void Test();
        public virtual void Test2()
        {

        }
    }

    public class First : AbstractClass
    {
        public override void Test()
        {

        }
    }

    public class Second : First
    {
        public override void Test2()
        {
            base.Test2();
        }
    }

    public sealed class Last : Second
    {

    }
}
