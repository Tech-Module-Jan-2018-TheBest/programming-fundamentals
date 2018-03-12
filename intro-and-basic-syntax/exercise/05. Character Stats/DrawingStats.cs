using System;

namespace DrawingStats
{
    class DrawingStats
    {
        static void Main(string[] args)
        {
            String championName = Console.ReadLine();
            int totalHealth = int.Parse(Console.ReadLine());
            int fullHealth = int.Parse(Console.ReadLine());
            int totalEnergy = int.Parse(Console.ReadLine());
            int fullEnergy = int.Parse(Console.ReadLine());

            string remainingHealth = new string('|', totalHealth);
            string missingHealth = new string('.', fullHealth - totalHealth);

            string remainingEnergy = new string('|', totalEnergy);
            string missingEnergy = new string('.', fullEnergy-totalEnergy);

            Console.WriteLine("Name: {0}",championName);
            Console.WriteLine("Health: |{0}{1}|",remainingHealth,missingHealth);
            Console.WriteLine("Energy: |{0}{1}|",leftedEnergy,missingEnergy);

        }
    }
}
