void CompterPairs(int[] nb)
{
    int compteur = 0;
    for (int i = 0; i < nb.Length; i++)
    {
        if (nb[i]%2 == 0)
        {
            compteur++;
        }
    }

    Console.WriteLine("\nLe nombres de valeurs pairs est de " + compteur);
}

int[] nbTab= new int[5];
int nbNote = 1;

do
{
    Console.Write($"Veuillez saisir le nombre n°{nbNote}: ");
    /*int note = int.Parse(Console.ReadLine());*/
    if (int.TryParse(Console.ReadLine(), out int nb))
    {
        nbTab[nbNote - 1] = nb;
        nbNote++;
    }
    else
    {
        Console.WriteLine("Mauvaise saisie!!!");
    }
}
while (nbNote <= nbTab.Length);

CompterPairs(nbTab);