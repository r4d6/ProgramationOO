// Le format des commentaires est identique au C++
/*
 * Les commentaires multi-lignes existent aussi
 */

// En C++, il faut inclure les fichiers externes nécéssaires : #include <...>
// Il faut indiquer les namespaces utilisés : using namespace std;

// En C#, seul l'instruction using est nécéssaire
using System; // Comme en C++, les instructions se terminent par un ;
using System.Text; // Pour avoir accès au StringBuilder
using System.IO; // Pour les fichiers

// On importe toutes les définitions du namespace Astronomie
using Astronomie;

// Convention ne nomenclature
//  camelCase: lettre minuscule en premier = identifiantDePlusieursMots
//  - les variables (inclure les paramètres de méthodes)
//  PascalCase: lettre majuscule en premier = IdentifiantDePlusiersMots
//  - tout le reste


// En C#, une classe est nécessaire à tous les programmes
class Programme
{
    // La fonction main du C++ devient la methode Main d'une classe
    // le mot clé static permet d'imiter une fonction avec une méthode
    static void Main()
    {
        test_namespace();

        Console.WriteLine("Appuyer sur une touche pour continuer");
        Console.ReadKey(true);
    }

    static void test_namespace()
    {
        // Il est possible de spécifier le namespace de la definition voulue lors de l'utilisation
        Console.WriteLine(Mythologie.Mercure.Description());

        // Si le namespace n'est pas spécifier, le compilateur recherche dans les namespace utilisé
        Console.WriteLine(Mercure);
    }

    static void TestFichier()
    {
        string nomFichier = "Aelith.txt";

        #region Ecriture
        // Au lieu du ofstream, on a un StreamWriter
        // Comme le ofstream, le StreamWrite va créer le fichier si il n'existe pas et va l'écraser s'il existe
        // StreamWrite(nomFichier, true); va ajouter à la fin si le fichier existe déja
        using (StreamWriter outputFile = new StreamWriter(nomFichier, true))
        {
            outputFile.WriteLine("Aelith is sexy as hell.");
            outputFile.WriteLine("I love breeding her over and over again.");
            outputFile.WriteLine("\n");
        } // L'instruction using va avoir pour effet de fermer le fichier à la sortie du bloc associé
          // Il sera impossible d'accéder au fichier ici
        #endregion
        
        // Équivalent au ifstream
        using (StreamReader fichierLecture = new StreamReader(nomFichier))
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

    /// <summary>
    /// Les commentaires débutant par 3 / indique un commentaire de type CodeDoc
    /// La balise "summary" set a decrire la methode
    /// chaque methode aura son commantaire summary pour expliquer sa fontionnalité
    /// 
    /// Recherche dans un fichier le texte donné par l'utilisateur
    /// </summary>
    /// <remarks>Le fichier utilisé est toujours "prog.txt"</remarks>
    /// <param name="texte_file">Le nom du fichier</param> 
    /// <param name="demand">le texte à recharcher</param> 
    static void grep()
    {
       /*\
       |*| Grep()
       |*| -Demande texte a l'utilisateur
       |*| Rechercher retourne le nombre de ligne contenant le texte
       |*| Affiche aussi la ligne avec le texte
       \*/
        string texte_file = "prog.txt";
        using (StreamReader texte = new StreamReader(texte_file))
        {
            Console.WriteLine("Quelle mot voulez-vous chercher?");
            string demand = Console.ReadLine();
            string line = line = texte.ReadLine();
            int nb_of_line = 0;
            int nb_line = 0;

            nb_line++;
            while (line != null)
            {
                if (line.Contains(demand))
                {
                    nb_of_line++;
                    Console.Write(nb_line + ": ");
                    Console.WriteLine(line);
                }
                else { }
                line = texte.ReadLine();
                nb_line++;
            }
            Console.WriteLine(nb_of_line);
        }
    }

    static void TestString()
    {
        string maChaine = "Aelith";

        // Lenght est une propriété de la string, qui se comporte comme une variable, donc pas de () à la fin
        Console.WriteLine("Longeur de la chaine: " + maChaine.Length + ", le premier charactère est: " + maChaine[0] + ", Le dernier charactère est: " + maChaine[maChaine.Length - 1]);
        // Console.WriteLine(maChaine[100]); Un index à l'exterieur de la chaine fait planter le programme
        // maChaine[1] = 'a'; Impossible de modifier un string
        // Il est possible d'assigner une nouvelle valeur à un string
        maChaine = "Aelita";
        maChaine += " Aether"; // maChaine = maChaine + " Aether"
        maChaine.Trim(); // maChaine.TrimStart(), maChaine.TrimEnd()
        maChaine = maChaine.Trim(); // Il faut faire ça

        if (maChaine.Contains("Aelith"))
        {
            Console.WriteLine("Le text est contenue dans la chaine.");
        }
        else
        {
            Console.WriteLine("Le text n'est pas contenue dans la chaine.");
        }

        int index = maChaine.IndexOf("Ae");
        index = maChaine.IndexOf("Ae", index + 1); // Trouve à partir de la position
        index = maChaine.LastIndexOf("Ae"); // Commence à la fin

        // Extrait une sous-chaine, à partir de la position 4, d'une longueur de 6 charactères
        string sousChaine = maChaine.Substring(4, 6);
        Console.WriteLine(sousChaine);

        int mot = 0;

        //for (int i = 0; i < maChaine.Length; i++)
        // La boucle foreach() parcoure chaque élément de la chaine. À chaque iteration, la variable prend la valeur de l'élément courant
        foreach (char item in maChaine)
        {
            // Console.WriteLine(maChaine[i]); ---- item
            Console.WriteLine(item);
            if (char.IsWhiteSpace(item) || char.IsPunctuation(item))
            {
                mot++;
            }
        }
        Console.WriteLine("nombres de mots: " + mot);

        maChaine = "bonjour le monde";
        // Pour tous les types autre que les type de base, pour declarer une variable, il faut utiliser las syntaxe : 
        // Type variable = new Type (...);


        // Le StringBuilder garde une copie de la chaine qui peut être modifiée
        // Utile lorsque plusieurs modifications sont requises
        StringBuilder builder = new StringBuilder(maChaine);
        Console.WriteLine(builder);
        builder[0] = 'B';
        Console.WriteLine(builder);
        builder.Append("!");
        Console.WriteLine(builder);
        builder.Append(12);
        // La syntaxe de Insert, Remove, Replace est identique pour la classe string
        builder.Insert(8, "Hey"); // Insère Hey à la position 8 sans enlever du text
        builder.Remove(12, 3); // Enlève 3 charactères à partir de la position 12
        builder.Replace("ABEC", "TOUT"); // Remplace les occurences de ABEC par TOUT dans la chaine
        maChaine = builder.ToString(); // Récupère une variable de type string du contenu modifié

        // Avec l'argument de position suivi d'une virgule, le nombre indique la larger en charactère à utiliser pour afficher l'élément (setwidth)
        // Un nombre négatif aligne à gauche
        // Un nombre positif alighe à droite
        // Un symbole : permet de spécifier un format
        // D: nombre decimaux, l'espace est comblé par des 0 jusqu'au nombre donné (setwidth, setfill('0'))
        // F: nombre flottant (réel), le nombre donné indique la precision (nombre de chiffre après la virgule) (setprecision)
        Console.WriteLine("|{0,-10}|{0,10}|{1,8}|{2,4:D2}|{3,12:F3}|", "Allo", 12, 2, 34.65657);
    }

    static void TestDeBase()
    {
        // en C#, Console va remplace cout et cin pour afficher à l'écran et lire du clavier
        // cout << "Hello World\n";
        Console.WriteLine("Hello World"); // WriteLine inclut le changement de ligne

        // Pour remplacer le system("pause");
        // Lire une touche du clavier
        Console.ReadKey(true); // Si l'argument donné est vrai, la touche lue n'est pas affiché dans la console

        // Au lieu de system("cls")
        Console.Clear();

        Console.WriteLine("Welcome to the Program Class");

        // Les types the vase sont identiques au C++
        int entier = 5;
        // En C#, il est impossible d'utiliser une variable non-initialisée
        Console.WriteLine(entier);
        double nombreReel = 25.25;
        char charactere = 'a';
        bool estvalide = true; // false
        string prenom = "Aelith";

        // cout << "L'entier est: " << entier << endl;
        Console.WriteLine("L'entier est : " + entier);
        Console.WriteLine("L'entier est: {0}, le reel est: {1}, le prénom est {2}. l'entier est toujours {0}", entier, nombreReel, prenom);

        // Les constantes sont identiques au C++
        const double Pi = 3.1415;

        string lecture;
        Console.Write("Entrez une chaine de charactères : ");
        // readline(cin, lecture)
        lecture = Console.ReadLine();
        Console.WriteLine(lecture);

        Calculer();

        // La syntaxe du for est identique au C++
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("This is spam.");
        }
        // Le while est aussi identique

        int v1 = 12;
        double v2 = 12.5;
        // étabt donné que le paramètre de la méthode sont des référence, il faut explicitement donner des références lors de l'appel
        ModifierValeurs(ref v1, ref v2);
        Console.WriteLine("v1 = " + v1 + ", v2 = " + v2);

        int valeur1;
        int valeur2;
        // Il n'est pas necessaire d'initialisé les variable lorsque qualifié avec out
        ObtenirValeurs(out valeur1, out valeur2);
    }

    static void ObtenirValeurs(out int valeur1, out int valeur2)
    {
        // Les paramètres sont considérés non-initialisés, et ne peuvent pas être utilisés tant qu'une valeur ne leut est pas assignée

        // Le 'out' oblige d'assigner des valeurs aux paramètres
        valeur1 = 246;
        valeur2 = 323;

    }

    static int Additionner(int nombre_1, int nombre_2)
    {
        return nombre_1 + nombre_2;
    }

    static void Calculer()
    {
        Console.WriteLine("Entrez un entier: ");
        string ligne = Console.ReadLine();
        // Équivalent à stoi
        int entier_1 = Convert.ToInt32(ligne);

        Console.Write("Entrez un operateur (+, -, *, /, %): ");
        string operateur = Console.ReadLine();

        Console.WriteLine("Entrez un autre entier: ");
        ligne = Console.ReadLine();
        // Équivalent à stoi
        int entier_2 = Convert.ToInt32(ligne);

        Console.Write("{0} {1} {2} = ", entier_1, operateur, entier_2);

        // En C#, on peut utiliser un switch avec une chaine de charactères
        switch (operateur)
        {
            case "+":
                Console.WriteLine(Additionner(entier_1, entier_2));
                break;
            case "-":
                Console.WriteLine(entier_1 - entier_2);
                break;
            case "*":
                Console.WriteLine(entier_1 * entier_2);
                break;
            // Il est possible de combiner des cases s'il n'y a pas de code
            case "/":
            case "%":
                // La syntaxe du if est identique au C++
                if (entier_2 == 0)
                {
                    Console.WriteLine("Division par 0 impossible");
                }
                else
                {
                    if (operateur == "/")
                    {
                        Console.WriteLine(entier_1 / entier_2);
                    }
                    else
                    {
                        Console.WriteLine(entier_1 % entier_2);
                    }
                }
                break;
            default:
                Console.WriteLine("Opérateur invalide");
                break;
        }
    }

    // En C++, pour passer des valeurs en référence, il faut utiliser &
    // En C#, il faur utiliser le mot=clé ref: ref in valeur
    static void ModifierValeurs(ref int valeur1, ref double valeur2)
    {
        valeur1 += 5;
        valeur2 *= 2;
    }
}