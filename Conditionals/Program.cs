using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                case Season.Autumn:
                    Console.WriteLine("It's Autumn");
                    break;
                case Season.Summer:
                    Console.WriteLine("It's Summer");
                    break ;
               
                default: Console.WriteLine("I can't understand that season");
                    break ;
            }
        }
    }
}
