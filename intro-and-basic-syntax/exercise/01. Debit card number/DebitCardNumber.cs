using System;

namespace Problem_1.Debit_Card_Number
{
    class DebitCardNumber
    {
        static void Main(string[] args)
        {
            // Here we writo on the console 4 integers numbers
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int number4 = int.Parse(Console.ReadLine());

            // Here we print them on the console as 4 digits long debit card numbers.
            Console.Write($"{number1:d4} {number2:d4} {number3:d4} {number4:d4}");
        }
    }
}
