using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._8.TheGame
{
    class Wolf : Creature
    {
        public override int Health => 25;

        public override int Movment => throw new NotImplementedException();

        public override int Armor => throw new NotImplementedException();

        public override int Damage => throw new NotImplementedException();

        private int coordX;

        private int coordY;

        IField field;

        public Wolf(IField field)
        {
            this.field = field;
            coordX = new Random().Next(0, field.Height);
            coordY = new Random().Next(0, field.Width);
        }

        public void Move()
        {
            while (Health > 0)
            {
                var rnd = new Random().Next(1, 2);
                if (rnd == 1 & field.Height != coordY)
                {
                    coordX++;
                    coordY--;
                }
                else 
                {
                    if (field.Width != coordX)
                    {
                        coordX--;
                        coordY++;
                    }
                }
            }  
        }
        
        public void Attack()
        {

        }

    }
}
