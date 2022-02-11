using System;
using System.IO;
using System.Net.Http;

namespace WordleKata
{
    public class WordService
    {
        /// <summary>
        /// Get's a random word from the words.json file
        /// </summary>
        /// <returns>A random five letter word as a string</returns>
        public string GetRandomWord()
        {
            string json = string.Empty;
            using (StreamReader r = new("words.json"))
            {
                json = r.ReadToEnd();
            }
            
            json = json.Replace("\"", "");
            json = json.Replace("[", "");
            json = json.Replace("]", "");
            
            var array = json.Split(",");
            return array[new Random().Next(0, array.Length)];
        }
    }
}