using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agregation.Models;

namespace Agregation.Models
{
    internal class Territoire
    {
        // dico
        private string _nom;
        private List<Unite> _unites;

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


        public Territoire(string nom)
        {
            Nom = nom;
            _unites = new List<Unite>();
            //initailiser dico

        }

        public void Afficher()
        {
            foreach (Unite u in _unites)
            {
                u.Afficher();
            }
        }

        public void AjouterUnite(Unite unite)
        {

            if (!_unites.Contains(unite))
            {
                int compt = compterParType();
                if (compt < acces dico par cle (split dernier mot unite.GetType().ToString())
                {
                    _unites.Add(unite);
                }
                else 
                {
                    Console.WriteLine("Impossible");
                }
            

            }
        }

        public void SupprimerUnite(Unite unite) 
        {
            if (_unites.Contains(unite))
            {
                _unites.Remove(unite);
            }
        }

        public int compterParType(string nom)
        {
            int compte = 0;
            foreach (Unite u in _unites)
            {

                if (u.GetType() == nom.GetType())
                {
                    compte++;
                }
            }
            return compte;
        }
    }
}
