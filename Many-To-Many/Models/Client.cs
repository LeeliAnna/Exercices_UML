using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Many_To_Many.Models
{
    internal class Client
    {
        public string Nom { get; set; }
        public string Email { get; set; }

        public List<Reservations> ReservationsClient { get; set; }


        public Client(string nom, string email)
        {
            Nom = nom;
            Email = email;
            ReservationsClient = new List<Reservations>();
        }
    }
}
