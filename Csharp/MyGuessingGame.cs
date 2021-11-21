using System;
using System.Threading;


namespace FreeCodeCampCourseCsharp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("The Guessing game");
            Console.Write("Enter the Secret word : ");
            string secretWord = Console.ReadLine();
            Console.Write("Enter your hint :");
            string hint = Console.ReadLine();
            Console.Clear();
            Thread.Sleep(500);
            Console.WriteLine("___*The Guessing game*___");
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;
            while (guess != secretWord && !outOfGuesses)
            {

                if (guess != secretWord)
                {
                    if (guessCount < guessLimit)
                    {
                        Console.WriteLine($"Hint: {hint}");
                        Console.Write("Enter guess: ");
                        guess = Console.ReadLine();

                        guessCount++;
                    }
                    else
                    {
                        outOfGuesses = true;

                    }
                    Console.WriteLine("Your Guess is incorrect :(");
                }
                
                                
            }
            if (outOfGuesses)
            {
                Console.WriteLine("You lose ! :(");
                Console.WriteLine($"The Secret Word is {secretWord}");
            }
            else
            {
                Console.WriteLine("You win! :)");
            }

        }

    }

}
