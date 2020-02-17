using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a number");
            string userInput = Console.ReadLine();

            try
            {

                int userInputAsInt = int.Parse(userInput);
            }
            catch (Exception)
            {
                Console.WriteLine("Exception occured");
                
            }

            Console.ReadKey();
        }
    }
}
