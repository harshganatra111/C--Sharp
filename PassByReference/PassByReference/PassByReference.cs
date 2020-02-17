using System;

namespace PassByReference
{
    class PassByReference
    {
        public static void Main()
        {
            string[] ARR = new string[2];
            ARR[0] = "Harsh";
            ARR[1] = "Ganatra";
            //ArrayMethod(ARR);
            ArrayMethod("Harsh", "Ganatra");
           /* int a = 10, b = 20;
            int sum = 0;
            int prod = 0;
            MyFunction(a, b, out sum, out prod);
            Console.WriteLine("Sum :{0} and Product :{1}",sum,prod);*/
            Console.ReadKey();
        }
        public static void ArrayMethod(params String[] names)
        {
            foreach(string name in names)
            {
                Console.WriteLine(name);

            }
            Console.WriteLine("Array Length :{0}", names.Length);
           /* sum = x + y;
            prod = x * y;*/
            
        }
    }
}
