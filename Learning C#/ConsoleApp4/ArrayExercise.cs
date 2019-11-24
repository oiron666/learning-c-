using System;
namespace ConsoleApp4
{
    public class ArrayExercise
    {
        int[] numbers = new int[3] {1, 2, 3};
        public void WriteNumber()
        {
            Console.WriteLine(numbers[1]);
        }

        bool[] flags = new bool[3] {true, false, false };
        public void WrtieFlag()
        {
            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);
        }

        string[] names = new string[3] { "Marcel", "Alak", "Janusz" };


    }
}
