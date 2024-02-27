using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core.Сharacters
{
    public class Wizard : Unit
    {
        public int HealPoint { get; set; } = 10;
        public int FPoint { get; set; } = 3;
        public Wizard()
        {
            Strength = 15;
            Dexterity = 20;
            Intelligence = 35;
            Vitality = 15;

            MaxStrenght = 45;
            MaxDexterity = 80;
            MaxIntelligence = 250;
            MaxVitality = 70;

            Health = (int)(Vitality * 1.5 + Strength * 0.2);
            MaxHealth = Health;
            Mana = (int)(Intelligence * 1.5);
            MaxMana = Mana;
            PDamage = (int)(Strength * 0.5);
            Armor = 1 * Dexterity;
            MDamage = 1 * Intelligence;
            MDefence = 1 * Intelligence;
            CrtChance = (int)(Dexterity * 0.2);
            CrtDamage = (int)(Dexterity * 0.1);

            MaxHealth = Health;
        }

        public void Heal(Unit unit)
        {
            if (Mana < HealPoint)
                return;
            Mana -= HealPoint;
            unit.Health += HealPoint;
        }

        public void Fireball(Unit unit)
        {
            if (Mana <= FPoint)
            {
                Console.WriteLine("Not enough mana to use the fireball");
                return;
            }

            Mana -= FPoint;
            int damage = (Intelligence / 2) + PDamage;
            damage -= MDefence;

            if (damage < 0)
            {
                damage = 0;
            }      
            
            unit.TakeDamage(damage);
            Console.WriteLine($"{this} uses a fireball on {unit} for {damage} damage.");
        }

        public void DoubleDamageAttack(Unit unit)
        {
            if (Mana <= FPoint)
            {
                Console.WriteLine("There is not enough mana to use double damage.");
                return;
            }

            Mana -= FPoint;
            int physicalDamage = PDamage;
            int magicalDamage = MDamage;
            magicalDamage -= MDefence;

            if (magicalDamage < 0)
            {
                magicalDamage = 0;
            }
            if (physicalDamage < 0)
            {
                physicalDamage = 0;
            }

            unit.TakeDamage(physicalDamage + magicalDamage);
            Console.WriteLine($"{this} uses double damage on {unit} for {physicalDamage + magicalDamage} damage.");
        }
    }
}