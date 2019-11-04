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
                string strNumber = "1234";
                int number = Convert.ToInt32(strNumber);
                byte byteNumber = (byte)number;
                byte strToByteNumber = Convert.ToByte(strNumber);
                string booleanString = 'false';
                bool falseCheck = Convert.ToBoolean(booleanString);
                Console.WriteLine(number + byteNumber + strToByteNumber);
                Console.WriteLine(falseCheck);

            }
            catch (Exception)
            {
                Console.WriteLine("The nummber could not be converted to a byte");
            }




        }
    }
}
