using System;
using System.Collections.Generic;

namespace Examples
{
    class LoopExamples
    {
        void For()
        {
            for (var i = 0; i < 100; ++i)
            {
                // ...
            }
        }

        void ForEach()
        {
            var list = new List<string>();
            // populate the list...

            foreach (var element in list)
            {
                // ...
            }
        }

        void While()
        {
            while (true)
            {
                // ...
            }
        }

        void DoWhile()
        {
            do
            {

            }
            while (true);
        }
    }
}
