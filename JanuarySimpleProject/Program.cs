using RTS.Core.Buildings;
using RTS.Core.Units;

Unit war = Barrack.CreateUnit("warrior");

for (var i = 0; i < 100000; i+=1000)
{
    war.Experience = i;
    war.LevelUp();
    Console.WriteLine($"Опыт: {war.Experience}\nУровень: {war.Level}\n");
}

for (var i = 0; i < 1300000; i += 10000)
{
    war.Experience = i;
    war.LevelUp();
    Console.WriteLine($"Опыт: {war.Experience}\nУровень: {war.Level}\n");
}