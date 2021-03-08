using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class Person
    {
        public Person ()
        {
            FirstName = "Aelita";
            LastName = "Aether";
            Age = 18;
            Console.WriteLine("Constructeur de Aelita.");
        }

        public Person(string firstname, string lastname, int age)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;


            Console.WriteLine("Constructeur par defaut de Person.");
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public void SayHello()
        {
            Console.WriteLine("Hi, I am {0} {1} and I am {2} years old.", FirstName, LastName, Age);
        }

        // private doesn't allow other classes to inherit it, while protected does.
        private string NumeroAssurance { get; set; }
        protected string Adress { get; set; }
    }

    class Student : Person
    {
        public Student (string first, string last, int age, string matricule) : base(first, last, age)
        {
            Matricule = matricule;
        }

        public string Matricule { get; set; }
    }

    class Employe : Person 
    {
        public Employe()
        {
            Console.WriteLine("Constructeur par defaut d'employe.");
            NumeroEmployer = 999;
        }

        public Employe(string firstname, string lastname, int age, int num) : base(firstname, lastname, age)
        {
            NumeroEmployer = num;
            Console.WriteLine("Constructeur par defaut d'employe.");
        }

        public void DireInfo()
        {
            SayHello();
            Console.WriteLine("My number is {0}.", NumeroEmployer);
        }

        public int NumeroEmployer { get; protected set; }

    }

    class Enseignant : Employe
    {
        public Enseignant()
        {
            Console.WriteLine("Constructeur par defaut d'enseignant.");
            _class = "Programmation";
        }

        public Enseignant(string firstname, string lastname, int age, int num, string cours) : base(firstname, lastname, age, num) // Appele Employe
        {
            _class = cours;
            Console.WriteLine("Constructeur par defaut d'enseignant.");
        }

        public void SayInfoProf()
        {
            DireInfo();
            Console.WriteLine("I teach {0}", _class);
        }

        private string _class;
    }

    class Chauffeur : Employe
    {
        public Chauffeur()
        {

            Console.WriteLine("Constructeur par defaut de chauffeur.");
        }

        public Chauffeur(string firstname, string lastname, int age, int num, string vehicule) : base(firstname, lastname, age, num) // Appele Employe
        {
            Vehicule = vehicule;
            Console.WriteLine("Constructeur par defaut de chauffeur.");
        }

        public void SayInfoDriver()
        {
            DireInfo();
            Console.WriteLine("I drive a {0}.", Vehicule);
        }

        public string Vehicule { get; set;}
    }
}
