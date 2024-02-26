using RTS.Core1.Interfaces;
using RTS.Core1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    public class Church : IHPHandler, IArmorHandler, IAttackHandler
    {
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int PDamage { get; set; }
        public void Armorr(Unit unit)
        {

        }
        public void PAttack(Unit unit)
        {

        }
        public int MDamage { get; set; }
        public void MAttack(Unit unit)
        {

        }
        public int CrtChance { get; set; }
        public int CrtDamage { get; set; }
        public int Armor { get; set; }
        public int MDefence { get; set; }

        public int RegenMana { get; set; } = 15;

        public void Pray(Unit unit)
        {
            if (unit.Mana == unit.MaxMana)
                return;

            if (unit is Wizard)
            {
                unit.Mana += RegenMana * 2;
                if (unit.Mana > unit.MaxMana)
                {
                    unit.Mana = unit.MaxMana;
                }
            }

            else if (unit is Rogue)
            {
                unit.Mana += RegenMana / 2;
                if (unit.Mana > unit.MaxMana)
                {
                    unit.Mana = unit.MaxMana;
                }
            }
            else
                unit.Mana += RegenMana;


        }
    }
}