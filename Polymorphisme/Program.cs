using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisme
{
    class Program
    {
        static void Main(string[] args)
        {
            TestEtudiant();

            Pause();
        }

        static void TestEtudiant()
        {
            Personne p = new Personne("Aelith");
            AfficherPersonne(p);

            Console.WriteLine("----------------------------------------------");

            Etudiant e = new Etudiant("Aether", 1929205);
            AfficherPersonne(e);
        }

        static void AfficherPersonne(Personne p)
        {
            // On peut recevoir en argument une variable de type Personne, ou de tout type héritant de Personne
            // Si l'argument est d'un type dérivé, on n'a pas accès à rien d'autre que la partie Personne
            Console.WriteLine("Le nom de la personne est: " + p.Nom);

            p.DireNom();
            p.DireBonjour();
            p.DireInfo();
        }


        static void Pause()
        {
            Console.WriteLine("Appuyer sur une touche pour continuer");
            Console.ReadKey(true);
        }
    }
}
