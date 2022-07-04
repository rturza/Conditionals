using System;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool isGoldCustomer = true;

            //float price;
            //if (isGoldCustomer)
            //    price = 19.95f;
            //else
            //    price = 29.95f;
            //Console.WriteLine(price);

            //statement in a single line
            //float price = (isGoldCustomer) ? 19.95f : 29.95f;
            //Console.WriteLine(price);

            //switch statement starts:
            var season = Season.Autumn;

            switch(season)
            {
                //for same situation for 2 condition:
                case Season.Autumn:
                case Season.Summer:
                    //Console.WriteLine("It's Autumn");
                    //break;
                    Console.WriteLine("We've got promotion.");
                    break ;
               
                default: Console.WriteLine("I can't understand that season");
                    break ;
            }
        }
    }
}
