using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Many_To_Many.Models
{
    internal class Reservations
    {
        public DateOnly DateArrivee { get; set; }
        public DateOnly DateDepart { get; set; }

        public Client Client { get; set; }
        public Chambre Chambre { get; set; }

        public Reservations(DateOnly dateArrivee, DateOnly dateDepart, Client client, Chambre chambre)
        {
            DateArrivee = dateArrivee;
            DateDepart = dateDepart;
            Client = client;
            Chambre = chambre;
        }

        public void AjouterReservation(Client client, Chambre chambre)
        {
            client.ReservationsClient.Add(this);
            chambre.ReservationsChambre.Add(this);
        }

        public void Afficher()
        {
            Console.WriteLine($"La réservation du client {Client.Nom} pour la chambre numéro {Chambre.Numero} à l'étage {Chambre.Etage} : \n" +
                $"\t date d'arrivée : {DateArrivee}\n" +
                $"\t date de départ : {DateDepart}");
        }

    }
}
