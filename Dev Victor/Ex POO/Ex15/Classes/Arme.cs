using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15.Classes
{
    internal class Arme
    {
        public string NomArme { get; set; }
        public int DegatSupplementaire { get; set; }
        public int Durabilite { get; set; }

        public Arme(string nomArme, int degatSupplementaire, int durabilite)
        {
            NomArme = nomArme;
            DegatSupplementaire = degatSupplementaire;
            Durabilite = durabilite;
        }

        public void Utiliser()
        {
            if (Durabilite > 0)
            {
                Durabilite -= 1;
            }

        }
    }
}
