using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_OO
{
    /// <summary>
    /// Representation d'une forme géométrique de type rectangle
    /// </summary>
    class Rectangle
    {
        // Par defaut, le contenu d'une classe est privé, c'est-à-dire qu'il est impossible d'y accéder de l'extérieur
        // Le mot clé "public" indique que ce qui suit peut être accéder de l'extérieur

        // Toutes les définitions seont mises en premier dans la classe, car elles intéressent les utilisateurs
        // Tous ce qui est privé est mis à la fin, car ça n'intéresse que le concepteur de la classe

        // Un constructeur est une méthode spécial qui est appelé automatiquement lors de la création d'un objet
        // Un constructeur n'a pas un type de retour
        // Un constructer porte exactement le même nom que la classe
        public Rectangle(int hauteur, int largeur)
        {
            // _hauteur = hauteur;
            // _largeur = largeur;

            // Afin de profiter des validations existantes
            SetHauteur(hauteur);
            Largeur = largeur;
        }

        // Un constructeur qui ne prend pas de paramètres se nomme un constructeur par defaut
        // Si, et seulement si, aucun contructeur n'est explicitement défini, un constructeur par défaut implicit existe
        // Si nous voulons avoir un contructeur par défaut, en plus d'autre contructeurs avec paramètres, il faut le définir explicitement
        public Rectangle()
        {
            _largeur = 1;
            _hauteur = 1;
        }

        // Pour respecter le principe d'encapsulation des données, aucun attribut ne sera public, il faut donc fournir des méthodes 
        // Une méthode pour aller chercer la valeur d'un attribut se nomme un "accesseur" (getter)
        public int Hauteur()
        {
            return _hauteur;
        }
        

        // Une méthode qui permet de modifier un attribut se nomme un "mutateur" (setter)
        public void SetHauteur(int value)
        {
            // Un mutateur va permettre de valider les valeurs donnés avant de les assigner
            // La hauteur ne peut pas être négative ni null
            if (value > 0)
            {
                _hauteur = value;
            }
        }

        // Une propriété est à mi-chemin entre un attribut et une méthode
        // S'utilise comme un attribut, se comporte comme une méthode
        // Pas de ()
        public int Largeur
        {
            // Dans le bloc d'une propriété, il est possible de définir 2 simili-méthodes

            // Accesseur
            get { return _largeur; }

            // Mutateur
            set
            {
                // Dans la partie set d'une propriété, une variable nommé "value" existe implicitement pour contenir la valeur assigné
                if (value > 0)
                {
                    _largeur = value;
                }
            }
        }

        // Propriété automatique
        // Une valeur interne est utilisé implicitemen, sans qu'on doive definir un attribut _nom
        // le get retourne simplement cette valeur, le set l'assigne sans validation
        // Il est possible d'assigner une valeur par défaut à la propriété
        // !!! À utiliser avec modération!, n'est qu'une très légère couche au dessus d'un attribut afin que celui-ci reste privé
        public string Nom { get; set; }


        //Propriété automatique, en lecture seule, mais modifiable dans la classe
        public int Couleur { get; private set; } = 15;

        //Une méthode qui retourne l'air du rectangle
        public int Air() { return _largeur * _hauteur; }

        // Propriété pour récupérer l'aire du rectangle
        // Propriété en lecture seule
        public int Aire
        {
            get { return _largeur * _hauteur; }
            // On ne définie pas la méthode set
        }

        /// <summary>
        /// Dessine le rectangle à l'écran avec le symbole donné
        /// </summary>
        /// <param name="symbole"></param>
        public void Afficher(char symbole)
        {
            // Comme la méthode
             for (int ligne = 0; ligne < _hauteur; ligne++)
            {
                for (int colonne = 0; colonne < _largeur; colonne++)
                {
                    Console.Write(symbole);
                }
                Console.WriteLine();
            }
        }

        // Il est possible d'avoir plusieus méthodes qui porte le même nom tant que le compilateur est capable de faire la difference en se basant sur les paramètres
        public void Afficher()
        {
            // Appele la version avec des paramètres
            Afficher('*');
        }

        // Une variable définie dans une class se nomme un attribut
        // Il n'y aura JAMAIS d'attribut public dans une classe
        // Même si par défaut l'accès est privé, nous allons explicitement le mentionner pour éviter la confusion
        // Le mot clé "private" indique que c'est privé à la classe
        private int _hauteur = 0;
        private int _largeur = 0;
    }
}
