using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Many_To_Many.Models
{
    internal class Character
    {

        public string Nom {  get; set; }
        public int Hp { get; set; }
        public List<SkillLevel> CharactereSkillList { get; set; }

        public Character(string nom, int hp)
        {
            Nom = nom;
            Hp = hp;
            CharactereSkillList = new List<SkillLevel>();
        }

        public void Attaquer()
        {
            Console.WriteLine($"{Nom} attaque!");
        }

        public void AddSkillLeve(SkillLevel skill)
        {
            //Ajoute le skillleve au character
            CharactereSkillList.Add(skill);
            skill.SetCharachter(this);
        }
        
        public void Display()
        {
            foreach (SkillLevel sk in CharactereSkillList)
            {
                Console.WriteLine(sk.Valeur);
                Console.WriteLine(sk.CoolDown);
            }
        }

    }
}
