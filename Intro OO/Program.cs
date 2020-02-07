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
            Test_Hologe();

            Pause();
        }

        static void Test_Hologe()
        {
            Horloge h1 = new Horloge(12);
            h1.Afficher(); // 12:00:00

            // Définit une horloge à 12h34
            Horloge h2 = new Horloge(12, 34);
            h2.Afficher(); // 12:34:00

            // Définit une horloge à 12h34 et 56 secondes
            Horloge h3 = new Horloge(12, 34, 56);
            h3.Afficher(); // 12:34:56

            Console.WriteLine("Heures de h3 : " + h3.Heures);
            Console.WriteLine("Minute de h3 : " + h3.Minutes);
            Console.WriteLine("Secondes de h3 : " + h3.Secondes);

            // Ne dois pas compiler
            /*
            h3.Heures = 1;
            h3.Minute = 1;
            h3.Secondes = 1;*/

            // L'horloge doit valider les paramètres: Heures entre 0-23, Minutes & Secondes entre 0-59
            // Les valeurs invalide sont silencieusement ignorées
            Horloge h5 = new Horloge(12, 34, 0);
            
            if (h2.EstEgaleA(h5))
            {
                Console.WriteLine("h2 est égale à h5"); // Attendu
            }
            else
            {
                Console.WriteLine("h2 n'est pas égale à h5");
            }

            if (h2.EstEgaleA(h3))
            {
                Console.WriteLine("h2 est égale à h3");
            }
            else
            {
                Console.WriteLine("h2 n'est pas égale à h3"); // Attendu
            }

            // Contrainte
            // Horloge ne doit avoir que des secondes, 60 secondes dans une minute et 3600 secondes dans une heure
        }

        static void Test_Rectangle()
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

            // Autre object, initialisé avec des valeurs
            // Hauteur de 4, largeur de 8
            Rectangle r3 = new Rectangle(4, 8);
            r3.Nom = "Aether";
            Console.WriteLine(r3.Nom + ": Largeur = " + r3.Largeur + ", Hauteur = " + r3.Hauteur() + ", Aire = " + r3.Air());
            Console.WriteLine();
            Console.WriteLine();
            r3.Afficher('X');
        }

        static void Pause()
        {
            Console.WriteLine("Appuyer sur une touche pour continuer");
            Console.ReadKey(true);
        }
    }
}
