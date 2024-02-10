using JanuarySimpleProject;

namespace RTS.Core
{
    public class Barracks : Unit
    {
        public Unit CreateNewWarrior() { return new Warrior(); }
        public Unit CreateNewWizzard() { return new Wizzard(); }
        public Unit CreateNewRogue() { return new Rogue(); }
    }
}
