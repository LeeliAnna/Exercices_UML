using Exercices_UML.Models;

namespace Exercices_UML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personnage joueur = new Personnage(50, "Toto");
            joueur.Attaquer();
            joueur.SeDeplacer(10, 10);
        }
    }
}
