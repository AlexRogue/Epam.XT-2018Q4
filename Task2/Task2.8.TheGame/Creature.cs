using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._8.TheGame
{
    abstract class Creature
    {
        public abstract int Health { get; set; }
        public abstract int Movment { get; set; }
        public abstract int Armor { get; set; }
        public abstract int Damage { get; set; }
    }
}
