using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Lib
{
    public class Unit
    {
        public int Health { get; set; }
        public int Mana { get; set; }

        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Vitality { get; set; }
        public int PDamage { get; set; }
        public int MDamage { get; set; }
        public int Armor { get; set; }
        public int MDefense { get; set; }
        public int CrtChance { get; set; }
        public int CrtDamage { get; set; }
        public int MaxHealth { get; set; }
        public int MaxMana { get; set; }

        public int Lvl { get; set; } = 1;
        public int MaxLvl { get; set; } = 50;
        public int Exp {  get; set; }

        public Unit()
        {
       
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Health: {Health}\n" +
                $"Mana: {Mana}\n" +
                $"Strength: {Strength}\n" +
                $"Dexterity: {Dexterity}\n" +
                $"Intelligence: {Intelligence}\n" +
                $"Vitality: {Vitality}");
        }

        public void Attack(Unit unit)
        {
            if (unit.Health - this.PDamage < 1)
            {
                unit.Health = 0;
                return;
            }

            unit.Health -= this.PDamage;
        }

        public void LevelUp(Unit unit)
        {
            if (unit.Lvl < unit.MaxLvl)
            {
                int Exptoneedlvl = (unit.Lvl - 1) * 1000;

                if (unit.Exp >= Exptoneedlvl)
                {
                    unit.Lvl++;
                    unit.Exp -= Exptoneedlvl; 
                    Console.WriteLine($"Вы достигли уровня {unit.Lvl}!\nВаш текцщий опыт: {unit.Exp}");
                }
                else
                {
                    Console.WriteLine("Недостаточно опыта для повышения уровня.");
                }
            }
            else
            {
                Console.WriteLine("Вы достигли максимального уровня!");
            }
        }
    }
}
