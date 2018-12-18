using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._8.TheGame
{
    class Wolf : Creature
    {

        int health;
        int move;
        int arm;
        int dmg;

        public override int Health => health;

        public override int Movment => move;

        public override int Armor => arm;

        public override int Damage => dmg;

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
        
        public void Attack(Player player)
        {
            if (player.coordX.Equals(coordX) & player.coordY.Equals(coordY))
            {
                if (player.Movment > Movment || player.StrenghtBonus > Armor)
                {
                    health--;
                }
                else
                {
                    player.HealthBonus--;
                }
            }
        }

    }
}
