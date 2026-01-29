using Ex12.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12.Classes
{
    internal class Hydravion: Vehicule, IMotorise, IVolant, IFlottant
    {
        public Hydravion(string nom, string marque) : base(nom, marque)
        {
        }

        public void Demarrer()
        {
            Console.WriteLine($"{Nom} de marque {Marque} peut démarrer");
        }

        public void Decoller()
        {
            Console.WriteLine($"{Nom} de marque {Marque} peut décoller");
        }

        public void Atterir()
        {
            Console.WriteLine($"{Nom} de marque {Marque} peut atterir");
        }

        public void Naviguer()
        {
            Console.WriteLine($"{Nom} de marque {Marque} peut naviguer sur l'eau");
        }
    }
}
