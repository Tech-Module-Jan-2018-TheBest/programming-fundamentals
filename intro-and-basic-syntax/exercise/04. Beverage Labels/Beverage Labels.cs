using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            //We recieve from the Console the product name -> a string;
            string bevarage = Console.ReadLine();

            /* In the next three lines, we recieve volume,
             * energy and sugar content of our product,
             * as and double */
            double volume = double.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double sugar = double.Parse(Console.ReadLine());

            //We calculate energy and sugar;
            double energyTotal = energy * volume / 100;
            double sugarTotal = sugar * volume / 100;

            //We print the result;
            Console.WriteLine($"{volume}ml {bevarage}:\r\n{energyTotal}kcal, {sugarTotal}g sugars");

        }
    }
}
