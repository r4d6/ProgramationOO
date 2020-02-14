using System;
using System.IO;

namespace Intro_OO
{
    class CompteBancaire
    {
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="nom">Nom du compte</param>
        /// <param name="soldeInitial">solde initial du compte</param>
        public CompteBancaire(string nom, double soldeInitial)
        {
            _nom = nom;
            _solde = soldeInitial;

            // On incrémente le dernier numéro, et on prend cette valeur pour le numéro du compte
            _numero = ++_derniernumero;
        }

        public void Afficher()
        {
            Console.WriteLine("Compte {0}: {1}", _numero, _nom);
        }

        // Pas nécéssaire d'avoir un objet pour une méthode de classe
        public static int DernierNumero()
        {
            return _derniernumero;
        }
        public bool EstEgalA(string nom)
        {
            return _nom == nom;
        }

        public void AfficherSolde()
        {
            Console.WriteLine("Solde du compte {0} : {1}", _nom, _solde);
        }

        public void Deposer(double amount)
        {
            _solde += amount;
            Console.WriteLine("Depot de {0} dans le compte {1}, souveau solde: {2}", amount, _nom, _solde);
        }

        public void Retirer(double amount)
        {
            if (amount <= _solde)
            {
                _solde -= amount;
                Console.WriteLine("Retrait de {0} dans le compte {1}, souveau solde: {2}", amount, _nom, _solde);
            }
            else
            {
                Console.WriteLine("Retrait impossible, solde insuffisant");
            }
        }

        public void Sauvegarder(StreamWriter file)
        {
            file.WriteLine(_nom);
            file.WriteLine(_solde);
        }

        // Le mot clé readonly est similaire a const, mais la valeur n'a pas besoin d'être connue à la déclaration
        // L'initialisation se fera dans le constructeur, puis la valeur ne poura plus être modifier
        private readonly string _nom;
        private double _solde;

        // Un attribut static est un attribut the classe, au contraire d'un attribut d'objet pour les autres
        // Tous les objets de la classe partage la même variable
        private static int _derniernumero = 1000;

        // Numéro qui identifie le compte de manière unique
        private readonly int _numero;
    }
}
