using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_OO
{
    class Program
    {
        // Le paramètre "args" (tableau de chaine de charactère) va servier à recevoir des arguments lors du lancement du programme
        // Exemples à venir plus tard
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();

            r1.SetHauteur(4);
            r1.Largeur = 6;
            r1.Nom = "Aelith";

            Console.WriteLine(r1.Nom + ": Largeur = " + r1.Largeur + ", Hauteur = " + r1.Hauteur() + ", Aire = " + r1.Air());
            Console.WriteLine();
            Console.WriteLine();
            r1.Afficher();


            Rectangle r2 = new Rectangle();

            r2.SetHauteur(8);
            r2.Largeur = 12;
            r2.Nom = "Aelita";

            Console.WriteLine(r2.Nom + ": Largeur = " + r2.Largeur + ", Hauteur = " + r2.Hauteur() + ", Aire = " + r2.Air());
            Console.WriteLine();
            Console.WriteLine();
            r2.Afficher('+');

            Pause();
        }

        static void Pause()
        {
            Console.WriteLine("Appuyer sur une touche pour continuer");
            Console.ReadKey(true);
        }
    }
}
