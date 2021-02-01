using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tableau = { 12, 34, 56, 78, 90 };

            // Un bloc d'instruction qui débute par le mot clé try va permettre de gérer les erreurs possible dans l'exécution de ce bloc
            /*
            try
            {
                Console.Write("Entrez un index : ");
                int index = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Index = " + index);
                Console.WriteLine("valeur du tableau à l'index = " + tableau[index]);
            }

            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("Erreur: " + e.Message);
            }

            // Un bloc try doit être suivi d'un bloc catch, qui sera executé si il y a une erreur
            catch (Exception exception)
            {
                Console.WriteLine("Erreur: " + exception.Message);
            }
            catch // Équivalent à catch(Exception e), mais sans information sur l'erreur
            {
                Console.WriteLine("Erreur");
            }

            try
            {
                DemanderValeur();
            }

            catch (Exception exception)
            {
                Console.WriteLine("Erreur: " + exception.Message);
            }

            // finally va s'executer meme s'il n'y a pas eu d'exception
            finally { }*/

            TestDate();

            Pause();
        }

        static void TestDate()
        {
            Console.WriteLine("Indiquez une date (A/M/J)");
            string line = Console.ReadLine();
            string[] valeurs = line.Split('/');
            /*
            foreach  (string v in valeurs)
            {
                Console.WriteLine(v);
            }*/
            Date date = new Date(valeurs);
            date.Afficher();
        }

        static void DemanderValeur()
        {
            Console.Write("Entrer une valeur entre 1 et 10 : ");
            int valeur = Convert.ToInt32(Console.ReadLine());
            ValiderValeur(valeur);
            Console.WriteLine("la valeur est valide");
        }

        static void ValiderValeur(int valeur)
        {
            if (valeur < 1 || valeur > 10)
            {
                // throw lance une exception
                // Faire un throw arrete l'execution du programme justqu'au prochain catch
                throw new ArgumentException();
            }
            Console.WriteLine("Validation terminé");
        }

        static void Pause()
        {
            Console.WriteLine("Appuyer sur une touche pour continuer");
            Console.ReadKey(true);
        }
    }

    // Si nous avons besoin d'un type d'exception particulier, nous pouvons simplement définir notre propre classe pour nos besoins.
    // Pour pouvoir être utilisée avec les instructions throw et catch, la classe doit hériter de la classe System.Exception
    class Date
    {
        public Date(string[] valeurs)
        {
            // Valider les valeurs
            // Annee > 0
            // Mois entre 1 & 12
            // Jours entre 1 & 
            if(ValiderDate(valeurs))
            {
                Console.WriteLine("Date valide");
            }
            else
            {
                Console.WriteLine("Date invalide");
            }
        }

        public void Afficher()
        {
            Console.WriteLine("{0}/{1}/{2}", annee, mois, jour);
        }

        private bool ValiderDate(string[] valeurs)
        {
            annee = Convert.ToInt32(valeurs[0]);
            mois = Convert.ToInt32(valeurs[1]);
            jour = Convert.ToInt32(valeurs[2]);
            if (annee > 0)
            {
                if (mois >= 1 && mois <= 12)
                {
                    if (jour <= DateTime.DaysInMonth(annee, mois) && jour >= 1)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        int annee;
        int mois;
        int jour;
    }
}
