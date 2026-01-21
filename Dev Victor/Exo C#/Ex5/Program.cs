Console.Write("Veuillez saisir un poids (en kg): ");
string? chainePoids = Console.ReadLine();


if (chainePoids == "")
{
    chainePoids = "Poids invalide";
}
    int poids = Convert.ToInt32(chainePoids);
    Console.WriteLine(poids * 2);


    /*string kilo = poids ?? "Poids invalide";*/

    //Console.WriteLine(poids);

/*poids ??= "Poids invalide";
Console.WriteLine(poids);*/

/*string kilo = poids ?? "Poids invalide";
Console.WriteLine(kilo);*/

Console.WriteLine("\n");

Console.WriteLine("Mode de livraison:");
Console.WriteLine("1- Standard");
Console.WriteLine("2- Express");
Console.WriteLine("\n");
Console.Write("Veuillez choisir votre mode de livraison: ");
int livraison = int.Parse(Console.ReadLine());


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