using Ex13.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13.Classes
{
    internal abstract class Figure: IDeplacable
    {
        public Point Origine { get; set; }

        public Figure(Point origine)
        {
            Origine = origine;
        }

        public void Deplacement(double x, double y)
        {
            Origine.PosX += x;
            Origine.PosY += y;
        }
    }
}
