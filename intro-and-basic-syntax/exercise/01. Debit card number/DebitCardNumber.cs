using System;

namespace Problem_1.Debit_Card_Number
{
    class DebitCardNumber
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int number4 = int.Parse(Console.ReadLine());

            Console.Write($"{number1:d4} {number2:d4} {number3:d4} {number4:d4}");
        }
    }
}
