using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ex08.Classes
{
    internal class CompteBancaire
    {

        public string Titulaire { get; set; }
        public float Solde { get; set; }
        public string Devise { get; set; }
        public float Montant { get; set; }


        public CompteBancaire() { }


        public CompteBancaire(string titulaire, float solde, string devise)
        {
            Titulaire = titulaire;
            Solde = solde;
            Devise = devise;
        }

        public void Deposer(CompteBancaire titulaire)
        {
            titulaire.Solde += Montant;
            Console.WriteLine($"{Titulaire} a déposé {Montant} {Devise}.");
        }

        public void Retirer(CompteBancaire titulaire)
        {
            if (Solde > 0)
            {
                titulaire.Solde -= Montant;
                Console.WriteLine($"{Titulaire} a retiré {Montant}.");
            }
            else
            {
                Console.WriteLine("Désolé, vous êtes à decouvert");
            }
        }

        public void AfficherSolde()
        {
            Console.WriteLine($"Il reste {Solde} euros à {Titulaire}");
        }

        public override string ToString()
        {
            return $"Le solde est de {Solde} {Devise}";
        }

    }
}
