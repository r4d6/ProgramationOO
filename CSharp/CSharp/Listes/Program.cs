using System;
using System.Collections.Generic; // Pour la classe List

namespace Listes
{
    class Program
    {
        static void Main()
        {
            TestEntier();
            Pause();
        }

        static void Pause()
        {
            Console.WriteLine("Press a key to continue...");
            Console.ReadKey(true);
            Console.Clear();
        }

        static void TestEntier()
        {
            List<int> listeEntier = new List<int>();

            Random generateurAleatoire = new Random();
            for (int i = 0; i < 15; i++)
            {
                listeEntier.Add(generateurAleatoire.Next(100));
            }

            Console.WriteLine("Nombres :");

            foreach (int entier in listeEntier)
            {
                Console.WriteLine(entier);
            }
        }
    }
}
