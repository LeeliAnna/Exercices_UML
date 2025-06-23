using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Agregation.Enums;

namespace Agregation.Models
{
    internal class Soldat : Unite
    {
        private string _type;

        public string Type
        {
            get
            {
                return _type;
            }

            set
            {
                _type = value;
            }
        }

        public Soldat(string type,string nom, int cout):base(nom, cout)
        {
            Type = type;
        }

        public override void Attaquer()
        {
            Console.WriteLine($"Le soldat attaque");
        }

        public override void Afficher()
        {
            Console.WriteLine($"Je suis un sodat du type {Type}");
        }

        public override Enumerations RechercheTypeUnite()
        {
            return Enumerations.Soldat;
        }
    }
}
