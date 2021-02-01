using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisme
{
    class Personne
    {
        public Personne(string nom)
        {
            Console.WriteLine("Contructeur de Personne");
            Nom = nom;

            // On ne dois jamais appeler une méthode virtuelle dans un constructeur
            // L'object dérivé n'est pas encore construit
            /*
            Console.WriteLine("Appel de DireInfo à partir du constructeur de Personne");
            DireInfo();
            Console.WriteLine("+++++++");*/
        }

        public string Nom { get; set; }

        public void DireNom()
        {
            Console.WriteLine("Mon nom est : " + Nom);
            Console.WriteLine("Appel de DireInfo à partir de DireNom");
            DireInfo();
            Console.WriteLine("----");
        }

        // Le mot clé virtual indique que la méthode va pouvoir être remplacer par une version définie dans une classe dérivée
        public virtual void DireBonjour()
        {
            Console.WriteLine("Bonjour, je suis une personne");
        }

        public virtual void DireInfo()
        {
            Console.WriteLine("Je suis une personne et je m'appelle " + Nom);
        }
    }

    class Etudiant : Personne
    {
        public Etudiant(string nom, int matricule) : base (nom)
        {
            Console.WriteLine("Contructeur d'Étudiant");
            Matricule = matricule;
        }

        public int Matricule { get; set; }

        // Le mot clé override indique que la méthode remplace la versioin de la classe de base.
        // Ne peut s'utiliser que pour des méthodes virtuelles
        // Il n'est pas nécéssaire de redéfinir une méthode virtuelle. Dans ce cas, elle se comporte comme une méthode ordinaire et la version de base est appelée
        public override void DireBonjour()
        {
            Console.WriteLine("Bonjour, je suis une étudiante");
        }

        public override void DireInfo()
        {
            base.DireInfo(); // Appelle la version de Personne
            Console.WriteLine("Je suis aussi un étudiant et mon matricule est : " + Matricule);
        }
    }
}
