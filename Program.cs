using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;

namespace WordleKata
{
    class Program
    {
        private static readonly HttpClient _client = new();
        
        static void Main()
        {
            var wordToGuess = GetRandomWord();
            Console.WriteLine("You've been given a random 5 letter word! You have five guesses to get it right!");
            var guess = Console.ReadLine();
            while (guess != wordToGuess)
            {
                Console.WriteLine("Oops! That wasn't right, guess again! You have four tries left!");
                guess = Console.ReadLine();
            }
            Console.WriteLine($"Well done, you got it right! The word was {wordToGuess}!");
        }

        private static string GetRandomWord()
        {
            var response = _client.GetStringAsync("https://random-word-api.herokuapp.com/all").Result;
            response = response.Replace("\"", "").Replace("[", "").Replace("]", "");
            var array = response.Split(",");
            return array[new Random().Next(0, array.Length)];
        }
    }
}