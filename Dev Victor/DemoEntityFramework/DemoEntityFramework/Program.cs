using Microsoft.EntityFrameworkCore;
using Ex03.Class.DbManager;
using Ex03.Class.Model;
using System.Security.Cryptography;
using System.ComponentModel.Design;

using (AppDbContext db = new AppDbContext())
{
    db.Database.Migrate();

    void AfficherRecettes(AppDbContext db)
    {
        Console.Clear();

        List<Recette> allRecettes = db.Recettes.ToList();
        foreach (Recette recettes in allRecettes)
        {
            Console.WriteLine(recettes);
        }
    }
    Recette AjouterUneRecette()
    {
        Console.Clear();

        Console.Write("Veuillez mettre le nom de la recette: ");
        string nomRecette = Console.ReadLine() ?? "";
        Console.Write("Veuillez mettre la description de la recette: ");
        string descRecette = Console.ReadLine() ?? "";
        Console.Write("Veuillez mettre les instructions de la recette: ");
        string instrucRecette = Console.ReadLine() ?? "";

        return new Recette(nomRecette, descRecette, instrucRecette);
    }
    void ModificationRecette(AppDbContext db)
    {
        AfficherRecettes(db);

        Recette? recette = GetRecetteById();

        if (recette != null)
        {
            Console.WriteLine("Id introuvable !");
            return;
        }
        Recette recette1 = AjouterUneRecette();

        recette.Nom = recette1.Nom;
        recette.Description = recette1.Description;
        recette.Instructions = recette1.Instructions;

        db.Recettes.Update(recette);
        db.SaveChanges();


        //Console.Write($"(Veuillez saisir le nouveau nom ({Nom}): ");
    }
    Recette? GetRecetteById()
    {
        Console.Write("Saisir l'ID de la recette: ");
        int.TryParse(Console.ReadLine(), out int id);
        return db.Recettes.Find(id);
    }

    void AfficherIngredients(AppDbContext db)
    {
        Console.Clear();

        List<Ingredient> allIngredients = db.Ingredients.ToList();
        foreach (Ingredient ingredient in allIngredients)
        {
            Console.WriteLine(ingredient);
        }
    }
    Ingredient AjouterIngredient()
    {
        Console.Clear();

        Console.Write("Veuillez mettre le nom de l'ingrédient: ");
        string nomIngredient = Console.ReadLine() ?? "";
        Console.Write("Veuillez mettre la description de l'ingrédient: ");
        string descIngredient = Console.ReadLine() ?? "";

        return new Ingredient(nomIngredient, descIngredient);
    }
    void ModificationIngredient(AppDbContext db)
    {
        AfficherIngredients(db);

        Ingredient? ingredient = GetIngredientById();

        if (ingredient != null)
        {
            Console.WriteLine("Id introuvable !");
            return;
        }
        Ingredient ingredient1 = AjouterIngredient();

        ingredient.Nom = ingredient1.Nom;
        ingredient.Description = ingredient1.Description;

        db.Ingredients.Update(ingredient);
        db.SaveChanges();
    }
    Ingredient? GetIngredientById()
    {
        Console.Write("Saisir l'ID de l'ingrédient: ");
        int.TryParse(Console.ReadLine(), out int id);
        return db.Ingredients.Find(id);
    }

    void AjouterIngredientAUneRecette()
    {
        //GetAllTableRecette

        AfficherRecettes(db);

        //get recette by Id
        Console.Write("Saisir l'ID de la recette: ");
        int.TryParse(Console.ReadLine(), out int id1);
        Recette? recette = db.Recettes.Find(id1);

        //get all ingredient

        AfficherIngredients(db);

        //get ingredient by id
        Console.Write("Saisir l'ID de l'ingrédient à mettre avec la recette: ");
        int.TryParse(Console.ReadLine(), out int id2);
        Ingredient? ingredient = db.Ingredients.Find(id2);

        //demander qté string

        Console.Write("Saisir la quantité de l'ingrédient: ");
        string qte = Console.ReadLine() ?? "";

        //ajout new recette ingredient(idrecette, idingredient, qté)

        db.RecetteIngredients.Add(new RecetteIngredient(id1, id2, qte));
    }

    void AfficherRecetteDetailIngredient()
    {
        Console.Write("Saisir l'ID de la recette: ");
        int.TryParse(Console.ReadLine(), out int id1);
        Recette? recette = db.Recettes.Find(id1);

        List<RecetteIngredient> recetteIngredients = db.RecetteIngredients
            .Include(x => x.IdRecette)
            .ToList();

        foreach (var r in recetteIngredients)
        {
            Console.WriteLine($"Recette: {r.IdRecette} - Ingrédient: {r.IdIngredient} - Quantité : {r.Quantite}");
        }
    }

    void Titre()
    {
        string title = """

             ____               _   _       
            |  _ \ ___  ___ ___| |_| |_ ___ 
            | |_) / _ \/ __/ _ \ __| __/ _ \
            |  _ <  __/ (_|  __/ |_| ||  __/
            |_| \_\___|\___\___|\__|\__\___|

            """;
        Console.WriteLine(title);
    }

    void Menu()
    {

        Titre();
        string menu = """

            1. Recettes
            2. Ingrédients
            3. Ajouter un ingrédient à une recette
            4. Afficher le détail d'une recette
            5. Afficher l'ingrédient le plus utilisé
            6. Afficher la recette avec le plus d'ingrédients
            0. Quitter

            """;
        Console.WriteLine(menu);
    }

    void MenuRecettes()
    {
        Titre();
        string menuRecettes = """

            1. Afficher les recettes
            2. Ajouter une recette
            3. Modifier une recette
            4. Supprimer une recette
            0. Revenir en arrière

            """;
        Console.WriteLine($" {menuRecettes}");
    }

    string choix;
    string choixRecettes;
    string choixIngredients;
    do
    {
        Menu();
        Console.Write("Veuillez entrer le choix: ");
        choix = Console.ReadLine() ?? "";

        switch (choix)
        {
            case "0":
                Environment.Exit(0);
                break;
            case "1":
                Console.WriteLine("-------------- RECETTES -------------");
                do
                {
                    MenuRecettes();
                    Console.Write("Veuillez entrer le choix: ");
                    choixRecettes = Console.ReadLine() ?? "";

                    switch (choixRecettes)
                    {
                        case "0":
                            Environment.Exit(0);
                            break;
                        case "1":
                            AfficherRecettes(db);
                            break;
                        case "2":
                            AjouterUneRecette();
                            break;
                        case "3":
                            Console.WriteLine("-------- MODIFICATION RECETTE -------");
                            ModificationRecette(db);
                            break;
                        default:
                            Console.WriteLine("Mauvaise saisie !!!");
                            break;
                    }
                    Console.Write("\n------ Press Enter to continue ------");
                    Console.ReadLine();
                    Console.Clear();

                } while (choixRecettes != "0");
                break;
            case "2":
                Console.WriteLine("------------ INGRÉDIENTS ------------");
                do
                {
                    MenuRecettes();
                    Console.Write("Veuillez entrer le choix: ");
                    choixIngredients = Console.ReadLine() ?? "";

                    switch (choixIngredients)
                    {
                        case "0":
                            Environment.Exit(0);
                            break;
                        case "1":
                            AfficherIngredients(db);
                            break;
                        case "2":
                            AjouterUneRecette();
                            break;
                        case "3":
                            Console.WriteLine("------ MODIFICATION INGRÉDIENT ------");
                            ModificationIngredient(db);
                            break;
                        default:
                            Console.WriteLine("Mauvaise saisie !!!");
                            break;
                    }
                    Console.Write("\n------ Press Enter to continue ------");
                    Console.ReadLine();
                    Console.Clear();

                } while (choixIngredients != "0");
                break;
            case "3":
                Console.WriteLine("---- AJOUT INGREDIENT -> RECETTE ----");
                AjouterIngredientAUneRecette();
                break;
            case "4":
                Console.WriteLine("----------- DÉTAIL RECETTE ----------");
                break;
            case "5":
                Console.WriteLine("--- AFFICHER INGRÉDIENTS + UTILISÉ --");
                Environment.Exit(0);
                break;
            case "6":
                Console.WriteLine("- AFFICHER RECETTE => + INGRÉDIENTS -");
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Mauvaise saisie !!!");
                break;
        }
        Console.Write("\n------ Press Enter to continue ------");
        Console.ReadLine();
        Console.Clear();

    } while (choix != "0");

}
