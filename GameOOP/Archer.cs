using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOOP
{
    public class Archer : HumanCharacter
    {
        public Archer(float speed, float power, int health) : base(speed, power, health)
        {
        }

        public void ShootArrow(int damage)
        {
            Console.WriteLine("Archer shoots an arrow, dealing " + damage + " damage!");
        }
    }
}
