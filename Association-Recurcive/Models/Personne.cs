using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association_Recurcive.Models
{
    internal class Personne
    {
        private string _nom;
        private List<Personne> ParentList { get; set; }
        private List<Personne> DescenentList { get; set; }

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
        public Personne(string nom)
        {
            Nom = nom;
        }

        public void Afficher()
        {
            Console.WriteLine($"Je suis {Nom}");
        }

        public void AjouterParent(Personne p)
        {
            ParentList.Add(p);
        }

        public void AjouterEnfant(Personne p)
        {
            DescenentList.Add(p);
        }

    }
}
