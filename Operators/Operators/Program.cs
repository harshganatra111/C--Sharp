using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;
            //unary operators
            num3 = -num1;
            Console.WriteLine(num3);
            bool isSunny = true;
            Console.WriteLine("is it sunny ? {0}",!isSunny);
            int num = 0;
            num++;
            Console.WriteLine(num);
            Console.Read();
        }
    }
}
