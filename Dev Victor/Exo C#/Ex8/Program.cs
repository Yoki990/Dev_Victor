Console.Write("Veuillez saisir un entier n: ");

if (int.TryParse(Console.ReadLine(), out int n))
{
   if (n < 0)
    {
        Console.WriteLine($"{n} est négatif");
    }
   else if (n > 0)
    {
        Console.WriteLine($"{n} est positif");
    }
    else
    {
        Console.WriteLine($"{n} est nul");
    }

    if (n % 2 == 0)
    {
        Console.WriteLine($"{n} est pair");
    }
    else
    {
        Console.WriteLine($"{n} est impair");
    }

    if (n >= -10 || n <= 10)
    {
        Console.WriteLine($"{n} est dans l'intervalle [-10;10]");
    }
    else
    {
        Console.WriteLine($"{n} n'est pas dans l'intervalle [-10;10]");
    }
}
else
{
    Console.WriteLine("Entier invalide");
}