using System.Net.NetworkInformation;

Console.Write("Veuillez saisir un entier positif: ");
string saisieNb=Console.ReadLine();
int nb;

while (!int.TryParse(saisieNb, out nb) || nb <=0)
{
    Console.WriteLine("Saisie Invalide ! Veuillez saisir un entier positif: ");
    saisieNb = Console.ReadLine();
}

Console.WriteLine();
int i = 1;
while (i <= nb)
{
    Console.WriteLine(i);
    i++;
}