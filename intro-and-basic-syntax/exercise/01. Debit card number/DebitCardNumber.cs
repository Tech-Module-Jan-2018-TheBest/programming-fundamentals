﻿using System;

namespace Problem_1.Debit_Card_Number
{
    class DebitCardNumber
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());

            Console.Write($"{num1:d4} {num2:d4} {num3:d4} {num4:d4}");
        }
    }
}
