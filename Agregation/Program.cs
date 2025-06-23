using Agregation.Models;

namespace Agregation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Soldat s1 = new Soldat("infanterie", "Frodon", 10);
            Tank t1 = new Tank("Panzer", "U1", 200);
            Tank t2 = new Tank("Leopard","U2", 150);
            Tank t3 = new Tank("Abrams", "U3", 150);
            Tank t4 = new Tank("Challenger", "U4", 100);

            Territoire t = new Territoire("La compte");
            try
            {
                t.AjouterUnite(s1);
                t.AjouterUnite(t1);
                t.AjouterUnite(t2);
                t.AjouterUnite(t3);
                t.AjouterUnite(t4);

            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }


            s1.Attaquer();
            t1.Attaquer();

            t.Afficher();

        }
    }
}
