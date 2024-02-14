﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    internal class Warrior : Unit
    {
        public Warrior(int strength, int dexterity, int intelligence, int vitality) : base(strength, dexterity, intelligence, vitality)
        {
            this.Strength = 30;
            this.Dexterity = 15;
            this.Intelligence = 10;
            this.Vitality = 25;

            Health = Vitality * 2 + Strength;
            Mana = 1 * Intelligence;
            PDamage = 1 * Strength;
            Armor = 1 * Dexterity;
            MDamage = (int)(0.2 * Intelligence);
            MDefense = (int)(0.5 * Intelligence);
            CrtChance = (int)(0.2 * Dexterity);
            CrtDamage = (int)(0.1 * Dexterity);
        }
    }
}