using Association.Models;

namespace Association
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personnage joueur = new Personnage(50, "Toto");
            Arme uzi = new Arme(15, "Uzi");
            Arme arbalete = new Arme(25, "Arbalète");

            joueur.Armes.Add(uzi);
            joueur.Armes.Add(arbalete);
        }
    }
}
