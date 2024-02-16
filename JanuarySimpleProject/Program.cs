using Classes;

int lvl = 5;
int exp = 11000;

int defLvlExp = lvl * (lvl - 1) / 2 * 1000;

int next = lvl * 1000;

int nextExp = defLvlExp + next;

Warrior warrior = new Warrior();
Console.WriteLine(warrior.Experience);
Console.WriteLine(warrior.Level);
warrior.GainXp(5000);
Console.WriteLine(warrior.Experience);
Console.WriteLine(warrior.Level);
warrior.GainXp(1000);
Console.WriteLine(warrior.Experience);
Console.WriteLine(warrior.Level);
warrior.GainXp(10000000);
Console.WriteLine(warrior.Experience);
Console.WriteLine(warrior.Level);