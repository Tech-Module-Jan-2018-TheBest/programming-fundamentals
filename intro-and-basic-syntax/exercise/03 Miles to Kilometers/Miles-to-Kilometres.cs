using System;

namespace Problem_3.Miles_to_Kilometers
{
    class MilesToKilometres
    {
        static void Main(string[] args)
        {
            double mile = double.Parse(Console.ReadLine());
            Console.WriteLine($"{(mile * 1.60934):f2}");
        }
    }
}