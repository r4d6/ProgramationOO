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
            using (StreamReader fichierLecture = new StreamReader(file))
            {
                // Lit une ligne du fichier
                string ligne = fichierLecture.ReadLine();

                // null
                while (ligne != null)
                {
                    Console.WriteLine(ligne);
                    ligne = fichierLecture.ReadLine();
                }
            }
        }

        public string DemanderNom()
        {
            return "Eva";
        }

        public void AfficherSolde(string name)
        {

        }

        public double DemanderMontant()
        {
            return 12.54;
        }

        public void Deposer(string name, double amount)
        {

        }

        public void Retirer(string name, double amount)
        {

        }

        public void Sauvegarder()
        {

        }

        private void storefile(string strings)
        {
            string file = strings;
        }

        private void storefile()
        {

        }

        private const int NbComptes = 5;
        // Un tableau de 5 comptes bancaires.
        // Notez que le tableau est vide et que les comptes ne sont pas initialisés.
        // Dans le constructeur, il sera nécessaire de créer chaque objet contenu dans le tableau:
        //   _comptes[0] = new CompteBancaire(...);
        //   ...
        //   _comptes[4] = new CompteBancaire(...);
        private CompteBancaire[] _comptes = new CompteBancaire[NbComptes];
    }

    class CompteBancaire
    {

    }
}
