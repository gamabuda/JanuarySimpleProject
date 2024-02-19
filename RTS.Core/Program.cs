using RTS.Core;
using RTS.Core.Buildings;
using System;


    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Unit war = CreateUnit("warrior");

    //        war.Points = 1000;
    //        war.LevelUp();
    //        Console.WriteLine(war.Points + "\t" + war.Level);

    //        war.Points = 3000;
    //        war.LevelUp();
    //        Console.WriteLine(war.Points + "\t" + war.Level);

    //        war.Points = 6000;
    //        war.LevelUp();
    //        Console.WriteLine(war.Points + "\t" + war.Level);

    //        war.Points = 10000;
    //        war.LevelUp();
    //        Console.WriteLine(war.Points + "\t" + war.Level);

    //        war.Points = 15000;
    //        war.LevelUp();
    //        Console.WriteLine(war.Points + "\t" + war.Level);

    //        war.Points = 21000;
    //        war.LevelUp();
    //        Console.WriteLine(war.Points + "\t" + war.Level);

    //        war.Points = 28000;
    //        war.LevelUp();
    //        Console.WriteLine(war.Points + "\t" + war.Level);

    //        Console.ReadLine();
    //    }

    //    static Unit CreateUnit(string unitType)
    //    {
    //        return new Unit();
    //    }
    //}
    var wizzard = new Wizard();
    var rogue = new Rogue();
    var warrior = new Warrior();

    warrior.DealDamage(rogue);
Console.WriteLine("Rogue: (HP) " + rogue.HP);

rogue.ShowInfo();
Console.WriteLine(rogue.MaxHealth);

var w = Barrack.CreateUnit("Wizzard");


    //public class Unit
    //{
    //    public int Points { get; set; }
    //    public int Level { get; private set; }

    //    public void LevelUp()
    //    {
    //        if (Points >= (Level * 2000))
    //        {
    //            Level++;
    //        }
    //    }
    //}
