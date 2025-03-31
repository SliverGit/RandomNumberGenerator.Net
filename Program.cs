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

                Console.Write("How many numbers would you like to generate? ");
                int count = Convert.ToInt32(Console.ReadLine());

                Random random = new Random();
                
                Console.WriteLine($"Random Numbers:");

                for (int i = 0; i < count; i++)
                {
                    int randomNumber = random.Next(lowerBound, upperBound + 1);
                    Console.Write(randomNumber);

                    if (i < count - 1)
                    {
                        Console.Write(", ");
                    }
                }

                Console.WriteLine("\n\nDo you want to generate more numbers? (yes/no): ");
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
