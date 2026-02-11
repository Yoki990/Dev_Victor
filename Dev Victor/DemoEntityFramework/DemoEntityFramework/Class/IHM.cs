using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.Class
{
    internal class IHM
    {
        public void AfficherTitre()
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
        public void Menu()
        {
            AfficherTitre();
            string menu = """

                1. Afficher les recettes
                2. Afficher les ingrédients
                3. Ajouter une recette
                4. Ajouter un ingrédient
                5. Afficher le détail d'une recette
                6. Supprimer une recette
                7. Afficher l'ingrédient le plus utilisé
                8. Afficher la recette avec le plus d'ingrédients
                0. Quitter

                """;
            Console.WriteLine(menu);
        }
        public void Start()
        {
            int choix;
            Menu();
            Console.Write("\nChoix: ");
            choix = int.Parse(Console.ReadLine());

            switch (choix)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;



            }
        }


    }
}
