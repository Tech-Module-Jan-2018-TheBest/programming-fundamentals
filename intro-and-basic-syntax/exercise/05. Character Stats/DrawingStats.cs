using System;

namespace DrawingStats
{
    class DrawingStats
    {
        static void Main(string[] args)
        {
            String name = Console.ReadLine();
            int currHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            string healthAsTxt = new string('|', currHealth);
            string healthMissing = new string('.', maxHealth - currHealth);

            string eneryAsTxt = new string('|', currEnergy);
            string eneryMissing = new string('.', maxEnergy-currEnergy);

            Console.WriteLine("Name: {0}",name);
            Console.WriteLine("Health: |{0}{1}|",healthAsTxt,healthMissing);
            Console.WriteLine("Energy: |{0}{1}|",eneryAsTxt,eneryMissing);

        }
    }
}
