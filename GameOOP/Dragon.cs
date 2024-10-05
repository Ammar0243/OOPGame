using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOOP
{
    internal class Dragon : Animal
    {
        public bool BreathFire { get; set; }
        public int FireDamage { get; set; }

        public override void Attack()
        {
            //if player in the range, dragon attack the player
            // Dragon attack player
        }

        public override void TakeDamage(int damage)
        {
            //if player attack on dragons successful, minus the health
            // Dragon take damage from player
        }

        public override void Update()
        {
            //dragon moves
            // Update dragons status (position)
        }



    }
}
