using System;

namespace IntroPOO
{
   /// <summary>
   /// Une banque contient 5 comptes bancaires et permet d'effectuer des opérations sur les comptes
   /// </summary>
   class Banque
   {


      private const int NbComptes = 5;

      // Un tableau de 5 comptes bancaires.
      // Notez que le tableau est vide et que les comptes ne sont pas initialisés.
      // Dans le constructeur, il sera nécessaire de créer chaque objet contenu dans le tableau:
      //   _comptes[0] = new CompteBancaire(...);
      //   ...
      //   _comptes[4] = new CompteBancaire(...);
      private CompteBancaire[] _comptes = new CompteBancaire[NbComptes];
   }
}
