using JanuarySimpleProject;
using RTS.Core;

var wizzard = new Wizzard();
var rogue = new Rogue();
var warrior = new Warrior();

warrior.DealDamage(rogue);
Console.WriteLine(rogue.HP);