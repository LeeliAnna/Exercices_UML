using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agregation.Enums;
using Agregation.Models;

namespace Agregation.Models
{
    internal class Territoire
    {
        private string _nom;
        private List<Unite> _unites;
        private Dictionary<Enumerations, int> _uniteMax;

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

        public Dictionary<Enumerations, int> UniteMax
        {
            get
            {
                return _uniteMax;
            }

            set
            {
                _uniteMax = value;
            }
        }

        public Territoire(string nom)
        {
            Nom = nom;
            _unites = new List<Unite>();
            _uniteMax= new Dictionary<Enumerations, int>() 
            {
                { Enumerations.Tank, 3 },
                { Enumerations.Soldat, 10 }
            };
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
                //string recherche = unite.GetType().ToString();
                //string[] rechercheTab = recherche.Split('.');
                //string rechercheType = rechercheTab[rechercheTab.Length - 1];
                ////int compt = compterParType(unite.GetType().ToString());
                //int compt = compterParType(rechercheType);
                ////Console.WriteLine($"il y a {compt} {rechercheType} dans la liste");
                ////int uniteMax = _uniteMax.TryGetValue(rechercheType, out uniteMax);
                //if (compt < 0)
                //{
                //    _unites.Add(unite);
                //}
                //else 
                //{
                //    Console.WriteLine("Impossible");
                //}
                Enumerations type = unite.RechercheTypeUnite();
                int compt = _unites.Count(u => u.RechercheTypeUnite() == type);
                int uniteMax = _uniteMax[type];
                if (compt < uniteMax)
                {
                    _unites.Add(unite);
                }
                else
                {
                    throw new Exception($"Impossible d'ajouter plus de {uniteMax} {type}");
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
            //int compte = 0;
            //foreach (Unite u in _unites)
            //{
            //    string recherche = u.GetType().ToString();
            //    string[] rechercheTab = recherche.Split('.');
            //    string rechercheType = rechercheTab[rechercheTab.Length - 1];
            //    if (rechercheType == nom)
            //    {
            //        compte++;
            //    }
            //}
            //return compte;
            return _unites.Count(u => u.RechercheTypeUnite().ToString() == nom);
        }
    }
}
