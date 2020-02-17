using System;

namespace MethodReturn
{
    class Program
    {
        static void Main(string[] args)
        {
           int result =  Add(10 , 15);
            Console.WriteLine(result);
            Console.WriteLine(Add(1, 2));

            Console.Read();
        }
        public static int Add(int n1, int n2)
        {
            int sum = n1 + n2;
            return sum;
        }
        public static int Multi(int num1,int num2)
        {
            int mul = num1 * num2;
            return mul;
        }
    }
}
