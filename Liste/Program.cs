using System;
using System.Collections.Generic; // Pour la classe liste
using System.Text;

namespace Liste
{
    class Program
    {
        static void Main(string[] args)
        {
            TestListe();

            Pause();
        }

        static void TestListe()
        {
            List<string> liste = new List<string>();

            // Ajoute à la fin de la liste (push back)
            liste.Add("Un");
            liste.Add("Trois");
            liste.Add("Quatre");
            liste.Add("Trois");
            liste.Add("Quatre");
            AfficherListe(liste);

            Console.WriteLine("Insertion de Deux à la position 1");
            liste.Insert(1, "Deux"); // Commence à 0
            AfficherListe(liste);

            Console.WriteLine("Insertion de Zero à la position 0");
            liste.Insert(0, "Zero"); // Commence à 0
            AfficherListe(liste);
        }

        static void AfficherListe(List<string> liste)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Taille de la liste : " + liste.Count);
            Console.WriteLine("Contenu : ");
            foreach (string s in liste)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("------------------------");
        }

        static void Pause()
        {
            Console.WriteLine("Appuyer sur une touche pour continuer");
            Console.ReadKey(true);
        }
    }
}
