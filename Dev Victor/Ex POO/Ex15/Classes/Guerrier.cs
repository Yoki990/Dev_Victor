using Ex15.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ex15.Classes
{
    internal class Guerrier : Personnage, IAttaqueSpeciale
    {
        public Guerrier(string nom, string prenom, int pV, int damage) : base(nom, prenom, pV, damage)
        {
        }

        public override void Attaquer(Personnage enemy)
        {
            /*enemy.PV -= DegatSupplementaire;*/
            Console.WriteLine($"{Nom} a attaqué {enemy.Nom}.");
            Console.WriteLine($"Il reste {enemy.PV} pv à {enemy.Nom}");
        }

        public void AttaqueSpeciale(Personnage enemy)
        {
            /*enemy.PV -= DegatSupplementaire;*/
            Console.WriteLine($"{Nom} a attaqué {enemy.Nom}.");
            Console.WriteLine($"Il reste {enemy.PV} pv à {enemy.Nom}");
        }
    }
}
