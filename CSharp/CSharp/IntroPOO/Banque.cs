using System;
using System.IO;

namespace IntroPOO
{
   /// <summary>
   /// Une banque contient 5 comptes bancaires et permet d'effectuer des opérations sur les comptes
   /// </summary>
   class Banque
   {

        public Banque(string fichier)
        {
            _nomFichier = fichier; // Save the file name to use in saving.

            using (StreamReader fichierLecture = new StreamReader(fichier))
            {
                for (int i = 0; i < NbComptes; i++)
                {
                    string ligne = fichierLecture.ReadLine();
                    _comptes[i] = new CompteBancaire(ligne);
                }
            }
        }

        public void ListerComptes()
        {
            foreach (CompteBancaire compte in _comptes)
            {
                compte.Afficher();
            }
        }

        public void AfficherSolde(string nom)
        {
            CompteBancaire compte = RechercherCompte(nom);
            compte.AfficherSolde();
        }

        public void Deposer(string nom, double montant)
        {
            CompteBancaire compte = RechercherCompte(nom);
            compte.Deposer(montant);
        }

        public void Retirer(string nom, double montant)
        {
            CompteBancaire compte = RechercherCompte(nom);
            compte.Retirer(montant);
        }

        public void Sauvegarder()
        {
            using (StreamWriter fichierEcriture = new StreamWriter(_nomFichier))
            {
                foreach (CompteBancaire compte in _comptes)
                {
                    fichierEcriture.WriteLine(compte.SauvegardeFichier());
                }
            }
        }

        private CompteBancaire RechercherCompte (string nomCompte)
        {
            foreach (CompteBancaire compte in _comptes)
            {
                if(compte.EstEgalA(nomCompte))
                {
                    return compte;
                }
            }
            Console.WriteLine("This account doesn't exist.");
            return null;
        }

        private const int NbComptes = 5;

      // Un tableau de 5 comptes bancaires.
      // Notez que le tableau est vide et que les comptes ne sont pas initialisés.
      // Dans le constructeur, il sera nécessaire de créer chaque objet contenu dans le tableau:
      //   _comptes[0] = new CompteBancaire(...);
      //   ...
      //   _comptes[4] = new CompteBancaire(...);
      private CompteBancaire[] _comptes = new CompteBancaire[NbComptes];
      private string _nomFichier;
   }
}
