using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._8.TheGame
{
    class Cherry : IBonus
    {
        public void Upgrade(Player player)
        {
            player.SpeedBonus++;
            player.HealthBonus++;
        }
    }
}
