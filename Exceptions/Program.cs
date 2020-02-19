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
            }/*
            catch // Équivalent à catch(Exception e), mais sans information sur l'erreur
            {
                Console.WriteLine("Erreur");
            }*/

            Pause();
        }

        static void Pause()
        {
            Console.WriteLine("Appuyer sur une touche pour continuer");
            Console.ReadKey(true);
        }
    }
}
