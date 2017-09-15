using System;

namespace Examples
{
    public class MethodExamples
    {
        void A()
        {
            this.ExtensionMethod();
        }

        bool B(int unk)
        {
            return true;
        }

        (bool, int, object, bool) Test(int unk, object asd)
        {
            return (true, 0, null, false);
        }

        public void MaybeInitValue(ref int value)
        {
            var val = value;
        }

        public void InitValue(out int value)
        {
            var val = value;

            value = 0;
        }
    }

    public static class StaticMethodExamples
    {
        public static void Execute()
        {
            MethodExamples ex = null;
            ExtensionMethod(ex);
        }

        public static void ExtensionMethod(this MethodExamples exm)
        {

        }
    }

    public class Singleton
    {
        private static Singleton _instance;
        private static object lockObj = new object();

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (lockObj)
                    {
                        if (_instance == null)
                        {
                            _instance = new Singleton();
                        }
                    }
                }

                return _instance;
            }
        }

        private Singleton()
        {

        }
    }
}
