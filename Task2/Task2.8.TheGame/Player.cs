using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._8.TheGame
{
    class Player 
    {
        public int HealthBonus { get; set; }

        public int SpeedBonus { get; set; }

        public int ArmorBonus { get; set; }

        public int StrenghtBonus { get; set; }

        public  int Health => 100 + HealthBonus;

        public int Movment => 10 + SpeedBonus;

        public int Armor => 30 + ArmorBonus;

        public int Damage => 15 + StrenghtBonus + SpeedBonus;

        
        IField field;
        public int coordX { get; }
        public int coordY { get; }

        public Player(IField field)
        {
            this.field = field;
            coordX = new Random().Next(0, field.Height);
            coordY = new Random().Next(0, field.Width);
        }

    }
}
