using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10.Classes
{
    internal sealed class Rectangle : Forme
    {
        public float Longueur { get; set; }
        public float Largeur { get; set; }

        public Rectangle(string nom, float longueur, float largeur): base(nom)
        { 
            Longueur = longueur;
            Largeur = largeur;
        }

        public sealed override void CalculerPerimetre()
        {
            Console.WriteLine($"Le périmètre du rectangle est de : {2 * (Longueur + Largeur)}");
        }
        public sealed override void CalculerAire()
        {
            Console.WriteLine($"L'aire du rectangle est de : {Longueur * Largeur}");

        }
    }
}
