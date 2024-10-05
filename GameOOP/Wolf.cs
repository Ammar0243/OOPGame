using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOOP
{
    internal class Wolf : Animal
    {
        public override void Attack()
        {
            // Wolf attack player
        }

        public override void TakeDamage(int damage)
        {
            // Wolf take damage from player
        }

        public override void Update()
        {
            // Update wolves status (position/health)
        }
    }
}
