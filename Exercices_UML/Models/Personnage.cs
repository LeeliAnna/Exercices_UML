using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices_UML.Models
{
    internal class Personnage
    {
        string _nom;
        int _hp;

        public string Nom
        {
            get
            {
                return _nom;
            }

            set
            {
                _nom = value;
            }
        }

        public int Hp
        {
            get
            {
                return _hp;
            }

            set
            {
                _hp = value;
            }
        }

        public Personnage(int hp, string nom)
        {
            Hp = hp;
            Nom = nom;
        }

        public void Attaquer()
        {
            Console.WriteLine("On attaque!!!");

        }

        public void SeDeplacer(int posX, int posY)
        {
            Console.WriteLine($"On se déplace vers {posX} : {posY}");
        }
    }
}
