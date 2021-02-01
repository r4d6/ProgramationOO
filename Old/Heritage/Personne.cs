using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    /// <summary>
    /// Contient l'information d'une personne
    /// </summary>
    class Personne
    {
        public Personne(string prenom, string nom, int année, int mois, int jour)
        {
            Prenom = prenom;
            Nom = nom;
            DateDeNaissance = new DateTime(année, mois, jour);
        }

        public Personne()
        {

        }

        public string Prenom { get; set; }
        public string Nom { get; set; }

        // Le type DateTime permet de spécifier une date de l'année et l'heure
        public DateTime DateDeNaissance { get; set; }

        public void Bonjour()
        {
            Console.WriteLine("Bonjour, je m'appelle " + Prenom + " " + Nom);
        }
    }
}
