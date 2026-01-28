using Ex08.Classes;

CompteBancaire compte = new CompteBancaire("Marco Polo", 235.45f, "euros");
int choix;

Console.WriteLine(compte.Solde);

do
{
    
    Console.WriteLine("Action:");
    Console.WriteLine("1-Déposer de l'argent");
    Console.WriteLine("2-Retirer de l'argent");
    Console.WriteLine("3-Afficher le solde");
    Console.WriteLine("0-Quitter");
    Console.WriteLine();
    Console.Write("Choix: ");
    choix = int.Parse(Console.ReadLine());


    switch (choix)
    {
        case 1:

            Console.Write("Veuillez entrer la somme: ");
            float depot = float.Parse(Console.ReadLine());

            compte.Deposer(compte);

            /*CompteBancaire.Deposee(depot);*/

            Console.WriteLine(depot);

            Console.WriteLine();
            break;

        case 2:

            Console.Write("Veuillez entrer la somme: ");
            float retrait = float.Parse(Console.ReadLine());

            /*CompteBancaire.Retiree(retrait);*/

            Console.WriteLine();
            break;

        case 3:


            compte.AfficherSolde();
            /*Console.WriteLine("Le montant de votre solde est de XXX euros");*/

            Console.WriteLine();
            break;
        case 0:

            Console.Clear();
            Console.WriteLine("Bonne journée!!!");

            break;

        default:

            Console.WriteLine("Mauvaise saisie");

            Console.WriteLine();
            break;

    }
} while (choix != 0);




