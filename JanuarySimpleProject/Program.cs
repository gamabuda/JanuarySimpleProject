using RTS.Core1;

Wizard unit1 = new Wizard(50, 50, 50, 50);
Wizard unit2 = new Wizard(50, 50, 50, 50);
unit1.ShowInfo();

for (int i = 0; i < 10; i++)
{
    unit1.Attack(unit2);
    unit2.ShowInfo();
}
Barracks barracks = new Barracks("Wizzard", 15, 20, 35, 15);
Unit wizzard = barracks.CreateUnit("Wizzard");