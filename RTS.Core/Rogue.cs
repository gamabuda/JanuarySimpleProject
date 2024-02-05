using RTS.Core;
using System.Reflection.Metadata;

namespace JanuarySimpleProject
{
    public class Rogue : Unit
    {
        public Rogue(int Strength, int Dexterity, int Inteligence, int Vitality) : base(Strength, Dexterity, Inteligence, Vitality)
        {
            HP = 1.5 / Vitality + 0.5 / Strength;
            Mana = 1.2 / Inteligence;
        }
    }
}
