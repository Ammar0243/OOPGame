using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOOP
{
    public class Player
    {
        public string Name { get; set; }
        public float Speed { get; set; }
        public float Power { get; set; }
        public float Health { get; set; }
        public float PositionX { get; set; }
        public float PositionY { get; set; }

        public Player(string name, float speed, float power, float health, float positionX, float positionY)
        {
            Name = name;
            Speed = speed;
            Power = power;
            Health = health;
            PositionX = positionX;
            PositionY = positionY;
        }

        public void Attack()
        {
            Console.WriteLine($"{Name} attacks with a power of {Power}");
        }

        public void Move(float newX, float newY)
        {
            PositionX = newX;
            PositionY = newY;
            Console.WriteLine($"{Name} moved to ({PositionX}, {PositionY})");
        }

        public void TakeDamage(float damage)
        {
            Health -= damage;
            if (Health < 0)
            {
                Health = 0;
            }
            Console.WriteLine($"{Name} took {damage} damage. Remaining health: {Health}");
        }

        public void DisplayStats()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Speed: {Speed}");
            Console.WriteLine($"Power: {Power}");
            Console.WriteLine($"Health: {Health}");
            Console.WriteLine($"Position: ({PositionX}, {PositionY})");
        }
    }
}
