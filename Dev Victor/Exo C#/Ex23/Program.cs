using System;

void DecrireNombre(int nb)
{
    if (nb > 0)
    {
        Console.WriteLine($"{nb} est positif");
    }
    else if (nb < 0)
    {
        Console.WriteLine($"{nb} est négatif");
    }
    else
    {
        Console.WriteLine($"{nb} est nul");
    }
}

Console.Write($"Veuillez saisir un nombre: ");
int nb = int.Parse(Console.ReadLine());
Console.WriteLine();
DecrireNombre(nb);