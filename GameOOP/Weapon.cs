using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOOP
{
    enum WeaponType { Sword, Bow }
    internal class Weapon
    {
        public string Name { get; set; }
        public float Range { get; set; }
        public int Power { get; set; }
    }
}
