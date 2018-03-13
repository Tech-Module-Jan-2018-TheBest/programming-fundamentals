using System;

namespace DrawingStats
{
    class DrawingStats
    {
        static void Main(string[] args)
        {
            /*First we recieve from the console 5 entries - name, 
             * current health, max health, current energy and max energy */
            String championName = Console.ReadLine();
            int totalHealth = int.Parse(Console.ReadLine());
            int fullHealth = int.Parse(Console.ReadLine());
            int totalEnergy = int.Parse(Console.ReadLine());
            int fullEnergy = int.Parse(Console.ReadLine());

            // We create two new strings representing the health bars;
            string remainingHealth = new string('|', totalHealth);
            string missingHealth = new string('.', fullHealth - totalHealth);

            // We create two new strings representing the energy bars;
            string remainingEnergy = new string('|', totalEnergy);
            string missingEnergy = new string('.', fullEnergy-totalEnergy);

            //On the console we print the wanted output;
            Console.WriteLine("Name: {0}",championName);
            Console.WriteLine("Health: |{0}{1}|",remainingHealth,missingHealth);
            Console.WriteLine("Energy: |{0}{1}|", remainingEnergy, missingEnergy);

        }
    }
}
