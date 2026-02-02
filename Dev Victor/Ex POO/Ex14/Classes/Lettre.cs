using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14.Classes
{
    internal class Lettre
    {
        public User Expediteur { get; set; }
        public User Destinataire { get; set; }
        public string Contenu { get; set; }
        public string Statut { get; set; }

        public Lettre(User expediteur, User destinataire, string contenu, string statut = "En attente")
        {
            Expediteur = expediteur;
            Destinataire = destinataire;
            Contenu = contenu;
            Statut = statut;

        }
        public void Envoyer()
        {
            Statut = "Envoyée";
            
        }

        public void Lire()
        {
            Statut = "Lue";
        }

        public override string ToString()
        {
            return $"\nLettre de {Expediteur} \nEnvoyée à {Destinataire}, avec comme contenu {Contenu} et le statut de cette " +
                $"lettre est {Statut}";
        }



    }
}
