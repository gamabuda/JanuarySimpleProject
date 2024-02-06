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
            HP = 1.5 / Vitality + 0.5 / Strength;
            Mana = 1.2 / Inteligence;
            Damage = 1 / Strength + 0.5/Strength + 0.5/Dexterity + 0.5/Strength;
        }
    }
}
