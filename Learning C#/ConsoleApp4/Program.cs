using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp4.Math;

namespace ConsoleApp4
{


    class Program
    {
        static void Main(string[] args)
        {
            var marcin = new Person();
            marcin.FirstName = "Marcel";
            marcin.LastName = "Bieniek";
            marcin.Introduce();


            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 4);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
    class OperatorExercise
    {
        static void Main2(string[] args)
        {
            //random stuff
            var num1 = 3;
            var num2 = 8;
            
            /*
             *random stuff too 
             */
            Console.WriteLine(num2 / num1);
            Console.WriteLine((float)num2 / (float)num1);
            Console.WriteLine(!((float)num1 == num2 && num1 > num2));
            Console.ReadKey();
        }

    }

    class convertExercise
    {
        static void Main2(string[] args)
        {
            try
            {
                string strNumber = "1234";
                int number = Convert.ToInt32(strNumber);
                byte byteNumber = (byte)number;
                byte strToByteNumber = Convert.ToByte(strNumber);
                string booleanString = "false";
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
