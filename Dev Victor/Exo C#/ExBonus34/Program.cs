Console.Write("Veuillez saisir un nombre: ");
int longueur = int.Parse(Console.ReadLine());

int[] alea = new int[longueur];

Console.WriteLine();

for (int i = 0; i < longueur; i++)
{
    Random aleatoire = new Random();
    int nb = aleatoire.Next(1, 51);
    alea[i] = nb;

    if (alea[i]%2 == 0)
    {
        Console.WriteLine($"    Le nombre {alea[i]} est pair.");
    }
    else
    {
        Console.WriteLine($"    Le nombre {alea[i]} est impair.");
    }
        
}