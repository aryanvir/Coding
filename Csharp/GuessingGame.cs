using System;
using System.Threading.Tasks;


namespace FreeCodeCampCourseCsharp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("The Guessing game");
            string secretWord = "Aryan";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;
            while (guess != secretWord && !outOfGuesses )
            {
                if (guessCount < guessLimit)
                {
                    Console.WriteLine("Your Guess is incorrect");
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                    
                }
                
            }
            if (outOfGuesses)
            {
                Console.Write("You lose !");
            }
            else
            {
                Console.WriteLine("You win !");
            }
            
        }

    }              
    
}
