//Cas 1
using System.Security.Cryptography;

int choix;
HashSet<string> pseudoVerif = new HashSet<string>();
pseudoVerif.Add("Yoki");
pseudoVerif.Add("Tartentruffe");
pseudoVerif.Add("bergerall3mand");
pseudoVerif.Add("Yoki");
pseudoVerif.Add("Yoki");
pseudoVerif.Add("freyaWar");

foreach (string pseu in pseudoVerif)
{
    Console.WriteLine(pseu);
}

List<string> pseudoValides = pseudoVerif.ToList();

pseudoValides.Sort();
do
{
    Console.WriteLine("----MENU----");
    Console.WriteLine("1- Afficher la liste des participants");
    Console.WriteLine("2- Rechercher un participant à partir de son pseudo");
    Console.WriteLine("0- Quitter");
    Console.WriteLine();
    Console.WriteLine("Veuillez faire un choix: ");
    choix = int.Parse(Console.ReadLine());

    switch (choix)
    {
        case 1:
            Console.Clear();

            foreach (string pseu in pseudoValides)
            {
                Console.WriteLine(pseu);
            }
            break;
        case 2:
            Console.Clear();

            Console.WriteLine("Veuillez mettre le pseudo à rechercher: ");
            string searchPseudo = Console.ReadLine();


            if (pseudoValides.Contains(searchPseudo))
            {
                Console.WriteLine("Le pseudo recherché est dans la liste");
            }
            else
            {
                Console.WriteLine("Le pseudo recherché n'est pas dans la liste");
            }

            break;
        case 0:
            Console.Clear();

            Console.WriteLine("À bientot!!!");
            break;
        default:
            Console.WriteLine("Mauvaise saisie. Veuillez la remettre");
            break;
    }
} while (choix != 0);

Console.WriteLine($"\n\n");

//Cas 2

Queue<string> patient = new Queue<string>();
patient.Enqueue("Titi");
patient.Enqueue("Marco");
patient.Enqueue("Jean-Frnaçoise");
patient.Enqueue("Patrick");
patient.Enqueue("Noa");
patient.Enqueue("Nathalie");

while (patient.Count > 0)
{
    Console.WriteLine($"Le premier de la file est {patient.Dequeue()}. Il reste {patient.Count} personnes dans la file d'attente.\n");
}

Console.WriteLine($"C'est l'heure de la pause");

