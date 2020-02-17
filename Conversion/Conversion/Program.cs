using System;

namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double myDouble = 13.7;
            int myInt;
            myInt = (int)myDouble;
            string s = myInt.ToString();
            Console.WriteLine(s);
            Console.Read();
        }
    }
}
