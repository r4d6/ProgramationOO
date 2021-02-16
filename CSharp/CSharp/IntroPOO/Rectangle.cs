using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroPOO
{
    class Rectangle
    {
        // Builder
        public Rectangle()
        {
            Length = 4;
            Height = 2;
            Console.WriteLine("Default Rectangle Builder");
        }

        // Getter
        public int GetLength()
        {
            return _length;
        }

        public int GetHeight()
        {
            return _height;
        }

        // Setter
        public void SetLength(int value)
        {
            if (value > 0)
            {
                _length = value;
            }
        }

        public void SetHeight(int value)
        {
            if (value > 0)
            {
                _height = value;
            }
        }

        // Property
        // Used just like a value.

        public int Height // No ()
        {
            // Getter
            get
            {
                return _height;
            }

            // Setter
            set // Implicitly got 'int value'
            {
                if (value > 0)
                {
                    _height = value;
                }
            }
        }

        /*
        private string _name = "Rectangle";
        
        public string Name // No ()
        {
            // Getter
            get
            {
                return _name;
            }

            // Setter
            set 
            {
                _name = value;
            }
        }*/

        public void Draw()
        {
            for (int line = 0; line < Height; line++)
            {
                for (int column = 0; column < Length; column++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        // Automatic Property
        public string Name { get; set; } = "Rectangle";

        public int Length { get; set; } = 0;

        public int Color { get; private set; } = 15;

        private int _length = 0;
        private int _height = 0;


    }
}
