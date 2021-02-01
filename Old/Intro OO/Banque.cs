using System;
using System.IO;

namespace Intro_OO
{
    /// <summary>
    /// Une banque contient 5 comptes bancaires et permet d'effectuer des opérations sur les comptes
    /// </summary>
    class Banque
    {
        public Banque(string file)
        {
            _file = file;
            using (StreamReader fichierLecture = new StreamReader(file))
            {
                for (int i = 0; i < NbComptes; i++)
                {
                    string nom = fichierLecture.ReadLine();
                    double solde = Convert.ToDouble(fichierLecture.ReadLine());
                    // Crée un nouveau compte bancaire avec l'information lue du fichier
                    _comptes[i] = new CompteBancaire(nom, solde);
                }
            }
        }

        public void ListerComptes()
        {
            // Pour chaque compte du tableau
            foreach (CompteBancaire compte in _comptes)
            {
                compte.Afficher();
            }


            // Pour appeler une méthode static, il faut utilisé le nom de la classe
            Console.WriteLine("Dernier Numéro : " + CompteBancaire.DernierNumero());
            // WriteLine est une méthode static de la classe Console
        }

        public void AfficherSolde(string name)
        {
            int index = RechercherCompte(name);
            if (index != -1)
            {
                _comptes[index].AfficherSolde();
            }
        }

        private int RechercherCompte(string name)
        {
            for (int i = 0; i < NbComptes; i++)
            {
                if (_comptes[i].EstEgalA(name))
                {
                    return i;
                }
            }

            // Si on arrive ici, on a tout cherché et on a rien touvé
            Console.WriteLine("Le compte n'existe pas");
            return -1;
        }

        public double DemanderMontant()
        {
            return 12.54;
        }

        public void Deposer(string name, double amount)
        {
            int index = RechercherCompte(name);
            if (index != -1)
            {
                _comptes[index].Deposer(amount);
            }
        }

        public void Retirer(string name, double amount)
        {
            int index = RechercherCompte(name);
            if (index != -1)
            {
                _comptes[index].Retirer(amount);
            }
        }

        public void Sauvegarder()
        {
            using (StreamWriter write = new StreamWriter(_file))
            {
                foreach (var compte in _comptes)
                {
                    compte.Sauvegarder(write);
                }
            }
        }

        private const int NbComptes = 5;
        // Un tableau de 5 comptes bancaires.
        // Notez que le tableau est vide et que les comptes ne sont pas initialisés.
        // Dans le constructeur, il sera nécessaire de créer chaque objet contenu dans le tableau:
        //   _comptes[0] = new CompteBancaire(...);
        //   ...
        //   _comptes[4] = new CompteBancaire(...);
        private CompteBancaire[] _comptes = new CompteBancaire[NbComptes];
        private string _file;
    }
}
