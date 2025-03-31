using System;

namespace RandomNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Random Number Generator");
            
            while (true)
            {
                Console.Write("Enter the lower bound of your range: ");
                int lowerBound = Convert.ToInt32(Console.ReadLine());
                
                Console.Write("Enter the upper bound of your range: ");
                int upperBound = Convert.ToInt32(Console.ReadLine());

                Random random = new Random();
                int randomNumber = random.Next(lowerBound, upperBound + 1);
                Console.WriteLine($"Random Number: {randomNumber}");

                Console.Write("\nDo you want to generate another number? (yes/no): ");
                string userResponse = Console.ReadLine().Trim().ToLower();

                if (userResponse != "yes")
                {
                    break;
                }
            }

            Console.WriteLine("Exiting the program. Goodbye!");
        }
    }
}
