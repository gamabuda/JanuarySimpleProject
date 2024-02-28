using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RTSClasses
{
    public class Warrior : Hero, IArmorHandler, IAttackHandler, IMagicHandler
    {
        public Warrior()
        {
            Strenght = 30;
            Dexterity = 15;
            Intelligence = 10;
            Vitality = 25;

            MaxStrenght = 250;
            MaxDexterity = 80;
            MaxIntelligence = 50;
            MaxVitality = 100;

            Health = MaxHealth;
            Mana = MaxMana;
        }

        protected override void UpdateStats()
        {
            MaxHealth = Vitality * 2 + Strenght;
            MaxMana = Intelligence;
            PhysicalDamage = Strenght;
            MagicDamage = (int)(Intelligence * 0.2);
            Armor = Dexterity;
            MagicDefense = (int)(Intelligence * 0.5);
            CriticalChance = (int)(Dexterity * 0.05);
            CriticalDamage = (int)(Dexterity * 0.1);
        }
        public void FlamePunch(IHealthHandler healthHandler)
        {
            if (Mana < 20)
                return;

            if (healthHandler is IArmorHandler && healthHandler is IMagicHandler)
            {
                var armorGetter = typeof(IArmorHandler).GetMethod("get_Armor");
                int Armor = Convert.ToInt32(armorGetter?.Invoke(healthHandler, null));
                var magicDefenseGetter = typeof(IMagicHandler).GetMethod("get_MagicDefense");
                int MagicDefense = Convert.ToInt32(magicDefenseGetter?.Invoke(healthHandler, null));
                healthHandler.InflictDamage(CalculatePhysDamage(Armor) + CalculateMagicDamage(MagicDefense));
                Console.WriteLine($"Armor:{Armor}, MagicDefense:{MagicDefense}");
            }
            else if (healthHandler is IArmorHandler)
            {
                var armorGetter = typeof(IArmorHandler).GetMethod("get_Armor");
                int Armor = Convert.ToInt32(armorGetter?.Invoke(healthHandler, null));
                healthHandler.InflictDamage(CalculatePhysDamage(Armor) + MagicDamage);
                Console.WriteLine($"Armor:{Armor}");
            }
            else if (healthHandler is IMagicHandler)
            {
                var magicDefenseGetter = typeof(IMagicHandler).GetMethod("get_MagicDefense");
                int MagicDefense = Convert.ToInt32(magicDefenseGetter?.Invoke(healthHandler, null));
                healthHandler.InflictDamage(PhysicalDamage + CalculateMagicDamage(MagicDefense));
                Console.WriteLine($"MagicDefense:{MagicDefense}");
            }
            else
            {
                healthHandler.InflictDamage(PhysicalDamage + MagicDamage);
                Console.WriteLine("No any defenses");
            }
            Mana -= 20;
        }
    }
}