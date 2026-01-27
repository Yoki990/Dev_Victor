Console.Write("Merci de saisir le nombre de contact: ");
int nbContact = int.Parse(Console.ReadLine());
int compteur = 1;
string[] Contact = new string[nbContact];
int choix;

Console.Clear();

do
{
    Console.WriteLine("-----Ma liste de contacts-----");
    Console.WriteLine("1=> Saisir des contacts");
    Console.WriteLine("2=> Afficher mes contacts");
    Console.WriteLine("0=> Quitter");
    Console.WriteLine();
    Console.Write("Faites votre choix: ");
    choix = int.Parse(Console.ReadLine());

    switch (choix)
    {
        case 1:
            compteur = 1;

            Console.Clear();

            do
            {
                Console.Write($"Nom et prénom du contact n°{compteur}: ");
                string nomContact = Console.ReadLine() ?? "";
                Contact[compteur - 1] = nomContact;
                compteur++;
                       
            } while (compteur - 1 != nbContact);

            Console.WriteLine();

            break;

        case 2:

            Console.Clear();

            for (int i = 0; i < nbContact; i++)
            {
                Console.WriteLine($"    - Contact N°{i + 1} : {Contact[i]}");

            }
            Console.WriteLine();

            break;

        case 0:
            Console.Clear();

            Console.WriteLine("Bonne journée :)");
            Environment.Exit(0);
            break;

        default:

            Console.WriteLine("Mauvaise saisie.");
            break;
    }
} while (choix != 0);