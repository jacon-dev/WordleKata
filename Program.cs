using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text.Json;

namespace WordleKata
{
    class Program
    {
        private static readonly WordService _wordService = new();
        
        /// <summary>
        /// Main entry point for the game. Runs off the command line and reads input.
        /// </summary>
        static void Main()
        {
            var currentGameStats = new CurrentGameStats();
            var wordToGuess = _wordService.GetRandomWord();
            Console.WriteLine("You've been given a random 5 letter word! You have six guesses to get it right!");
            var guess = Console.ReadLine();
            while (guess != wordToGuess && currentGameStats.Attempts > 0)
            {
                currentGameStats.ReduceAttempts();
                Console.WriteLine("You guessed {guess}");
                Console.WriteLine(".....");
                Console.WriteLine("Oops! That wasn't right, guess again! You have four tries left!");
                guess = Console.ReadLine();
            }
            Console.WriteLine("You guessed {guess}");
            Console.WriteLine("AAAAA");
            Console.WriteLine("Well done, you got it right! The word was {wordToGuess}!");
        }
    }

    public class CurrentGameStats
    {
        public int Attempts { get; private set; }

        public void ReduceAttempts()
        {
            Attempts -= 1;
        }
    }
}