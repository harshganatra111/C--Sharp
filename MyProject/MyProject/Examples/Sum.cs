using System;


namespace MyProject.Examples
{
    class Sum
    { 
        static void Main()
        {
            Console.Write("Enter Number One :");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Number two :");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("The Sum of two Numbers is :" + num1 + num2);

        }
    }
}
