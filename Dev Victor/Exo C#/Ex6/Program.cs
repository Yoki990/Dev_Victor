int errone=0;

Console.Write("Veuillez saisir un nombre A: ");
if(int.TryParse(Console.ReadLine(),out int nbA))
{
    
}
else
{
    errone = -1;
}

Console.WriteLine("1 - Addition (+)");
Console.WriteLine("2 - Soustraction (-)");
Console.WriteLine("3 - Multiplication (*)");
Console.WriteLine("4 - Division (/)");

Console.WriteLine();

Console.Write("Veuillez saisir un opérateur: ");
if (int.TryParse(Console.ReadLine(), out int operateur))
{
    
}
else
{
    errone = -2;
}

Console.Write("Veuillez saisir un nombre B: ");
if (int.TryParse(Console.ReadLine(), out int nbB))
{

}
else
{
    errone = -1;
}

if (errone == -1)
{
    Console.WriteLine("L'un des nombres est invalide");
}
else if (errone == -2)
{
    Console.WriteLine("L'opérateur est invalide");
}
else
{
switch (operateur)
    {
        case 1:
            Console.WriteLine($"La somme de {nbA} et {nbB} est de {nbA + nbB}");
            break;
        case 2:
            Console.WriteLine($"La différence entre {nbA} et {nbB} est de {nbA - nbB}");
            break;
        case 3:
            Console.WriteLine($"Le produit de {nbA} et {nbB} est de {nbA * nbB}");
            break;
        case 4:
            if (nbB == 0)
            {
                Console.WriteLine("Division impossible");
            }
            else
            {
                Console.WriteLine($"Le quotient de {nbA} et {nbB} est de {nbA / nbB}");
            }
            break;
    }
}

    