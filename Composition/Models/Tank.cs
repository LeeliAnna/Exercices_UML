using Composition.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition.Models
{
    internal class Tank : Unite
    {
        private string _model;


        public string Model
        {
            get
            {
                return _model;
            }

            set
            {
                _model = value;
            }
        }
        public Tank(string model, string nom, int cout) : base(nom, cout)
        {
            _model = model;
        }

        public override void Attaquer()
        {
            Console.WriteLine($"Le Tank attaque avec son méga canon!");
        }

        public override void Afficher()
        {
            Console.WriteLine($"Je suis un tank du type {Model}");
        }

        public override Enumerations RechercheTypeUnite()
        {
            return Enumerations.Tank;
        }
    }
}
