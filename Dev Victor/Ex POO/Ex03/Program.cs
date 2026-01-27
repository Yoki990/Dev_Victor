using Ex03.Classe;

Personnage p1 = new Personnage("Gimli", 50, 3);
Personnage p2 = new Personnage("Legolas", 50, 5);

while (p1.isAlive() && p2.isAlive())
{
    p1.attack(p2);
    if (p2.isAlive())
    {
        p2.attack(p1);
    }
}

if (p1.isAlive())
{
    Console.WriteLine($"{p1.Name} a gagné. {p1.Health}");
}
else
{
    Console.WriteLine($"{p2.Name} a gagné. {p2.Health}");
}