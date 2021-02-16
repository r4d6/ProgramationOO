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

      Console.Write("Entrez le texte à rechercher: ");
      string aChercher = Console.ReadLine();
      // Rechercher va afficher les lignes avec leur numéro dans lesquelles le texte est trouvé
      int nombreDeLignes = Rechercher(aChercher, "prog.txt");
      Console.WriteLine("\nTexte touvé dans {0} ligne{1}\n",
         nombreDeLignes, (nombreDeLignes > 1 ? "s" : ""));
   }

   // Recherche le texte donné dans le fichier portant le nom donné.
   // Affiche les lignes avec leur numéro dans lesquelles le texte est trouvé.
   // Retourne le nombre de lignes contenant le texte cherché.

   // TODO: Écrire la méthode "Rechercher"




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
