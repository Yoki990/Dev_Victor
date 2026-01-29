using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10.Classes
{
    internal sealed class Cercle : Forme
    {
        public float Rayon { get; set; }

        public Cercle(string nom,float rayon): base(nom)
        {
            Rayon = rayon;
        }

        public sealed override void CalculerPerimetre()
        {
            Console.WriteLine($"Le périmètre du rectangle est de : {float.Pi * (2*Rayon)}");
        }

        public sealed override void CalculerAire()
        {
            Console.WriteLine($"L'aire du rectangle est de : {float.Pi * Math.Pow(Rayon,2)}");
        }
    }
}
