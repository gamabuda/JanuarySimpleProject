using Classes;

Warrior warrior = new Warrior(100, 50, 50, 50);
warrior.ShowInfo();

for(int i = 0; i < 100; i++)
{
    warrior.UpgradeStrenght(10);
    warrior.ShowInfo();
}