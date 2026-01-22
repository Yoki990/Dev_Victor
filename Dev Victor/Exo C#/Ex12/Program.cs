Console.Write("Veuillez saisir un entier: ");
string nbStr = Console.ReadLine();

string message;

bool nbIsOk = int.TryParse(nbStr, out int nb);

if (!nbIsOk)
{
    message = "Entier invalide";
    Console.WriteLine(message);
}
else
{
    for (int i = 0; i <=10; i++)
    {
        Console.WriteLine($"{nb} x {i} = {nb * i}");
    }
}