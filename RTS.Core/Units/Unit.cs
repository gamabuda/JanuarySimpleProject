namespace RTS.Core;
public class Unit
{
	public int Level { get; set; } = 1;
	public int MaxLevel { get; set; } = 50;
	public int Experience { get; set; } = 1000;
	public int ExpForLevelUp { get; set; } = 3000;
	
	public int MaxHealth { get; set; }
	public int Health { get; set; }
	public int Mana { get; set; }
	public int MaxMana { get; set; }

	public int Strength { get; set; }
	public int Dexterity { get; set; }
	public int Intelligence { get; set; }
	public int Vitality { get; set; }
	public int PDamage { get; set; }
	public int Armor {  get; set; }
	public int MDamage { get; set; }
	public int MDefense { get; set; }
	public int CrtChance { get; set; }
	public int CrtDamage { get; set; }


    public Unit(int Strength, int Dexterity, int Intelligence, int Vitality)
    {
		this.Strength = Strength;
        this.Dexterity = Dexterity;
        this.Intelligence = Intelligence;
        this.Vitality = Vitality;
    }

    public void ShowInfo()
	{
		Console.WriteLine($"Health: {Health}\n Mana: {Mana}\n Strength:{Strength}\n Dexterity: {Dexterity}\n Intelligence: {Intelligence}\n Vitality: {Vitality}");
	}

	public void Attack(Unit unit)
	{
		if (unit.Health < 1)
			return;
		unit.Health -= this.PDamage;

	}

}