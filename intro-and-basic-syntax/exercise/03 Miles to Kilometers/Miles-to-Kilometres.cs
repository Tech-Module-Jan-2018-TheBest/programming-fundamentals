using System;

namespace Problem_3.Miles_to_Kilometers
{
    class MilesToKilometres
    {
        static void Main(string[] args)
        {
            //Here we take number(miles) from the console and parse it to double number.
            double distanceInMiles = double.Parse(Console.ReadLine());

            //Then the number(miles) is multiplied by 1.60934,and printed to the 2nd decimal place on the console. 
            Console.WriteLine($"{(distanceInMiles * 1.60934):f2}");
        }
    }
}