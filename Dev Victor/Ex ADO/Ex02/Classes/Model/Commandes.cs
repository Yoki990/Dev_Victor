using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02.Classes.Model
{
    internal class Commandes
    {

        public int? Id { get; set; }
        public string Nom { get; set; }

        public Commandes(int? id, string nom)

        {
            Id = id;
            Nom = nom;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Nom du produit: {char.ToUpper(Nom[0]) + Nom.Substring(1)}";
        }
    }
}
