using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOOP
{
    public abstract class Animal
    {
        public float Speed { get; set; }
        public float Power { get; set; }
        public int Health { get; set; }
        public float Range { get; set; }

        public abstract void Attack();
        public abstract void TakeDamage(int damage);
        public abstract void Update();

    }
}
