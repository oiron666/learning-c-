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

            var stringOperations = new StringExercise();

            var express = ShippingMethod.Express;

            var expressId = 3;
            Console.WriteLine((ShippingMethod)expressId);

            Console.WriteLine((int)express);
            Console.WriteLine(express.ToString());

            var expressName = "Express";
            var shipping = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), expressName);

            var valueType = new ValueType();

            var number = 1;
            Increment(number);

            var alak = new Person() {Age = 25};
            MakeOlder(alak);
            Console.WriteLine(alak.Age);

        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOlder(Person person)
        {
            person.Age += 10;
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
