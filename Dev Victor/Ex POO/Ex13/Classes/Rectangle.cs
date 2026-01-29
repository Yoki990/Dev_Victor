using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13.Classes
{
    internal class Rectangle : Figure
    {
        public double Longueur { get; set; }
        public double Largeur { get; set; }

        public Rectangle(Point origine, double longueur, double largeur): base(origine)
        {
            Longueur=longueur;
            Largeur=largeur;
        }


    }
}
