//Donner tout les nombres pair entre 10 et 30 (inclus)

for (int nombre=10; nombre <=30; nombre++)
{
    if (nombre%2 == 0)
    {
        Console.WriteLine(nombre);
    }
}

//Demander à l'utilisateur son nom et son age
//Tant que le nom ne correspond pas à "votreNom" et que l'age n'est pas supérieur à 18, continuer de demander les informations
//à l'utilisateur
//Afficher les messages d'erreur correspondant

string votreNom = "Victor";
string nom;
int age;

Console.Write("Veuillez mettre votre nom : ");
nom = Console.ReadLine();
Console.Write("Veuillez entrer votre âge : ");
age = int.Parse(Console.ReadLine());


while (nom != votreNom || age <= 18)
{
    Console.WriteLine("Le nom et l'âge sont inexactes. Veuillez réessayer: ");
    Console.Write("Veuillez mettre votre nom : ");
    nom = Console.ReadLine();
    Console.Write("Veuillez entrer votre âge : ");
    age = int.Parse(Console.ReadLine());
}
Console.WriteLine("C'est bon!");


/*if (nom == votreNom && age <= 18)
{
    Console.WriteLine("L'âge est inexacte. Veuillez réessayer : ");
    Console.Write("Veuillez mettre votre nom : ");
    nom = Console.ReadLine();
    Console.Write("Veuillez entrer votre âge : ");
    age = int.Parse(Console.ReadLine());
}
else if (nom != votreNom && age > 18)
{
    Console.WriteLine("Le nom est inexact. Veuillez réessayer : ");
    Console.Write("Veuillez mettre votre nom : ");
    nom = Console.ReadLine();
    Console.Write("Veuillez entrer votre âge : ");
    age = int.Parse(Console.ReadLine());
}
else
{
    Console.WriteLine("Le nom et l'âge sont inexactes. Veuillez réessayer: ");
    Console.Write("Veuillez mettre votre nom : ");
    nom = Console.ReadLine();
    Console.Write("Veuillez entrer votre âge : ");
    age = int.Parse(Console.ReadLine());
}*/


/*{
if (nom != votreNom && age <= 18)
{
    Console.WriteLine("Le nom et l'âge sont inexactes. Veuillez réessayer: ");
    Console.Write("Veuillez mettre votre nom : ");
    nom = Console.ReadLine();
    Console.Write("Veuillez entrer votre âge : ");
    age = int.Parse(Console.ReadLine());
}
else if (nom == votreNom && age <= 18)
{
    Console.WriteLine("Le nom et l'âge sont inexactes. Veuillez réessayer: ");
    Console.Write("Veuillez mettre votre nom : ");
    nom = Console.ReadLine();
    Console.Write("Veuillez entrer votre âge : ");
    age = int.Parse(Console.ReadLine());
}
else if (nom == votreNom && age <= 18)
{
    Console.WriteLine("Le nom est inexact. Veuillez réessayer: ");
    Console.Write("Veuillez mettre votre nom : ");
    nom = Console.ReadLine();
    Console.Write("Veuillez entrer votre âge : ");
    age = int.Parse(Console.ReadLine());
}
Console.WriteLine("C'est bon!");
}*/


/*while (nom != votreNom && age <= 18)
{
    Console.WriteLine("Le nom et l'âge sont inexactes. Veuillez réessayer: ");
    Console.Write("Veuillez mettre votre nom : ");
    nom = Console.ReadLine();
    Console.Write("Veuillez entrer votre âge : ");
    age = int.Parse(Console.ReadLine());
}

while(nom == votreNom && age <= 18)
{
    Console.WriteLine("Votre âge est inexacte. Veuillez réessayer: ");
    Console.Write("Veuillez mettre votre nom : ");
    nom = Console.ReadLine();
    Console.Write("Veuillez entrer votre âge : ");
    age = int.Parse(Console.ReadLine());
}

while (nom != votreNom && age > 18)
{
    Console.WriteLine("Le nom est inexact. Veuillez réessayer: ");
    Console.Write("Veuillez mettre votre nom : ");
    nom = Console.ReadLine();
    Console.Write("Veuillez entrer votre âge : ");
    age = int.Parse(Console.ReadLine());
}

    Console.WriteLine("C'est bon!");*/






//