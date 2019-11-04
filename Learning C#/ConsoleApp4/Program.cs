using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string number = "1234";
                byte b = Convert.ToByte(number);
              
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("The nummber could not nonvert to a byte");
            }




        }
    }
}
