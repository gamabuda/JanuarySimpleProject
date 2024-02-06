using JanuarySimpleProject;
using RTS.Core;

var wizzard = new Wizzard();
var rogue = new Rogue();
var warrior = new Warrior();

warrior.DealDamage(rogue, 0.01);
Console.WriteLine(rogue.HP);