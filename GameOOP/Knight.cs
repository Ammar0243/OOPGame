using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOOP
{
    public class Knight : HumanCharacter
    {
        public Knight(float speed, float power, int health) : base(speed, power, health)
        {

        }

        public void Attack(int damage)
        {
            Console.WriteLine("Knight uses attack , dealing " + damage + " damage!");
        }
    }

}
