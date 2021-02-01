using System;
using System.Collections.Generic; // Pour la classe liste
using System.Text;

namespace Liste
{
    class Personne
    {
        public Personne(string nom)
        {
            Nom = nom;
        }
        public string Nom { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TestFile();

            Pause();
        }

        static void TestFile()
        {
            // Une file est une structure dans laquelle il n'est possible d'ajouteur des éléments qu'à la fin, et de les retirer qu'au début
            // Par exemple : Une file d'attente

            Queue<string> clients = new Queue<string>();

            clients.Enqueue("Aelith");

            // Dequeue enlève l'élément au début de la file
            string unCleint = clients.Dequeue();
        }

        static void TestPile()
        {
            // Une pile est une structure dans laquelle in n'est possible d'ajouter et de retirer des éléments qu'au début.
            // Par exemple, une pile d'assièttes

            Stack<string> cartes = new Stack<string>();
            // Push ajoute un élément sur le dessus de la pile
            cartes.Push("Kira");

            // Pop retire un élément du dessus de la pile
            string cartage = cartes.Pop();
        }

        static void TestPersonne()
        {
            List<Personne> listePersonnes = new List<Personne>();

            listePersonnes.Add(new Personne("Aelith"));

            Personne Aelita = new Personne("Aether"); // Faute d'orthographe
            listePersonnes.Add(Aelita);

            foreach (var personne in listePersonnes)
            {
                Console.WriteLine(personne.Nom);
            }

            Aelita.Nom = "Aelita";

            foreach (var personne in listePersonnes)
            {
                Console.WriteLine(personne.Nom);
            }
        }

        static void TestDate()
        {
            List<DateTime> listeDates = new List<DateTime>();

            listeDates.Add(new DateTime(1995, 4, 30));
            foreach (var date in listeDates)
            {
                Console.WriteLine(date.ToShortTimeString());
            }

            DateTime maintenant = DateTime.Now;
            Console.WriteLine(maintenant);
        }

        static void TestRandomNumber()
        {
            // Déclare une variable qui va permettre de générer des nombres aléatoires
            // Il est possible de spécifier une valeur d'initialisation dans le constructeur : Random(123)
            // Le constructeur par défaut initialise ke générateur avec l'horloge
            Random r = new Random();
            List<int> listeEntier = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                listeEntier.Add(r.Next());
            }

            for (int i = 0; i < 5; i++)
            {
                // Next va retourner un entier au hasard entre 0 et 99
                listeEntier.Add(r.Next(100));
            }

            for (int i = 0; i < 5; i++)
            {
                // Next va retourner un entier au hasard entre 1000, 9999
                listeEntier.Add(r.Next(1000, 10000));
            }


            foreach (var entier in listeEntier)
            {
                Console.WriteLine(entier);
            }

            Console.WriteLine();
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
