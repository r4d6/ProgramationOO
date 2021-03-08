using System;
using System.Text;

namespace IntroPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            SimulateurBanque simulateur = new SimulateurBanque();
            simulateur.Simuler();
            Pause();
        }

        static void Pause()
        {
            Console.WriteLine("Press a key to continue");
            Console.ReadKey(true);
            Console.Clear();
        }

        static void Test_Rectancle()
        {
            Rectangle r1 = new Rectangle();
            r1.Height = 10;
            r1.Length = 20;
            // Procedural way
            //Draw_Rectangle(r1);
            // OO Way
            r1.Draw();

            Console.WriteLine();
            Console.WriteLine();

            Rectangle r2 = new Rectangle();
            r2.Height = 20;
            r2.Length = 40;
            //Draw_Rectangle(r2);
            r2.Draw();
        }

        // Procedural Way
        /*
        static void Draw_Rectangle(Rectangle r)
        {
            for (int line = 0; line < r.Height; line++)
            {
                for (int column = 0; column < r.GetLength(); column++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }*/
    }
}
