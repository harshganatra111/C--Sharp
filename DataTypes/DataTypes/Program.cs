using System;

namespace DataTypes
{
    class Program
    {

        static void Main(string[] args)
        {
            int num1=13;
            int num2 = 15;
            Console.WriteLine("Num 1 = " + num1 + "Num 2 = " + num2);
            Console.WriteLine("Sum = "  + (num1 + num2));
            
            //Single Line Comment
            /*Multi 
             Line
             Comments
              */
            String name = "Harsh";
            String msg = "My Name is " + name;
            Console.WriteLine(msg);
            String lMsg = msg.ToLower();
            Console.WriteLine(lMsg);
            Console.Read();
        }

    }
}
