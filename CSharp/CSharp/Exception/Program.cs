using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            TestExceptions();
            Pause();
        }

        static void Pause()
        {
            Console.WriteLine("Press a key to continue");
            Console.ReadKey(true);
            Console.Clear();
        }

        static void TestExceptions()
        {
            int[] tableau = { 1, 2, 4, 8, 16 };

            bool error = true;
            while (error)
            {
                try
                {
                    Console.Write("Entrer un index du tableau : ");
                    int Index = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Given index : {0}", Index);
                    Console.WriteLine("Index {0} du tableau : {1}", Index, tableau[Index]);
                    Console.WriteLine("Division de la valeur du tableau par l'index : " + tableau[Index] / Index);
                    error = false;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("This is not a number.");
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine("Index is too big, it goes from 0 to 4.");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Impossible to divide by 0.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("There was an error of type {0} : {1}", ex.GetType(), ex.Message);
                }
            }
            Console.WriteLine("Execution continue after a Try/Catch");
        }
    }
}
