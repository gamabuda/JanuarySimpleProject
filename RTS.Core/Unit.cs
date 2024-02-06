namespace RTS.Core;

public class Unit
{
    public int Health { get; set; }
    public int Mana { get; set; }

    public int Strenght { get; set; }
    public int Dexterity { get; set; }
    public int Intelligence { get; set; }
    public int Vitality { get; set; }
    public int Damage { get; set; }

    public Unit(int Strenght, int Dexterity, int Inteligence, int Vitality)
    {
        this.Strenght = Strenght;
        this.Dexterity = Dexterity;
        this.Intelligence = Intelligence;
        this.Vitality = Vitality;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Health: {Health}\n Mana: {Mana}\n Strenght: {Strenght}\n Dexterity: {Dexterity}\n Intelligence: {Intelligence}\n Vitality: {Vitality}");
    }
}