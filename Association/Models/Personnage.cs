using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association.Models
{
    internal class Personnage
    {
        string _nom;
        int _hp;
        private List<Arme> _armes;

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

        public List<Arme> Armes
        {
            get
            {
                return _armes;
            }

            set
            {
                _armes = value;
            }
        }

        public Personnage(int hp, string nom)
        {
            Hp = hp;
            Nom = nom;
            Armes = new List<Arme>();
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
