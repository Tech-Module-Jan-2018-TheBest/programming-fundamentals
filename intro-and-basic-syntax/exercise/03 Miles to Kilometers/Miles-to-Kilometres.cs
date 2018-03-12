using System;

namespace Problem_3.Miles_to_Kilometers
{
    class MilesToKilometres
    {
        static void Main(string[] args)
        {
            //Here we take number(miles) from the console and parse it to double number.
            double mile = double.Parse(Console.ReadLine());

            //Then the number(miles) is multiplied by 1.60934,and printed to the 2nd decimal place on the console. 
            Console.WriteLine($"{(mile * 1.60934):f2}");
        }
    }
}