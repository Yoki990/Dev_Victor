using Ex02.Classes.Model;
using Ex02.Classes.Repository;
using MySql.Data.MySqlClient;

ClientCommandesRepository clRepo = new ClientCommandesRepository();
ClientCommandesRepository coRepo = new ClientCommandesRepository();
ClientCommandesRepository produitRepo = new ClientCommandesRepository();
clRepo.CreateTableClient();
coRepo.CreateTableCommandes();
produitRepo.CreateTableProduits();

int choix;

void AfficherMenu()
{
    Console.Clear();

    Console.WriteLine("""
           ____                                          _           
          / ___|___  _ __ ___  _ __ ___   __ _ _ __   __| | ___  ___ 
         | |   / _ \| '_ ` _ \| '_ ` _ \ / _` | '_ \ / _` |/ _ \/ __|
         | |__| (_) | | | | | | | | | | | (_| | | | | (_| |  __/\__ \
          \____\___/|_| |_| |_|_| |_| |_|\__,_|_| |_|\__,_|\___||___/

        1. Afficher les clients
        2. Créer un client
        3. Modifier un client
        4. Supprimer un client
        5. Afficher les détails d'un client
        6. Afficher les produits
        7. Ajouter un produit
        8. Modifier un produit
        9. Supprimer un produit
        0. Quitter

        """);
}
void AfficherTitre()
{
    Console.Clear();

    Console.WriteLine("""
          ____                                          _           
         / ___|___  _ __ ___  _ __ ___   __ _ _ __   __| | ___  ___ 
        | |   / _ \| '_ ` _ \| '_ ` _ \ / _` | '_ \ / _` |/ _ \/ __|
        | |__| (_) | | | | | | | | | | | (_| | | | | (_| |  __/\__ \
         \____\___/|_| |_| |_|_| |_| |_|\__,_|_| |_|\__,_|\___||___/

       """);
}
void AfficherClients()
{
    Console.WriteLine("-------- LISTE CLIENTS -------\n");

    List<Client> clients = clRepo.AfficherTousLesClients();
    foreach (Client client in clients)
    {
        Console.WriteLine(client);
    }
}
void CreerUnClient()
{
    Console.WriteLine("-------- AJOUT CLIENT --------\n");

    Console.Write("Veuillez entrer le nom: ");
    string nom = Console.ReadLine().Trim();

    Console.Write("Veuillez entrer le prénom: ");
    string prenom = Console.ReadLine().Trim();

    Console.Write("Veuillez entrer l'adresse: ");
    string adresse = Console.ReadLine().Trim();

    Console.Write("Veuillez entrer le code postal: ");
    string codePostal = Console.ReadLine().Trim();

    Console.Write("Veuillez entrer la ville: ");
    string ville = Console.ReadLine().Trim();

    Console.Write("Veuillez entrer le numéro de téléphone: ");
    string telephone = Console.ReadLine().Trim();

    clRepo.AjouterUnClient(new Client(null, nom, prenom, adresse, codePostal, ville, telephone));
    Console.WriteLine("Client ajouté !");
}
void EditerClient()
{
    Console.WriteLine("----- MODIFICATION CLIENT ------\n");

    Console.Write("Veuillez entrer l'id du client à modifier: ");
    int id = int.Parse(Console.ReadLine().Trim());

    Console.Write("Veuillez entrer le nom: ");
    string nom = Console.ReadLine().Trim();

    Console.Write("Veuillez entrer le prénom: ");
    string prenom = Console.ReadLine().Trim();

    Console.Write("Veuillez entrer l'adresse: ");
    string adresse = Console.ReadLine().Trim();

    Console.Write("Veuillez entrer le code postal: ");
    string codePostal = Console.ReadLine().Trim();

    Console.Write("Veuillez entrer la ville: ");
    string ville = Console.ReadLine().Trim();

    Console.Write("Veuillez entrer le numéro de téléphone: ");
    string telephone = Console.ReadLine().Trim();

    clRepo.EditerUnClient(new Client(id, nom, prenom, adresse, codePostal, ville, telephone));
    Console.WriteLine($"Client n°{id} modifié !");
}
void SupprimerClient()
{
    Console.WriteLine("------- SUPPRIMER CLIENT -------\n");

    Console.Write("Veuillez entrer l'id du client que vous souhaitez supprimer: ");
    int suppClient = int.Parse(Console.ReadLine());

    clRepo.SupprimerUnClientEtSesCommandes(suppClient);
    Console.WriteLine($"Client n°{suppClient} supprimé !");

}
void AfficherProduits()
{
    Console.WriteLine("------- LISTE PRODUITS -------\n");
    List<Commandes> produits = produit.AfficherTousLesProduits();
    foreach (Commandes p in produits)
    {
        Console.WriteLine(p);
    }
}
void AjouterUnProduit()
{
    Console.WriteLine("-------- AJOUT PRODUIT -------\n");

    Console.Write("Veuillez entrer le nom: ");
    string nom = Console.ReadLine().Trim();

    produitRepo.AjouterUnProduit(new Commandes(null, nom));
    Console.WriteLine("Produit ajouté !");
}
void EditerProduit()
{
    Console.WriteLine("----- MODIFICATION PRODUIT -----\n");

    Console.Write("Veuillez entrer l'id du produit à modifier: ");
    int id = int.Parse(Console.ReadLine().Trim());

    Console.Write("Veuillez entrer le nouveau nom: ");
    string nom = Console.ReadLine().Trim();

    produit.EditerUnProduit(new Commandes(id, nom));
    Console.WriteLine($"Produit n°{id} modifié !");
}
void SupprimerProduit()
{
    Console.WriteLine("------- SUPPRIMER CLIENT -------\n");

    Console.Write("Veuillez entrer l'id du client que vous souhaitez supprimer: ");
    int suppProduit = int.Parse(Console.ReadLine());

    produit.SupprimerUnProduit(suppProduit);
    Console.WriteLine($"Produit n°{suppProduit} supprimé !");

}

do
{
    AfficherMenu();
    Console.Write("Veuillez entrer le choix: ");

    while (!int.TryParse(Console.ReadLine(), out choix))
    {
        Console.WriteLine("\nVeuillez saisir un nombre..");
        Console.Write("Votre choix : ");
    }
    Console.WriteLine();

    switch (choix)
    {
        case 1:
            AfficherTitre();
            AfficherClients();
            break;
        case 2:
            AfficherTitre();
            CreerUnClient();
            break;
        case 3:
            AfficherTitre();
            EditerClient();
            break;
        case 4:
            AfficherTitre();
            SupprimerClient();
            break;
        case 5:
            AfficherTitre();
            break;
        case 6:
            AfficherTitre();
            AfficherProduits();
            break;
        case 7:
            AfficherTitre();
            AjouterUnProduit();
            break;
        case 8:
            AfficherTitre();
            EditerProduit();
            break;
        case 9:
            AfficherTitre();
            SupprimerProduit();
            break;
        case 0:
            AfficherTitre();

            Console.WriteLine("Au revoir!");
            break;
        default:
            break;
    }
    Console.Write("\n--- Press Enter to continue ---");
    Console.ReadLine();

} while (choix != 0);