using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Many_To_Many.Models
{
    internal class Skill
    {

        public string Nom {  get; set; }
        public string Type { get; set; }
        public List<SkillLevel> SkillListe { get; set; }

        public Skill(string nom, string type)
        {
            Nom = nom;
            Type = type;
            SkillListe = new List<SkillLevel>();
        }

        public void Use()
        {
            Console.WriteLine($"J'utilise mon skill {Nom}");
        }

        public void AddSkillLevel(SkillLevel level)
        {
            SkillListe.Add(level);
            level.SetSkill(this);
        }



    }
}
