using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOOP
{
    internal class SpeedPotion : Consumables
    {
        public int Speed { get; private set; } = 0;

        // Constructor
        public SpeedPotion(string name, string color, int strength)
            : base(name, "Speed", color, strength)
        {
        }

        // Method to increase speed
        public void GetSpeed()
        {
            Speed += Strength;
            Console.WriteLine($"Speed increased! Current Speed: {Speed}");
        }
    }
}
