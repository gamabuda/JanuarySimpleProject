﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Wizard : Hero
    {
        public int HealPoint { get; private set; } = 10;
        public int HealManaCost { get; private set; } = 15;
        public Wizard()
        {
            Strenght = 15;
            Dexterity = 20;
            Intelligence = 35;
            Vitality = 15;

            MaxStrenght = 45;
            MaxDexterity = 80;
            MaxIntelligence = 250;
            MaxVitality = 70;

            Health = MaxHealth;
            Mana = MaxMana;
        }

        public void Heal(IHealthHandler healthHandler)
        {
            if (Mana < HealManaCost)
                return;

            if(healthHandler.GainHealth(HealPoint))
                Mana -= HealManaCost;
        }

        protected override void UpdateStats()
        {
            MaxHealth = (int)(Vitality * 1.4 + Strenght * 0.2);
            MaxMana = (int)(Intelligence * 1.5);
            PhysicalDamage = (int)(Strenght * 0.5);
            MagicalDamage = Intelligence;
            Armor = Dexterity;
            MagicDefense = Intelligence;
            CriticalChance = (int)(Dexterity * 0.05);
            CriticalDamage = (int)(Dexterity * 0.1);
        }
    }
}
