using System; // Use that to not have to put 'System.' in front of every command

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
            Console.Clear();
            BaseTest();
        }

        static void BaseTest()
        {
            Console.WriteLine("Hello everyone!");
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Welcome to Programmation Class.");
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
