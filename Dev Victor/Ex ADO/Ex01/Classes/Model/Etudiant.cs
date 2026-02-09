using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01.Classes.Model
{
    internal class Etudiant
    {
        public int? Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Email { get; set; }

        public Etudiant(int? id, string nom, string prenom, DateTime dateNaissance, string email)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            DateNaissance = dateNaissance;
            Email = email;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Nom: {char.ToUpper(Nom[0]) + Nom.Substring(1)} {char.ToUpper(Prenom[0]) + Prenom.Substring(1)}, Date de Naissance: {DateNaissance.ToString("dd-MM-yyyy")}, Email : {Email}";
        }
    }
}
 