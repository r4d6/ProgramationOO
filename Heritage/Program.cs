using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne p1 = new Personne();
            p1.Prenom = "Aelith";
            p1.Nom = "Aether";
            p1.DateDeNaissance = new DateTime(2002, 7, 19);
            Console.WriteLine("{0} {1}, née le {2}", p1.Prenom, p1.Nom, p1.DateDeNaissance);
            p1.Bonjour();
            Pause();

            Etudiant e1 = new Etudiant();
            e1.Prenom = "Aelita";
            e1.Nom = "Aether";
            e1.DateDeNaissance = new DateTime(2002, 7, 19);
            e1.Matricule = 1929205;
            Console.WriteLine("{0} {1}, matricule {2} née le {3}", e1.Prenom, e1.Nom, e1.Matricule, e1.DateDeNaissance);
            e1.Bonjour();
            Pause();

            Personne p2 = new Etudiant(1, "Ether", "Aether", 2002, 7, 19, 124365);
            Console.WriteLine("{0} {1}, née le {2}", p2.Prenom, p2.Nom, p2.DateDeNaissance);
            p2.Bonjour();
            Pause();
        }

        static void Pause()
        {
            Console.WriteLine("Appuyer sur une touche pour continuer");
            Console.ReadKey(true);
        }
    }
}
