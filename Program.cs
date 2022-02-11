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
        
        static void Main()
        {
            var wordToGuess = _wordService.GetRandomWord();
            Console.WriteLine("You've been given a random 5 letter word! You have five guesses to get it right!");
            var guess = Console.ReadLine();
            while (guess != wordToGuess)
            {
                Console.WriteLine("Oops! That wasn't right, guess again! You have four tries left!");
                guess = Console.ReadLine();
            }
            Console.WriteLine($"Well done, you got it right! The word was {wordToGuess}!");
        }
    }
}