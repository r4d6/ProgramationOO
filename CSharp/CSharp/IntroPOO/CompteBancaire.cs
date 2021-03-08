using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IntroPOO
{
    // Tout les types de comptes possible
    enum TypeCompte
    {
        Cheque // 0
        Epargne // 1
    }

    class CompteBancaire
    {
        public CompteBancaire(string ligneFichier)
        {
            string[] elements = ligneFichier.Split(';');
            _type = elements[0];
            _nom = elements[1];
            _solde = Convert.ToDouble(elements[2]);

            _numero = ++_lastNumber;
        }

        public void Afficher ()
        {
            Console.WriteLine("Compte {0}, {1}", _type, _nom);
        }


        // Check if the given account have the correct name
        public bool EstEgalA(string nom)
        {
            return nom == _nom;
        }

        public void AfficherSolde()
        {
            Console.WriteLine("Solde du compte {0} : {1}", _nom, _solde);
        }

        public void Deposer(double montant)
        {
            _solde += montant;
            Console.WriteLine("Depot de {0} dans le compte {1}. Nouveau Solde : {2}", montant, _nom, _solde);
        }

        public void Retirer(double montant)
        {
            if (montant <= _solde)
            {
                _solde -= montant;
                Console.WriteLine("Retrait de {0} dans le compte {1}. Nouveau Solde : {2}", montant, _nom, _solde);
            }
            else 
            {
                Console.WriteLine("Not enough money in the account.");
            }

        }

        public string SauvegardeFichier()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0};{1};{2}", _type, _nom, _solde);
            return sb.ToString();
        }

        private int _numero;
        private static int _lastNumber = 1000;
        private readonly TypeCompte _type;
        private readonly string _nom;
        private double _solde;
    }
}
