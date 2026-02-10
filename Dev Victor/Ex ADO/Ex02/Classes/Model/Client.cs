using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02.Classes.Model
{
    internal class Client
    {
        public int? Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }
        public string Telephone { get; set; }

        public Client(int? id, string nom, string prenom, string adresse, string codePostal, string ville, string telephone)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Adresse = adresse;
            CodePostal = codePostal;
            Ville = ville;
            Telephone = telephone;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Nom: {char.ToUpper(Nom[0]) + Nom.Substring(1)} {char.ToUpper(Prenom[0]) + Prenom.Substring(1)}, Adresse: {Adresse} {CodePostal} {char.ToUpper(Ville[0]) + Ville.Substring(1)}, Numéro de téléphone: {Telephone}";
        }
    }
}
