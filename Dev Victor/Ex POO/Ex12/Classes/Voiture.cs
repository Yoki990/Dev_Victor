using Ex12.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12.Classes
{
    internal class Voiture : Vehicule, IMotorise
    {
        public Voiture(string nom, string marque) : base(nom, marque)
        {
        }

        public void Demarrer()
        {
            Console.WriteLine($"{Nom} de marque {Marque} peut démarrer");
        }
    }
}
