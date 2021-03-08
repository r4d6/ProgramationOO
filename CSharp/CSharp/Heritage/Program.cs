using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class Program
    {
        static void Main()
        {
            Enseignant Aelita = new Enseignant("Aelita", "Aether", 20, 1024, "Programmation");
            Aelita.SayInfoProf();

            Chauffeur Kira = new Chauffeur("Kira", "Doe", 21, 420, "Bus");
            Kira.DireInfo();

            Pause();
        }

        static void Pause()
        {
            Console.WriteLine("Press a key to continue");
            Console.ReadKey(true);
            Console.Clear();
        }
    }
}
