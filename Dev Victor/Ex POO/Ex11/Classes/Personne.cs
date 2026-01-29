using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11.Classes
{
    internal abstract class Personne
    {

        public string _nom { get; set; }
        public string _prenom { get; set; }
        public string _numeroTelephone { get; set; }
        public string _email { get; set; }


        public Personne(string nom, string prenom, string numeroTelephone, string email)
        {
            _nom = nom;
            _prenom = prenom;
            _numeroTelephone = numeroTelephone;
            _email = email;

        }

        public virtual void ToString()
        {
            Console.WriteLine($"La personne s'appelle {_prenom} {_nom}, son numéro de téléphone est {_numeroTelephone}, son email est {_email}.");
        }
    }
}
