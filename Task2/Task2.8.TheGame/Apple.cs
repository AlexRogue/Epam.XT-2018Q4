using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._8.TheGame
{
    class Apple : IBonus
    {
        public void Upgrade(Player player)
        {
            player.StrenghtBonus++;
            player.ArmorBonus++;
        }
    }
}
