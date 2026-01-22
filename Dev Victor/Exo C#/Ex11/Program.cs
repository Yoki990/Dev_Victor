using System.Net.NetworkInformation;

string n = "7";
string nb;

do
{
    Console.Write("Veuillez entrer un nombre: ");
    nb = Console.ReadLine();

    if (nb != n)
    {
        Console.WriteLine("Refaire la saisie");
    }
}
while (nb != n);

Console.WriteLine("Bravo, nombre trouvé!");