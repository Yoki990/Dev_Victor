using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ex02.Classe
{
    internal class Rectangle
    {

        private int _largeur;
        private int _hauteur;

        public int largeur { get => _largeur; set => _largeur = value; }
        public int hauteur { get => _hauteur; set => _hauteur = value; }

        public Rectangle(int largeur, int hauteur)
        {
            _largeur = largeur;
            _hauteur = hauteur;
        }
        public void perimetre()
        {
            int perimetreCalc = 2*(largeur+hauteur);
            Console.WriteLine($"Le périmètre du rectangle est de {perimetreCalc}");
        }

        public void surface()
        {
            int surfaceCalc = largeur * hauteur;
            Console.WriteLine($"La surface du rectangle est de {surfaceCalc}");
        }
    }
}
