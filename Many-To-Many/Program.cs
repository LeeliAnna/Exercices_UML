using Many_To_Many.Models;
using System.Security.Cryptography;

namespace Many_To_Many
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Client c1 = new Client("Frodon", "frodon@facke.be");
            //Chambre room1 = new Chambre(42, 2);

            //Reservations reservation = new Reservations(new DateOnly(2025,11,06), new DateOnly(2025,11,10), c1, room1);

            //reservation.AjouterReservation(c1,room1);

            //reservation.Afficher();

            Character joueur = new Character("Bilbo", 150);
            Character joueur2 = new Character("Bombadil", 1500);
            Skill s1 = new Skill("invincibilite", "magie");
            Skill s2 = new Skill("chant", "musique");
            Skill s3 = new Skill("épée", "combat");

            SkillLevel sk1 = new SkillLevel(50, 2);
            SkillLevel sk2 = new SkillLevel(20, 1);
            SkillLevel sk3 = new SkillLevel(100, 10);
            // ici on est dans l'obligation de participation
            SkillLevel sk4 = new SkillLevel(joueur, s3, 10, 3);

            //// Attacher le skill au caractere et faire la relation avec skillleve
            //sk1.SetCharachter(joueur);
            //sk2.SetSkill(s3);

            joueur.AddSkillLeve(sk1);
            joueur.AddSkillLeve(sk2);

            joueur.Display();





        }
    }
}
