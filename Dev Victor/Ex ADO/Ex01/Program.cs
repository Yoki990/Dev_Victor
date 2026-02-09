using Ex01.Classes.Model;
using Ex01.Classes.Repository;
using MySql.Data.MySqlClient;

EtudiantRepository eRepo = new EtudiantRepository();
eRepo.CreateTableEtudiant();
int choix;
char choix2;

Console.WriteLine("       _             _ _             _       \r");
Console.WriteLine("   ___| |_ _   _  __| (_) __ _ _ __ | |_ ___ \r");
Console.WriteLine("  / _ \\ __| | | |/ _` | |/ _` | '_ \\| __/ __|\r");
Console.WriteLine(" |  __/ |_| |_| | (_| | | (_| | | | | |_\\__ \\\r");
Console.WriteLine("  \\___|\\__|\\__,_|\\__,_|_|\\__,_|_| |_|\\__|___/\r\n");

do
{
    Console.WriteLine("1. Voir tous les étudiants");
    Console.WriteLine("2. Ajouter un étudiant");
    Console.WriteLine("3. Modifier un étudiant");
    Console.WriteLine("4. Rechercher un étudiant");
    Console.WriteLine("5. Supprimer un étudiant");
    Console.WriteLine("6. Supprimer le tableau");
    Console.WriteLine("0. Quitter\n");

    Console.Write("Veuillez entrer le choix: ");
    choix = int.Parse(Console.ReadLine());

    switch (choix)
    {
        case 1:
            Console.Clear();

            Console.WriteLine("       _             _ _             _       \r");
            Console.WriteLine("   ___| |_ _   _  __| (_) __ _ _ __ | |_ ___ \r");
            Console.WriteLine("  / _ \\ __| | | |/ _` | |/ _` | '_ \\| __/ __|\r");
            Console.WriteLine(" |  __/ |_| |_| | (_| | | (_| | | | | |_\\__ \\\r");
            Console.WriteLine("  \\___|\\__|\\__,_|\\__,_|_|\\__,_|_| |_|\\__|___/\r\n");

            List<Etudiant> etudiants = eRepo.AfficherTousLesEtudiants();
            foreach (Etudiant etudiant in etudiants)
            {
                Console.WriteLine(etudiant);
            }

            Console.WriteLine("");
            break;
        case 2:
            Console.Clear();

            Console.WriteLine("       _             _ _             _       \r");
            Console.WriteLine("   ___| |_ _   _  __| (_) __ _ _ __ | |_ ___ \r");
            Console.WriteLine("  / _ \\ __| | | |/ _` | |/ _` | '_ \\| __/ __|\r");
            Console.WriteLine(" |  __/ |_| |_| | (_| | | (_| | | | | |_\\__ \\\r");
            Console.WriteLine("  \\___|\\__|\\__,_|\\__,_|_|\\__,_|_| |_|\\__|___/\r\n");


            Console.Write("Veuillez entrer le nom de famille: ");
            string nom = Console.ReadLine();

            Console.Write("Veuillez entrer le prénom: ");
            string prenom = Console.ReadLine();

            /*  do
              {
                  Console.Write("Veuillez entrer la date de naissance: ");
                  DateTime dateStr = DateTime.Parse(Console.ReadLine());

                  if (DateTime.TryParse(Console.ReadLine(), out DateTime date))
                  {
                      break;
                  }
                  else
                  {
                      Console.WriteLine("Mauvaise saisie !!!");
                  }
              } while (true);*/

            Console.Write("Veuillez entrer la date de naissance (yyyy-MM-dd): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Console.Write("Veuillez entrer l'e-mail: ");

            string email = Console.ReadLine();


            eRepo.AjouterUnEtudiant(new Etudiant(null, nom, prenom, date, email));

            Console.WriteLine("");
            break;
        case 3:
            Console.Clear();

            Console.WriteLine("       _             _ _             _       \r");
            Console.WriteLine("   ___| |_ _   _  __| (_) __ _ _ __ | |_ ___ \r");
            Console.WriteLine("  / _ \\ __| | | |/ _` | |/ _` | '_ \\| __/ __|\r");
            Console.WriteLine(" |  __/ |_| |_| | (_| | | (_| | | | | |_\\__ \\\r");
            Console.WriteLine("  \\___|\\__|\\__,_|\\__,_|_|\\__,_|_| |_|\\__|___/\r\n");


            Console.Write("Veuillez entrer l'id de l'étudiant à modifier: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Veuillez entrer le nom de famille: ");
            string nomModif = Console.ReadLine();

            Console.Write("Veuillez entrer le prénom: ");
            string prenomModif = Console.ReadLine();

            /*  do
              {
                  Console.Write("Veuillez entrer la date de naissance: ");
                  DateTime dateStr = DateTime.Parse(Console.ReadLine());

                  if (DateTime.TryParse(Console.ReadLine(), out DateTime date))
                  {
                      break;
                  }
                  else
                  {
                      Console.WriteLine("Mauvaise saisie !!!");
                  }
              } while (true);*/

            Console.Write("Veuillez entrer la date de naissance (yyyy-MM-dd): ");
            DateTime dateModif = DateTime.Parse(Console.ReadLine());

            Console.Write("Veuillez entrer l'e-mail: ");

            string emailModif = Console.ReadLine();

            eRepo.EditerUnEtudiant(new Etudiant(id, nomModif, prenomModif, dateModif, emailModif));

            Console.WriteLine("");
            break;
        case 4:
            Console.Clear();

            Console.WriteLine("       _             _ _             _       \r");
            Console.WriteLine("   ___| |_ _   _  __| (_) __ _ _ __ | |_ ___ \r");
            Console.WriteLine("  / _ \\ __| | | |/ _` | |/ _` | '_ \\| __/ __|\r");
            Console.WriteLine(" |  __/ |_| |_| | (_| | | (_| | | | | |_\\__ \\\r");
            Console.WriteLine("  \\___|\\__|\\__,_|\\__,_|_|\\__,_|_| |_|\\__|___/\r\n");

            do
            {
                Console.WriteLine("A. Par son nom");
                Console.WriteLine("B. Par son prénom");
                Console.WriteLine("Q. Quitter\n");

                Console.Write("Veuillez entrer le choix: ");
                choix2 = char.Parse(Console.ReadLine().ToUpper());

                switch (choix2)
                {
                    case 'A':
                        Console.Write("Veuillez entrer le nom à rechercher: ");
                        string nomStr = Console.ReadLine();
                        Console.WriteLine(eRepo.AfficherUnePersonneParSonNom(nomStr) + "\n");
                        
                        break;
                    case 'B':
                        Console.Write("Veuillez entrer le prénom à rechercher: ");
                        string prenomStr = Console.ReadLine();
                        Console.WriteLine(eRepo.AfficherUnePersonneParSonPrenom(prenomStr) + "\n");
                        break;
                    case 'Q':
                        break;
                    default:

                        Console.Clear();

                        Console.WriteLine("       _             _ _             _       \r");
                        Console.WriteLine("   ___| |_ _   _  __| (_) __ _ _ __ | |_ ___ \r");
                        Console.WriteLine("  / _ \\ __| | | |/ _` | |/ _` | '_ \\| __/ __|\r");
                        Console.WriteLine(" |  __/ |_| |_| | (_| | | (_| | | | | |_\\__ \\\r");
                        Console.WriteLine("  \\___|\\__|\\__,_|\\__,_|_|\\__,_|_| |_|\\__|___/\r\n");

                        Console.WriteLine("Mauvaise saisie !!!\n");
                        break;

                }

            } while (choix2!='Q');

            break;
        case 5:

            Console.WriteLine("Veuillez entrer l'id de l'étudiant que vous souhaitez supprimer:");
            int suppEtudiant = int.Parse(Console.ReadLine());

            eRepo.SupprimerUnEtudiant(suppEtudiant);

            Console.WriteLine("");
            break;
        case 6:
            Console.Clear();

            Console.WriteLine("       _             _ _             _       \r");
            Console.WriteLine("   ___| |_ _   _  __| (_) __ _ _ __ | |_ ___ \r");
            Console.WriteLine("  / _ \\ __| | | |/ _` | |/ _` | '_ \\| __/ __|\r");
            Console.WriteLine(" |  __/ |_| |_| | (_| | | (_| | | | | |_\\__ \\\r");
            Console.WriteLine("  \\___|\\__|\\__,_|\\__,_|_|\\__,_|_| |_|\\__|___/\r\n");

            eRepo.SupprimerLeTableau();

            break;
        case 0:
            Console.Clear();

            Console.WriteLine("       _             _ _             _       \r");
            Console.WriteLine("   ___| |_ _   _  __| (_) __ _ _ __ | |_ ___ \r");
            Console.WriteLine("  / _ \\ __| | | |/ _` | |/ _` | '_ \\| __/ __|\r");
            Console.WriteLine(" |  __/ |_| |_| | (_| | | (_| | | | | |_\\__ \\\r");
            Console.WriteLine("  \\___|\\__|\\__,_|\\__,_|_|\\__,_|_| |_|\\__|___/\r\n");

            Console.WriteLine("Au revoir!");


            break;
        default:
            Console.Clear();

            Console.WriteLine("       _             _ _             _       \r");
            Console.WriteLine("   ___| |_ _   _  __| (_) __ _ _ __ | |_ ___ \r");
            Console.WriteLine("  / _ \\ __| | | |/ _` | |/ _` | '_ \\| __/ __|\r");
            Console.WriteLine(" |  __/ |_| |_| | (_| | | (_| | | | | |_\\__ \\\r");
            Console.WriteLine("  \\___|\\__|\\__,_|\\__,_|_|\\__,_|_| |_|\\__|___/\r\n");

            Console.WriteLine("Mauvaise saisie !!!\n");
            break;
    }


} while (choix != 0);
