using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11.Classes
{
    internal class Travailleur : Personne
    {
        public string _nomEntreprise { get; set; }
        public string _adresseEntreprise { get; set; }
        public string _telephoneProfessionnel { get; set; }


        public Travailleur(string nom, string prenom, string numeroTelephone, string email, string nomEntreprise, string adresseEntreprise, string telephoneProfessionnel)
            : base(nom, prenom, numeroTelephone, email)
        {
            _nomEntreprise = nomEntreprise;
            _adresseEntreprise = adresseEntreprise;
            _telephoneProfessionnel = telephoneProfessionnel;
        }

        public new void ToString()
        {
            Console.WriteLine($"{_prenom} {_nom} travaille chez {_nomEntreprise}, le mail de l'entreprise est {_adresseEntreprise}, et le téléphone professionnel est {_telephoneProfessionnel}.");
        }


    }


}
