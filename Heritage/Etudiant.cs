using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    /// <summary>
    /// Contient l'information d'un étudiant
    /// </summary>
    
    // La classe étudiant hérite de la classe Personne
    // Personne est une généralisation d'Étudiant, Étudiant est une spécialisation de Personne
    // Personne est la classe de base, Étudiant est la classe dérivée
    // Personne est la classe parent (Mère), Étudiant est la classe enfant (fille)
    // L'h.ritage est une relation "EST UN(E)" : un étudiant est une personne
    class Etudiant : Personne
    {
        public Etudiant()
        {

        }

        // à Chaque fois qu'un constructer d'une classe dérivée est appelé, un constructeur de la classe de base est aussi toujours appelé
        // Si aucun constructeur de la classe de base n'est spécifié, le constructer par défaut est implicitement choisi
        // Le constructeur de la classe de base est toujours appelé avant le constructeur de la classe dérivé
        public Etudiant(string prenom, string nom, int année, int mois, int jour, int matricule)
        {
            Prenom = prenom;
            Nom = nom;
            DateDeNaissance = new DateTime(année, mois, jour);
            Matricule = matricule;
        }

        // Le mot clé base sert à appelé le constructeur de base
        public Etudiant(int bidon, string prenom, string nom, int année, int mois, int jour, int matricule) : base(prenom, nom, année, mois, jour)
        {

            Matricule = matricule;
        }

        public int Matricule { get; set; }
    }
}
