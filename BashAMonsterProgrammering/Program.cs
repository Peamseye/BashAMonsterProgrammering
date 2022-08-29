using System;


Hero zeHero = new Hero();
Goblin zeGoblin = new Goblin();

Console.WriteLine($"{zeHero.name} has {zeHero.hp} health remaining.");
Console.WriteLine($"{zeGoblin.name} has {zeGoblin.health} health and {zeGoblin.armor} armor remaining.");
Console.WriteLine();

Console.WriteLine("HERO ATTACKS!");
zeHero.HeroDamage -= 15 / zeGoblin.armor;
zeGoblin.armor -= 1;
zeGoblin.health -= zeHero.HeroDamage;
Console.WriteLine($"The Goblin took -{zeHero.HeroDamage} damage!");

Console.WriteLine($"{zeGoblin.name} now has {zeGoblin.health} health and {zeGoblin.armor} armor.");

Console.WriteLine("Press any key to continue...");
Console.ReadKey();

zeHero.hp -= zeGoblin.GobDamage;
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("GOBLIN ATTACKS!");
Console.WriteLine($"{zeHero.name} took -{zeGoblin.GobDamage} damage!");
Console.WriteLine($"{zeHero.name} has {zeHero.hp} health left.");

Console.ReadKey();