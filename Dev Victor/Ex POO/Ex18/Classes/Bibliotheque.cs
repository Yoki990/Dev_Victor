using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex18.Classes
{
    internal class Bibliotheque
    {
        private List <Livre> book = new List <Livre> ();

        public void AjoutLivre()
        {
            Random random = new Random ();

            book.Add(new Livre(1, "Chaperon rouge", "Charles Perrault", random.Next(10,51)));
            book.Add(new Livre(2, "Toto", "Titi", random.Next(10, 51)));
            book.Add(new Livre(3, "L'Ecume des jours", "Boris Vian", random.Next(10, 51)));
        }

        public void EnleverLivre()
        {
            book.RemoveAt(1);
        }

        public void AfficherTousLivres()
        {
            foreach (Livre livre in book)
            {
               Console.WriteLine(livre);
            }
        }

        public void RechercheLivreTitre()
        {
            if (book.Contains("Chaperon rouge"))
            {

            }
        }
    }

    
}
