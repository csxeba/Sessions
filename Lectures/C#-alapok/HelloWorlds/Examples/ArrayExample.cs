using System;

namespace Examples
{
    class ArrayExample
    {
        public void Test()
        {
            var byteArr = new byte[4];
            var byteArr2 = new byte[] { 0x00, 0x01, 0x02, 0x03 };
            var intArr = new int[1024];

            var objArr = new object[10];
            for (var i = 0; i < objArr.Length; ++i)
                objArr[i] = new object();

            Array.Reverse(byteArr);

            Array.Copy(byteArr, 0, byteArr2, 0, 4);
            Array.Clear(byteArr, 0, 2);

            Array.Sort(byteArr);

            var matrix = new byte[3, 4, 2, 4, 5, 6, 7, 8, 9];
            var matrix2 = new byte[3][];

            matrix[0, 0, 0, 0, 0, 0, 0, 0, 0] = 0;
            matrix2[0][0] = 0;
        }
    }
}
