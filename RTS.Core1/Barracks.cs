using RTS.Core1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core1
{
    public class Barracks : IHPHandler, IArmorHandler, IAttackHandler
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
        public Unit CreateUnit(string unitType)
        {
            switch (unitType)
            {
                case "Wizard":
                    return new Wizard();
                case "Warrior":
                    return new Warrior();
                case "Rogue":
                    return new Rogue();
                default:
                    throw new ArgumentException("Unknown unit type");
            }
        }
    }
}

