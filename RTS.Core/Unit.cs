﻿namespace RTS.Core
{
    public class Unit
    {
        public int Vitality { get; set; }
        public int Mana { get; set; }
        public int Health { get; set; }
        public int Strenght { get; set; }
        public int Dexterity { get; set; }
        public int Inteligense { get; set; }

        public Unit(int Strenght, int Dexterity, int Inteligense, int Vitality)
        {
            this.Strenght = Strenght;
            this.Dexterity = Dexterity;
            this.Inteligense = Inteligense;
            this.Vitality = Vitality;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Health: {Health}\nMana: {Mana}\nS: {Strenght}\nD: {Dexterity}\nI: {Inteligense}\nV: {Vitality}");
        }
        public void Damage()
        {

        }

        public void Attack(Unit unit)
        {
            if (unit.Health - this.Damage < 1)
            {
                Unit.Health = 0;
                return;
            }

        }

        public void Heal(Unit unit)
        {
            if (Mana > 15)
                return;

            Mana -= 15;
            unit.Heal += HealPoint
        }

    }