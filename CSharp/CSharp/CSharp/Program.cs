using System; // Use that to not have to put 'System.' in front of every command
using System.Text;
using System.IO;

namespace CSharp
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
            Console.Clear();
            Grep();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
            Console.Clear();
        }

        static void BaseTest()
        {
            Console.WriteLine("Hello everyone!");
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Welcome to Programmation Class.");
        }

        static void TestTableau()
        {
            int[] intTable = { 0, 1, 2, 3, 5, 7, 15 };
            intTable[0] = 1;
            Console.WriteLine("The table got {0} numbers.", intTable.Length);
            Console.WriteLine("The first number is {0}.", intTable[0]);
            Console.WriteLine("The last number is {0}.", intTable[intTable.Length - 1]);

            foreach (int number in intTable)
            {
                Console.WriteLine("Number : {0}", number);
            }
        }

        static void File()
        {
            string filename = "texte.txt";

            Console.WriteLine("File Writing starting");

            // File writing
            // Will create the file if it doesn't exist, will replace the file if it already exist
            // StreamWriter(filename, true) --> Will create the folder, but write at the end of it instead of replacing it.
            using (StreamWriter fileWrite = new StreamWriter(filename))
            {
                fileWrite.WriteLine("Some text to test");
                fileWrite.WriteLine("the writing in the file\n\n");
                fileWrite.Write("which could be ");
                fileWrite.WriteLine("read later on.");
            }
            Console.WriteLine("File Writing finished");
            Console.ReadKey();
            Console.WriteLine("File Reading starting");

            using (StreamReader fileRead = new StreamReader(filename))
            {
                // Read a line in the file, doesn't include the \n
                string line = fileRead.ReadLine();

                while (line != null)
                {
                    Console.WriteLine(line);
                    line = fileRead.ReadLine();
                }
            }
            Console.WriteLine("File Reading finished");
        }

        // --------------------------------------------------------------------------
        // EXERCICE 1

        // Recherche dans un fichier le texte donné par l'utilisateur
        // Affiche le numéro des lignes ainsi que les lignes contenant le texte donné
        // À la fin, affiche le nombre de lignes dans lesquelles le texte est trouvé
        //
        // Exemple:
        // --------
        // Entrez le texte à rechercher: notion
        //  9: Un langage de programmation offre un ensemble de notions qui peuvent etre
        // 12: qu'il y ait un minimum de notions qui peuvent etre combinees selon des
        // 41: ensemble de notions qui peuvent etre utilisees pour exprimer une solution
        //
        // Texte touvé dans 3 lignes
        // --------
        //
        // Recommence tant qu'une ligne non-vide est donnée
        static void Grep()
        {
            // TODO: Recommencer tant qu'une ligne non-vide est donnée
            string aChercher = null;
                Console.Write("Entrez le texte à rechercher: ");
                aChercher = Console.ReadLine();
            // Rechercher va afficher les lignes avec leur numéro dans lesquelles le texte est trouvé
            int nombreDeLignes = Rechercher(aChercher, "prog.txt");
            Console.WriteLine("\nTexte touvé dans {0} ligne{1}\n",
               nombreDeLignes, (nombreDeLignes > 1 ? "s" : ""));
        }

        // Recherche le texte donné dans le fichier portant le nom donné.
        // Affiche les lignes avec leur numéro dans lesquelles le texte est trouvé.
        // Retourne le nombre de lignes contenant le texte cherché.

        // TODO: Écrire la méthode "Rechercher"
        static int Rechercher(string toSearch, string fileName)
        {
            int count = 0;
            int lineCount = 0;
            using (StreamReader fileRead = new StreamReader(fileName))
            {
                // Read a line in the file, doesn't include the \n
                string line = fileRead.ReadLine();

                while (line != null)
                {
                    lineCount++;
                    if (line.Contains(toSearch))
                    {
                        Console.Write("Line Number ");
                        Console.Write(lineCount);
                        Console.Write(" : ");
                        Console.WriteLine(line);
                        count++;
                    }
                    line = fileRead.ReadLine();
                }
                return count;
            }
        }
        
        
        #region Exercice 2
        // --------------------------------------------------------------------------
        // EXERCICE 2

        // Lit un fichier contenant du code C# (.cs)
        // Crée un nouveau fichier en ajoutant "SansCommentaires" au nom donné.
        // (Par exemple, si le nom du fichier donné est "Program.cs", le fichier
        //  créé sera "ProgramSansCommentaires.cs")
        // Copie le contenu du fichier donné dans le nouveau fichier, sans inclure:
        //  - les commentaires (ne tient compte que des //, ne supporte pas les /**/)
        //  - les lignes vides ou ne contenant que des espaces
        static void EnleverLignesVidesEtCommentaires(string nomDuFichier)
        {
        }
        #endregion
        /*
        #region Exercice 3
        // --------------------------------------------------------------------------
        // EXERCICE 3

        // Affiche la lettre la plus fréquente dans le fichier donné
        // ainsi que le nombre d'occurences ce celle-ci.
        // Ne fait pas de différence entre lettres minuscules et majuscules.
        // Si plusieurs lettres sont ex aequo, l'une d'entre elles est affichée.
        //
        // Exemple:
        // --------
        // Lettre la plus fréquente de prog.txt: e = 488
        static void TrouverLettrePlusFrequente(string nomFichier)
        {
            char lettre;
            int frequence;
            CompterLettres(nomFichier, lettre, frequence);
            Console.WriteLine("Lettre la plus fréquente de {0}: {1} = {2}", nomFichier, lettre, frequence);
        }

        // Compte les lettres dans le fichier donné pour trouver la plus fréquente.
        // Ne fait pas de différence entre lettres minuscules et majuscules

        // TODO: Écrire la méthode "CompterLettres"
        #endregion
        */
    }
}
