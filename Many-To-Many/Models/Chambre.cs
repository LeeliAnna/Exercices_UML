using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Many_To_Many.Models
{
    internal class Chambre
    {

        public int Numero { get; set; }
        public int Etage { get; set; }

        public List<Reservations> ReservationsChambre { get; set; }
        public Chambre(int numero, int etage)
        {
            Numero = numero;
            Etage = etage;
            ReservationsChambre = new List<Reservations>();
        }


    }
}
