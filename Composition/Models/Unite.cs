using Composition.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition.Models
{
    internal abstract class Unite
    {
        private string _nom;
        private int _cout;


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

        public int Cout
        {
            get
            {
                return _cout;
            }

            set
            {
                _cout = value;
            }
        }

        protected Unite(string nom, int cout)
        {
            Nom = nom;
            Cout = cout;
        }
        public abstract void Attaquer();
        public abstract void Afficher();
        public abstract Enumerations RechercheTypeUnite();
    }
}
