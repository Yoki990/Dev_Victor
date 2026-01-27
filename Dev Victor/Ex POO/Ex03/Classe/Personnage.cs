using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.Classe
{
    internal class Personnage
    {
        private string _name;
        private int _health;
        private int _damage;

        public string Name { get => _name; set => _name = value; }
        public int Health { get => _health; set => _health = value; }
        public int Damage { get => _damage; set => _damage = value; }



        public Personnage(string name, int health, int damage)
        {
            Name = name;
            Health = health;
            Damage = damage;

        }


        public void attack(Personnage Ennemi)
        {

            Ennemi.Health = Ennemi.Health - Damage;


            Console.WriteLine($"{Name} a attaqué {Ennemi.Name}");
            Console.WriteLine($"Il reste {Ennemi.Health}pv à {Ennemi.Name}");
            Console.WriteLine();
        }

        public bool isAlive()
        {
            if (Health>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
