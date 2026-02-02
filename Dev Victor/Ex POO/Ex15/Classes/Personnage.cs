using Ex15.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ex15.Classes
{
    internal abstract class Personnage
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int PV { get; set; }
        public int Damage { get; set; }

        public Personnage(string nom, string prenom, int pV, int damage)
        {
            Nom = nom;
            Prenom = prenom;
            PV = pV;
            Damage = damage;
        }

        public abstract void Attaquer(Personnage enemy);

        public override string ToString()
        {
            return $"{Prenom} {Nom} à {PV} PV et il fait {Damage} pts de dégâts";
        }
    }
}
