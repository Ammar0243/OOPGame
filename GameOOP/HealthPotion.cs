using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOOP
{
    internal class HealthPotion : Consumables
    {
        public int Health { get; private set; } = 0;


    //Constructor
    public HealthPotion(string name, string color, int strength)
    : base(name, "Health", color, strength)
    {
    }

    // Method to increase health
    public void GetHealth()
    {
        Health += Strength;
        Console.WriteLine($"Health increased! Current Health: {Health}");
    }
}
}
