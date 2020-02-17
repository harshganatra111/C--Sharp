using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Polygon
    {
        public Polygon()
        {
            Console.WriteLine("We are in base class");
        }
        public int width, height;
        public void SetValues(int h,int w)
        {
            this.height = h;
            this.width = w;
            
        }
    }
    class Rectangle : Polygon
    {
        public int area()
        {
            return width * height;
        }
    }
    class Triangle : Polygon
    {
        public int area()
        {
            return width * height/2;
        }
    }
    class Inheritance
    {
        public static void Main()
        {

            Rectangle rect = new Rectangle();
            Triangle tri = new Triangle();
            rect.SetValues(10, 20);
            tri.SetValues(10, 20);
            Console.WriteLine("Area of Rectangle :{0}", rect.area());
            Console.WriteLine("Area of Triangle :{0}", tri.area());
            Console.ReadKey();

        }
    }
}