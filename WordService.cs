using System;
using System.Net.Http;

namespace WordleKata
{
    public class WordService
    {
        private static readonly HttpClient _client = new();
        
        /// <summary>
        /// Get's a random word from the random-word-api
        /// </summary>
        /// <returns>A random five letter word as a string</returns>
        public string GetRandomWord()
        {
            var response = _client.GetStringAsync("https://random-word-api.herokuapp.com/all").Result;
            response = response.Replace("\"", "").Replace("[", "").Replace("]", "");
            var array = response.Split(",");
            return array[new Random().Next(0, array.Length)];
        }
    }
}