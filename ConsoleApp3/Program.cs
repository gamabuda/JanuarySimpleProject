using Classes;

IHealthHandler healthHandler = new Warrior();
var armorgetter = typeof(IArmorHandler).GetMethod("get_Armor");
int Armor = Convert.ToInt32(armorgetter?.Invoke(healthHandler, null));