using Ex12.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12.Classes
{
    internal class VoitureHybride: Vehicule, IElectrique, IMotorise
    {
        public VoitureHybride(string nom, string marque) : base(nom, marque)
        {
        }

        public void Recharger()
        {
            Console.WriteLine($"{Nom} de marque {Marque} peut se recharger");
        }

        public void Demarrer()
        {
            Console.WriteLine($"{Nom} de marque {Marque} peut démarrer");
        }
    }
}
