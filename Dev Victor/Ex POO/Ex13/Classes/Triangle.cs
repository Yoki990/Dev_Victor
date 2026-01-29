using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13.Classes
{
    internal class Triangle: Figure
    {
        public double BaseTriangle { get; set; }
        public double HauteurTriangle {  get; set; }

        public Triangle(Point origine, double baseTriangle, double hauteurTriangle): base(origine)
        {
            BaseTriangle = baseTriangle;
            HauteurTriangle = hauteurTriangle;
        }
    }
}
