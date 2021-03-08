using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class Person
    {
        public Person(string firstname, string lastname, int age)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
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
}
