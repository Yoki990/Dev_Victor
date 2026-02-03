using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex18.Classes
{
    internal class Livre
    {
        public int Numero {  get; set; }
        public string Titre {  get; set; }
        public string Auteur {  get; set; }
        public int NbExemplaires {  get; set; }

        public Livre(int numero, string titre, string auteur, int nbExemplaires)
        {
            Numero = numero;
            Titre = titre;
            Auteur = auteur;
            NbExemplaires = nbExemplaires;
        }
    }
}
