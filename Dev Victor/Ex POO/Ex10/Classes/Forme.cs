using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10.Classes
{
    internal abstract class Forme
    {
        public string Nom {  get; set; }


        public Forme(string nom)
        {
            Nom = nom;
        }

        public abstract void CalculerAire();

        public abstract void CalculerPerimetre();
        public void infos()
        {
            Console.WriteLine($"Le nom de la forme est un {Nom}");
            CalculerPerimetre();
            CalculerAire();
        }
    }
}
