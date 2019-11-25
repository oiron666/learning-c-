using System;
namespace ConsoleApp4
{
    public class IfExercise
    {
        public IfExercise()
        {
            int hour = 10;
            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning");
            } 
            else if (hour < 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon");
            }
            else
            {
                Console.WriteLine("It's evening");
            }

            bool isGoldCustomer = true;
            float price = isGoldCustomer ? 11.95f : 21.95f;
            Console.WriteLine(price);

            var season = Seasons.Autumn;

            switch (season)
            {
                case Seasons.Autumn:
                case Seasons.Summer:
                    Console.WriteLine("No promo");
                    break;
                case Seasons.Spring:
                    Console.WriteLine("It's spring");
                    break;
                default:
                    Console.WriteLine("I don't know");
                    break

            }

        }
    }
}
