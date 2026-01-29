using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11.Classes
{
    internal sealed class Scientifique : Travailleur
    {
        public string _discipline { get; set; }
        public string _typeScientifique { get; set; }


        public Scientifique(string nom, string prenom, string numeroTelephone, string email,
            string nomEntreprise, string adresseEntreprise, string telephoneProfessionnel, string discipline, string typeScientifique) :
            base(nom, prenom, numeroTelephone, email, nomEntreprise, adresseEntreprise, telephoneProfessionnel)
        {
            _discipline = discipline;
            _typeScientifique = typeScientifique;
        }

        public new void ToString()
        {
            Console.WriteLine($"{_prenom} {_nom} à une discipline en {_discipline}, et il travaille en {_typeScientifique}");
        }


    }
}
