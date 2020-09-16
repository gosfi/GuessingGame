using System;
using System.Security.Cryptography;

namespace Guessing_game
{
    class Program
    {
        public static void RandomNumber()
        {
            Random rand = new Random();
            int tries = 5;
            int menu = 1;
            int guess = 0;
            int randomNum = rand.Next(1, 150);
            Console.WriteLine("Welcome to the number guessing game!");


            while (menu != 0)
            {
                tries = 5;
                while (tries != 0)
                {
                    Console.WriteLine("the number your looking for is between 1 and 150");
                    Console.WriteLine($"you have {tries} guesses left");
                    Console.Write("type your guess here : ");

                    guess = Convert.ToInt32(Console.ReadLine());

                    if (guess == randomNum)
                    {
                        Console.WriteLine("Good job, you found the number");
                        Console.Write("Would you like to play again? type 1 for yes and 0 for no: ");
                        tries = 0;
                        menu = Convert.ToInt32(Console.ReadLine());
                    }
                    else if (guess < randomNum)
                    {
                        Console.WriteLine("the number is higher");
                        tries--;
                    }
                    else if (guess > randomNum)
                    {
                        Console.WriteLine("the number is lower");
                        tries--;
                    }
                }
                if (tries == 0)
                {
                    Console.WriteLine($"oh no! you lost, your number was {randomNum}");
                    Console.Write("Would you like to play again? type 1 for yes and 0 for no: ");
                    menu = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        static void Main(string[] args)
        {
            RandomNumber();
        }
    }
}
