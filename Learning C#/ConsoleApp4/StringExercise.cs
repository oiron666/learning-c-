using System;
namespace ConsoleApp4
{
    public class StringExercise
    {
        public StringExercise()
        {
            var firstName = "Marcel";
            var lastName = "Biniek";

            var fullname = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3] { "Anna", "Ola", "Ala" };
            var joinedNames = string.Join(",", names);


            var text = "Hi! \n Have a look into the path \n c:\\My Documents\\files";
            var verbatimText = @"Hi! 
            Have a look into the path
            c:\My Documents\files";

            Console.WriteLine(joinedNames);
            Console.WriteLine(text);
            Console.WriteLine(verbatimText);

        }
    }
}
