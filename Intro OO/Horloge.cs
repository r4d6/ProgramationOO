using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_OO
{
    class Horloge
    {
        public Horloge(int Heures)
        {
            if (Heures < 24 && Heures >= 0)
            {
                _secondes += Heures * 3600;
            }
        }

        public Horloge(int Heures, int Minutes)
        {
            if (Heures < 24 && Heures >= 0)
            {
                _secondes += Heures * 3600;
            }

            if (Minutes < 60 && Minutes >= 0)
            {
                _secondes += Minutes * 60;
            }
        }

        public Horloge(int Heures, int Minutes, int Secondes)
        {
            if (Heures < 24 && Heures >= 0)
            {
                _secondes += Heures * 3600;
            }

            if (Minutes < 60 && Minutes >= 0)
            {
                _secondes += Minutes * 60;
            }

            if (Secondes < 60 && Secondes >= 0)
            {
                _secondes += Secondes;
            }
        }

        public int Heures
        {
            get { return (_secondes / 3600); }
        }

        public int Minutes
        {
            get { return ((_secondes % 3600) / 60); }
        }

        public int Secondes
        {
            get { return ((_secondes % 3600) % 60); }
        }

        public void Afficher()
        {
            Console.WriteLine(Heures + ":" + Minutes + ":" + Secondes);
        }

        public bool EstEgaleA(Horloge hX)
        {
            if (_secondes == hX._secondes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private int _secondes = 0;
    }
}
