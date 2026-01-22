Random aleatoire= new Random();
int nb = aleatoire.Next(1,51);

int tentatives = 1;

Console.Write("Veuillez saisir un nombre: ");
int nbStr = int.Parse(Console.ReadLine());
while (nbStr != nb)
{

    if (nbStr > nb)
    {
        Console.WriteLine("Le nombre mystère est plus petit\n");
        Console.Write("Veuillez saisir un nombre: ");
        nbStr = int.Parse(Console.ReadLine());
        tentatives++;
    }
    else
    {
        Console.WriteLine("Le nombre mystère est plus grand\n");
        Console.Write("Veuillez saisir un nombre: ");
        nbStr = int.Parse(Console.ReadLine());
        tentatives++;
    }
}

Console.WriteLine($"\nBravo !!! Vous avez trouvé le nombre mystère en {tentatives} tentatives.");
