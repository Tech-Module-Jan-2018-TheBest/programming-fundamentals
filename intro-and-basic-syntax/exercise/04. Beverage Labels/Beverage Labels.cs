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
            string productName = Console.ReadLine();

            /* In the next three lines, we recieve volume,
             * energy and sugar content of our product,
             * as and double */
            double productVolume = double.Parse(Console.ReadLine());
            double productEnergy = double.Parse(Console.ReadLine());
            double productSugar = double.Parse(Console.ReadLine());

            //We calculate energy and sugar;
            double energy = productEnergy * productVolume / 100;
            double sugars = productSugar * productVolume / 100;

            //We print the result;
            Console.WriteLine($"{productVolume}ml {productName}:\r\n{energy}kcal, {sugars}g sugars");

        }
    }
}
