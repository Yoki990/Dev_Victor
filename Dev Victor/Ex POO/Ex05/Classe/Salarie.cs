using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05.Classe
{
    internal class Salarie
    {
        private string _nom;
        private string _service;
        private double _salaire;
        private static int _nbEmployes = 0;
        private static double _salaireTotal = 0;


        public string Nom { get =>  _nom; set => _nom = value; }
        public string Service { get => _service; set => _service = value; }
        public double Salaire { get => _salaire; set => _salaire = value; }
        public static int NbEmployes { get => _nbEmployes; set => _nbEmployes = value; }
        public static double SalaireTotal { get => _salaireTotal;set => _salaireTotal = value; }

        public Salarie()
        {
            
            _nbEmployes++;
            _salaireTotal+= _salaire;
            
        }

        public Salarie(string nom,  string service, double salaire): this()
        {
            Nom = nom;
            Service = service;
            Salaire = salaire;
        }

        public static void AfficherSalaire()
        {
            Console.WriteLine($"Le montant total des salaires des {NbEmployes} employés est de {SalaireTotal} euros.");
        }

        public override string ToString()
        {
            return ($"Le salaire de {Nom}, {Service}, est de {Salaire} euros.");
        }


    }
}
