using RTS.Core;

namespace RTS.Core
{
    public class Barracks : Buildings
    {
        public static Unit CreateNewUnit(string name)
        {
            switch (name)
            {
                case "Warrior":
                    return new Warrior();
                case "Wizzard":
                    return new Wizzard();
                case "Rogue":
                    return new Rogue();
                default:
                    throw new Exception("This unit doesn`t exist");
            }
        }
    }
}
