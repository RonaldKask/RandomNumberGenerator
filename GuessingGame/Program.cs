using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 11);
            Console.WriteLine("What is my number?");
            int userGuess = Int32.Parse(Console.ReadLine());
            bool correctGuess = false;

            while(!correctGuess)
            {
                if(randomNumber == userGuess)
                {
                    Console.WriteLine("You won!");
                    correctGuess = true;
                }else
                {
                    if (userGuess > randomNumber)
                    {
                        Console.WriteLine("My number is smaller.");
                        userGuess = Int32.Parse(Console.ReadLine());
                    }else
                    {
                        Console.WriteLine("My number is bigger.");
                    }
                }
            }

        }
    }
}
