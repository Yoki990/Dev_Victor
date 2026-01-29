using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13.Classes
{
    internal class Carre: Figure
    {
        public double Cote { get; set; }

        public Carre(Point origine, double cote) : base(origine)
        {
            Cote = cote;
        }

    }
}
