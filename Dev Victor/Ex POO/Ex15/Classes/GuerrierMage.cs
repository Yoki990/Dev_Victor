using Ex15.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15.Classes
{
    internal class GuerrierMage : Personnage, IAttaqueSpeciale, IMAgie
    {
        public GuerrierMage(string nom, string prenom, int pV, int damage) : base(nom, prenom, pV, damage)
        {
        }

        public override void Attaquer(Personnage enemy)
        {
            throw new NotImplementedException();
        }

        public void AttaqueSpeciale(Personnage enemy)
        {
            throw new NotImplementedException();
        }

        public void LancerSort(Personnage enemy)
        {
            throw new NotImplementedException();
        }
    }
}
