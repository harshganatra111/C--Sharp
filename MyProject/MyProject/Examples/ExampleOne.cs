using System;


namespace MyProject.Examples
{
    class ExampleOne
    {
        static void Main()
        {
           /* Console.Write("Enter Number One :");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Number two :");
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 + num2;
            Console.Write("The Sum of two Numbers is : {0}", sum);*/
           Console.Write("Please Enter Name 1 : ");
            string name1 = Console.ReadLine();
            Console.Write("Please Enter Name 2 : ");
            string name2 = Console.ReadLine();
            //string name = "This is c#";
            //Console.Write("Hello " + name1 +" and " + name2);
            Console.Write("Hello {0} and {1}",name1,name2);
            Console.ReadKey();
        }
    }
}
