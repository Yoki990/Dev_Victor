using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14.Classes
{
    internal class Adresse
    {
        public int NumeroRue { get; set; }
        public string NomRue { get; set; }
        public string Ville { get; set; }
        public string CodePostal { get; set; }

        public Adresse(int numeroRue, string nomRue, string ville, string codePostal)
        {
            NumeroRue = numeroRue;
            NomRue = nomRue;
            Ville = ville;
            CodePostal = codePostal;
        }

        public override string ToString()
        {
            return $"L'adresse est: {NumeroRue} {NomRue}, {CodePostal} {Ville}";
        }
    }
}
