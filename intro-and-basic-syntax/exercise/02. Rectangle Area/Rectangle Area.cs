using System;

namespace _02._Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            //In the next two lines, we recieve from the Console width and height of a rectangle;
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            //We calculate the area of the rectangle;
            Console.WriteLine($"{a*b:f2}");
        }
    }
}
