using Ex15.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15.Classes
{
    internal class Mage : Personnage, IMAgie
    {
        public Mage(string nom, string prenom, int pV, int damage) : base(nom, prenom, pV, damage)
        {
        }

        public override void Attaquer(Personnage enemy)
        {
            /*enemy.PV -= magie;*/
            Console.WriteLine($"{Nom} a attaqué {enemy.Nom}.");
            Console.WriteLine($"Il reste {enemy.PV} pv à {enemy.Nom}");
        }

        public void LancerSort(Personnage enemy)
        {
            /*enemy.PV -= magie;*/
            Console.WriteLine($"{Nom} a attaqué {enemy.Nom}.");
            Console.WriteLine($"Il reste {enemy.PV} pv à {enemy.Nom}");
        }
    }
}
