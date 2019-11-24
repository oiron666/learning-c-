using System;
namespace ConsoleApp4
{
    public class ValueType
    {
        public ValueType()
        {
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(String.Format("a = {0} b = {1}", a, b));

            var arr1 = new int[3] { 1, 2, 3 };
            var arr2 = arr1;
            arr1[2] = 0;
            Console.WriteLine(String.Format("arr1[2] = {0} arr2[2] = {1}", arr1[2], arr2[2]));
        }
    }
}
