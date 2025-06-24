namespace Many_To_Many.Models
{
    internal class SkillLevel
    {

        public int Valeur {  get; set; }
        public int CoolDown { get; set; }
        private Character _character;
        private Skill _skill;
        

        public SkillLevel(int valeur, int coolDown)
        {
            Valeur = valeur;
            CoolDown = coolDown;
        }

        public SkillLevel(Character c, Skill s, int valeur, int coolDown)
        {
            Valeur = valeur;
            CoolDown = coolDown;
            SetCharachter(c);
            SetSkill(s);
        }

        // Facon de modeliser l'optionalité
        public void SetCharachter(Character cha) 
        {
            _character = cha;
        }
        public void SetSkill(Skill skill)
        {
            _skill = skill;
        }
    }
}