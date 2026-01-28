using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ex04.Classe
{
    internal class Chien
    {

        private string _nom;
        private string _race;
        private int _age;
        private static string _nomDuChenil = "...";
        private static int _nbChiens = 0;

        public string Nom { get => _nom; set => _nom = value; }
        public string Race { get => _race; set => _race = value; }
        public int Age { get => _age; set => _age = value; }
        public static string NomDuChenil { get => _nomDuChenil; set => _nomDuChenil = value; }
        public static int NbChiens { get => _nbChiens; set => _nbChiens = value; }

        public Chien()
        {
            _nbChiens++;            
        }

        public Chien(string nom, string race, int age, string nomDuChenil) : this()
        {
            Nom = nom;
            Race = race;
            Age = age;
        }


        public static void NombreChien()
        {
            Console.WriteLine();
            Console.WriteLine($"Il y a {NbChiens} chiens dans le chenil");
        }



        public override string ToString()
        {
            return ($"Le chien s'appelle {Nom}, c'est un {Race}, il a {Age} ans, et son chenil s'appelle {_nomDuChenil}.");
        }
    }
}
