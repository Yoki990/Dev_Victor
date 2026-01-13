//Struvture itératives

/*Console.WriteLine("Saisir un prénom : ");
string? prenom = Console.ReadLine();

//On utilise une boucle While ou do...while quand on ne connait pas en avance le nombre d'itérations

while (prenom != "Toto")
{
    Console.WriteLine("Erreur. Ce n'est pas le bon prénom.");
    Console.WriteLine("Saisir un prénom : ");
    prenom = Console.ReadLine();
}

int compteur = 0;

while (compteur < 10)
{
    Console.WriteLine(compteur);
    compteur++;
}*/


//Exo10

Console.WriteLine("Veuillez saisir un nombre : ");
string? nombre = Console.ReadLine();
int nb = int.Parse(nombre);

while (nb < 1 || nb > 3)
{
    Console.WriteLine("Erreur.");
    Console.WriteLine("Veuillez saisir un nombre : ");
    nombre =  Console.ReadLine();
    nb = int.Parse(nombre);
}

//Exo11

Console.WriteLine("Veuillez saisir le capital: ");
string? capital = Console.ReadLine();
double cn = double.Parse(capital);
double capi = double.Parse(capital);
double taux = 4/100.0;
int nbAnnee = 0;

while (cn < capi*2)
{
    nbAnnee++;
    cn = capi * Math.Pow((1 + taux), nbAnnee);
    Console.WriteLine(cn + " euros ");
}
Console.WriteLine(nbAnnee);