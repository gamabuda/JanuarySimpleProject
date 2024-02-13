using RTS.Core;

Wizard unit1 = new Wizard();
Wizard unit2 = new Wizard();
unit1.ShowInfo();

for (int i = 0; i < 10; i++)
{
    unit1.Attack(unit2);
    unit2.ShowInfo();
}
