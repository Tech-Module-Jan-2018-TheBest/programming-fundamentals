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
            string bevarage = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double sugar = double.Parse(Console.ReadLine());

            double energyTotal = energy * volume / 100;
            double sugarTotal = sugar * volume / 100;

            Console.WriteLine($"{volume}ml {bevarage}:\r\n{energyTotal}kcal, {sugarTotal}g sugars");

        }
    }
}
