using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassongParametersAndReturningValues
{
    class PassingParameter
    {
        public static void Main()
        {
            int num1, num2;
            Console.WriteLine("Enter two integers :");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            PassingParameter obj = new PassingParameter();
            int add=obj.Sum(num1, num2);
            Console.WriteLine("Addition :{0}" , add);
            Console.ReadKey();
        }
        public int Sum(int a,int b)
        {
            int add = a + b;

            return add;
        }
      
    }
}
