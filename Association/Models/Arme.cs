using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association.Models
{
    internal class Arme
    {
        private int _puissance;
        private string _nom;


        public int Puissance
        {
            get
            {
                return _puissance;
            }

            set
            {
                _puissance = value;
            }
        }

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

        public Arme(int puissance, string nom)
        {
            Puissance = puissance;
            Nom = nom;
        }

        public void ProvoquerDegat()
        {
            Console.WriteLine($"On utilise l'arme {Nom}");
        }
    }
}
