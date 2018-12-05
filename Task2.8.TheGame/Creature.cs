using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._8.TheGame
{
    abstract class Creature
    {
        public abstract int Health { get; }
        public abstract int Movment { get; }
        public abstract int Armor { get; }
        public abstract int Damage { get; }
        //public abstract int coordX { get; }
        //public abstract int coordY { get; }
    }
}
