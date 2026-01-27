void AfficherTable(int nb, int limite = 10)
{
    for (int i = 0; i <= limite; i++)
    {
        Console.WriteLine($"{nb} x {i} = {nb * i}");
    }
}

Console.Write($"Veuillez saisir un nombre: ");
int nb = int.Parse(Console.ReadLine());
Console.WriteLine();

AfficherTable(nb);