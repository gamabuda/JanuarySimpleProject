using RTSClasses;

NoDefense healthHandler = new();
ArmorOnly armorHandler = new();
MagicDefenseOnly magicHandler = new();
AllDefenses targetWarrior = new();

Warrior warrior = new();
warrior.Mana += 100;

warrior.FlamePunch(healthHandler);

warrior.FlamePunch(armorHandler);

warrior.FlamePunch(magicHandler);

warrior.FlamePunch(targetWarrior);

class NoDefense : IHealthHandler
{
    public int Health { get; set; }
    public int MaxHealth { get; set; }

    public NoDefense()
    {
        Health = 200;
    }
}

class ArmorOnly : IArmorHandler
{
    public int Armor { get; set; }
    public int Health { get; set; }
    public int MaxHealth { get; set; }
    public ArmorOnly()
    {
        Health = 200;
        Armor = 10;
    }
}

class MagicDefenseOnly : IMagicHandler
{
    public int MagicDamage { get; set; }
    public int MagicDefense { get; set; }
    public int Health { get; set; }
    public int MaxHealth { get; set; }
    public int PhysicalDamage { get; set; }
    public int CriticalChance { get; set; }
    public int CriticalDamage { get; set; }

    public MagicDefenseOnly()
    {
        Health = 200;
        MagicDefense = 10;
    }
}

class AllDefenses : IArmorHandler, IMagicHandler
{
    public int Armor { get; set; }
    public int Health { get; set; }
    public int MaxHealth { get; set; }
    public int MagicDamage { get; set; }
    public int MagicDefense { get; set; }
    public int PhysicalDamage { get; set; }
    public int CriticalChance { get; set; }
    public int CriticalDamage { get; set; }

    public AllDefenses()
    {
        Health = 200;
        Armor = 10;
        MagicDefense = 10;
    }
}