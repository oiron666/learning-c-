﻿using System;
namespace ConsoleApp4
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + ' ' + LastName);
        }

    }
}
