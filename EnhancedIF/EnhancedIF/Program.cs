using System;

namespace EnhancedIF
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp = -5;
            string stateOfMatter;
            if(temp < 0)
            {
                stateOfMatter = "Solid";
            }
            else
            {
                stateOfMatter = "Liquid";
            }
            Console.WriteLine("State of Matter is {0}" , stateOfMatter);
            stateOfMatter = temp < 0 ? "Solid " : "Liquid";

            Console.WriteLine("State of Matter is {0}", stateOfMatter);
            Console.Read();
        }
    }
}
