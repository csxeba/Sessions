using System;
using System.Collections.Generic;
using System.Text;

namespace Examples
{
    class ExceptionExample
    {
        private string _asd;
        public string Asd
        {
            get
            {
                return _asd.Replace(" ", "\t");
            }
            set
            {
                _asd = value.Replace("\t", " ");
            }
        }

        public string Asd2 => "Szia";

        void Test1()
        {
            try
            {
                throw new Exception("Test1");
            }
            catch (Exception e)
            {
                // ...
            }
        }

        void Test2()
        {
            try
            {
                if (new Random().Next(0, 2) == 1)
                    throw new InvalidOperationException("Test2");

                throw new Exception("Test2");
            }
            catch (InvalidOperationException fioe) when (fioe.Message == "Test2")
            {
                // ...
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
