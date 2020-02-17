using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjects
{
    class Box
    {
        public double length, height, breadth;
        public double Volume()
        {
            return (this.length * this.breadth * this.height);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Box obj = new Box();
            Console.WriteLine("Enter Length : ");
            obj.length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter breadth : ");
            obj.breadth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Height : ");
            obj.height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Volume :{0}",obj.Volume());
            Console.ReadKey();
        }
    }
}