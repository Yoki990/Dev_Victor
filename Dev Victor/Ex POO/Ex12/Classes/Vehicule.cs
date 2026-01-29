using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12.Classes
{
    internal class Vehicule
    {

        public string Nom {get;set;}
        public string Marque {get;set;}

        public Vehicule(string nom, string marque)
        {
            Nom = nom;
            Marque = marque;
        }

        public void ToString()
        {

        }
    }
}
