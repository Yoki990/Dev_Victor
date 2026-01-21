Console.Write("Veuillez saisir un poids (en kg): ");
string? chainePoids = Console.ReadLine();

Console.WriteLine("\n");

Console.WriteLine("Mode de livraison:");
Console.WriteLine("1- Standard");
Console.WriteLine("2- Express");
Console.WriteLine("\n");
Console.Write("Veuillez choisir votre mode de livraison: ");
string? chaineLivraison = Console.ReadLine();

int poids = -1;
int livraison;

if (chainePoids == "")
{
    chainePoids = "Poids invalide";
    Console.WriteLine(chainePoids);
}
else
{
    poids = Convert.ToInt32(chainePoids);
    Console.WriteLine("Poids = " + poids + "" + poids.GetType());
    if (chaineLivraison == "")
    {
        chaineLivraison = "Mode invalide";
        Console.WriteLine(chaineLivraison);
    }
    else
    {
        livraison = Convert.ToInt32(chaineLivraison);
        Console.WriteLine(livraison);

        if (poids <= 0)
        {

        }
    }
}

/*if (poids <= 0)*/
/*Console.WriteLine($"Avec {chainePoids} kg et un mode de livraison express: le tarif de livraison est de az");*/


/*int saisie = poids ?? 0;

int camion = livraison ?? 0;

if (poids <= 0 || saisie ==0)
{
    Console.WriteLine("Poids invalide");
}
else if (livraison > 2 || camion <= 0)
{
    Console.WriteLine("Mode invalide");
}




if (poids <= 1)
{
    if (livraison == 1)
    {
        Console.WriteLine("Le tarif de livraison est de 4.99");
    }
    else
    {
        Console.WriteLine("Le tarif de livraison est de 7.99");
    }
}
else if (poids <= 5)
{
    if (livraison == 1)
    {
        Console.WriteLine("Le tarif de livraison est de 6.99");
    }
    else
    {
        Console.WriteLine("Le tarif de livraison est de 10.99");
    }
}
else
{
    if (livraison == 1)
    {
        Console.WriteLine("Le tarif de livraison est de 9.99");
    }
    else
    {
        Console.WriteLine("Le tarif de livraison est de 14.99");
    }
}
*/