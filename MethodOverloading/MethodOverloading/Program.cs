using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Sum of two integers is :{0}",sum(5,6));
            Console.WriteLine("Sum of two double is :{0}",sum(45.45,45.56));
            Console.WriteLine("Sum of two Strings is :{0}", sum("Hello ","Harsh"));
            Console.ReadKey();
        }
        public static double sum(double x, double y)
        {
            double add = x + y;
            return add;
        }
        public static int sum(int x, int y)
        {
            int add = x + y;
            return add;
        }
        public static string sum(string x, string y)
        {
            string add = x + y;
            return add;
        }
    }
}
