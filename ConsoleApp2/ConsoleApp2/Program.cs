using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program obj = new Program();
            // obj.sum();
            Program.sum();
            Console.ReadKey();

        }
        public static void sum()
        {
            int num1,num2;
            num1 = 100;
            num2 = 200;
            int add = num1 + num2;
            Console.Write("Addition :{0}", add);
        }
    }
}
