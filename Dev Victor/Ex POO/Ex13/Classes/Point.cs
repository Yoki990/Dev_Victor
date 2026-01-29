using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13.Classes
{
    internal class Point
    {
        public double PosX {  get; set; }
        public double PosY { get; set; }


        public Point (double posX, double posY)
        {
            PosX = posX;
            PosY = posY;
        }
        public override string ToString()
        {
            return PosX + " ,   " + PosY;
        }

    }
}
