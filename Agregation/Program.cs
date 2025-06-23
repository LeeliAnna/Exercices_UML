using Agregation.Models;

namespace Agregation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Soldat s1 = new Soldat("infanterie", "Frodon", 10);
            Tank t1 = new Tank("anphibie", "U1", 200);

            Territoire t = new Territoire("La compte");
            try
            {
                t.AjouterUnite(s1);
                t.AjouterUnite(t1);

            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }


            s1.Attaquer();
            t1.Attaquer();

            Console.WriteLine(t1.GetType());
            Console.WriteLine(s1.GetType());

        }
    }
}
