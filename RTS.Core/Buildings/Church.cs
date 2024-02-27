using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RTS.Core.Interfaces;
using RTS.Core.Units;

namespace RTS.Core.Buildings
{
    public class Church : IBuilding
    {
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int PrayPoint { get; set; } = 10;
        public void Pray(IManaHandler manaHandler)
        {
            if (manaHandler.Mana == manaHandler.MaxMana)
                return;

            if (manaHandler is Wizard && manaHandler.Mana + PrayPoint * 2 <= manaHandler.MaxMana)
                manaHandler.Mana += PrayPoint * 2;
            else if (manaHandler is Rogue && manaHandler.Mana + PrayPoint / 2 <= manaHandler.MaxMana)
                manaHandler.Mana += PrayPoint / 2;
            else if (manaHandler is Warrior && manaHandler.Mana + PrayPoint <= manaHandler.MaxMana)
                manaHandler.Mana += PrayPoint;
            else
                throw new Exception("При увеличении мана превысит максимальное значение!");
        }
    }
}
