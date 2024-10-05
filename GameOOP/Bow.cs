using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOOP
{
    enum ArrowType { Poison, Fire, Ice, Lightning }
    class Bow : Weapon
    {
        public ArrowType Arrow { get; set; }

        public Bow(ArrowType arrow)
        {
            Name = "Bow";
            Range = 5.0f;
            Power = 8;
            Arrow = arrow;
        }
    }
}
