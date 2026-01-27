using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ex01.Classe
{
    internal class Chaise
    {
        private int _nbPieds;
        private string _materiau;
        private string _couleurObjet;

        public int NbPieds { get => _nbPieds; set => _nbPieds = value; }
        public string Materiau { get => _materiau; set => _materiau = value; }
        public string CouleurObjet { get => _couleurObjet; set => _couleurObjet = value; }

        public Chaise() { }
        public Chaise(int nbPieds, string materiau, string couleurObjet)
        { 

            NbPieds = nbPieds;
            Materiau = materiau;
            CouleurObjet = couleurObjet;

        }

        public override string ToString()
        {
            return $"Je suis une chaise avec {NbPieds} pieds, je suis en {Materiau} et je suis de couleur {CouleurObjet}";
        }
    }
}
