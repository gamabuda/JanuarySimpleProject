using RTS.Core;
using System.Reflection.Metadata;

namespace JanuarySimpleProject
{
    public class Rogue : Unit
    {
        public Rogue()
        {
            this.Strength = 20;
            this.Dexterity = 30;
            this.Inteligence = 15;
            this.Vitality = 20;

            HP = (int)(Vitality / 1.5 + Strength / 0.5);
            Mana = (int)(Inteligence / 1.2);
            Damage = (int)(Strength / 1 + Strength / 0.5 + Dexterity / 0.5 + Strength / 0.5);

            MaxHealth = Health;
            MaxMana = Mana;
        }
    }
}
