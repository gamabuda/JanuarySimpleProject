using RTS.Core;
using RTS.Core.Buildings;

Unit war = Barrack.CreateUnit("warrior");

//for (var i = 0; i < 100000; i += 1000)
//{
//    war.Points = i;
//    war.LevelUp();
//    Console.WriteLine(war.Points + "\t" + war.Level);
//}

war.Points = 1000;
war.LevelUp();
Console.WriteLine(war.Points + "\t" + war.Level);

war.Points = 3000;
war.LevelUp();
Console.WriteLine(war.Points + "\t" + war.Level);

war.Points = 6000;
war.LevelUp();
Console.WriteLine(war.Points + "\t" + war.Level);