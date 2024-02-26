using RTS.Core;
using RTS.Core1;

Wizard unit1 = new Wizard();
Wizard unit2 = new Wizard();
unit1.ShowInfo();

for (int i = 0; i < 10; i++)
{
    unit2.ShowInfo();
}