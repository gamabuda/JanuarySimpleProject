using RTS.Core;

using RTS.Core.Characters;
using RTS.Core.Interfaces;
using RTS.Core.Building;
using System;
using RTS.Core.Building;
using RTS.Core.Interfaces;

class Program
{
    static void Main(string[] args)
    {
        Warrior warrior = new Warrior();
        Rogue rogue = new Rogue();
        Wizard wizard = new Wizard();

        Barrack barrack = new Barrack();
        Church church = new Church();

        Unit warriorFromBarrack = barrack.CreateCharacter("warrior");
        Unit rogueFromBarrack = barrack.CreateCharacter("rogue");
        Unit wizardFromBarrack = barrack.CreateCharacter("wizard");

        Console.WriteLine("Warrior from Barrack:");
        warriorFromBarrack.ShowInfo();
        Console.WriteLine();

        Console.WriteLine("Rogue from Barrack:");
        rogueFromBarrack.ShowInfo();
        Console.WriteLine();

        Console.WriteLine("Wizard from Barrack:");
        wizardFromBarrack.ShowInfo();
        Console.WriteLine();

        church.Pray(warrior);
        church.Pray(rogue);
        church.Pray(wizard);

        warrior.Attack(rogue);
        rogue.Attack(wizard);
        wizard.Attack(warrior);

        wizard.GetExperience(1200);

        Console.WriteLine($"Wizard's Level: {wizard.Level}");

        wizard.Heal(warrior);

        Console.WriteLine($"Warrior's Health after healing: {warrior.Health}");
    }
}
