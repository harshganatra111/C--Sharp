using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class drawing
    {
        public void Draw()
        {
            Console.WriteLine("this is a generic drawing object");
        }
       
    }
        public class line : drawing
        {
            public void Draw()
            {
                Console.WriteLine("this is a line");
            }
        }
        public class circle : drawing
        {
            public void Draw()
            {
                Console.WriteLine("this is a Circle");
            }
        }
        public class square : drawing
        {
            public void Draw()
            {
                Console.WriteLine("this is a Square");
            }
        }


        class Polymorphism
    { 
        public static void main()
        {
                drawing[] obj = new drawing[3];
                obj[0] = new line();
                obj[1] = new circle();
                obj[2] = new square();

                foreach(drawing draw in obj)
                {
                    draw.Draw();
                }

            Console.ReadKey();

        }
    }
}
