using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOOP
{
    internal class Consumables
    {
        // Attributes common to all consumables
        public string Name { get; set; }
        public string EffectType { get; set; }
        public string Color { get; set; }
        public int Strength { get; set; }

        // Constructor
        public Consumables(string name, string effectType, string color, int strength)
        {
            Name = name;
            EffectType = effectType;
            Color = color;
            Strength = strength;
        }

        // Method to display the consumable details (optional for testing)
        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}, Effect: {EffectType}, Color: {Color}, Strength: {Strength}");
        }
    }
}
