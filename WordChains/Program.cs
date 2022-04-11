using System;
using System.Collections.Generic;

namespace WordChains
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert the start word:");
            var startWord = Console.ReadLine();

            Console.WriteLine("Please insert the end word:");
            var endWord = Console.ReadLine();

            Console.WriteLine("\nNow we are looking for a word chain from {0} to {1}:\n", startWord, endWord);

            var wordList = WordChains.GetListWithNCharacters("C:\\Users\\franc\\source\\repos\\CodeKatas\\WordChains\\wordlist.txt", startWord.Length);


        }



        public class WordChains
        {


            public static List<string> GetListWithNCharacters(string path, int nCharacter)
            {

                var result = new List<string>();

                string[] lines = System.IO.File.ReadAllLines(path);

                foreach (string line in lines)
                {
                    if (line.Length == nCharacter)
                    {
                        result.Add(line);
                    }
                }

                return result;

            }


            public static List<string> GetPossibleWords(List<string> input, string startWord) {

                var result = new List<string>();



                return result;

            }


            public static bool IsSimilar(string wordA, string wordB) {

                var countSimilar = 0;

                for (var i = 0; i <wordA.Length; i++) {
                    if (wordA[i] == wordB[i]) {
                        countSimilar++;
                    }
                }

                if (countSimilar == wordA.Length - 1) {
                    return true;
                }

                return false;


            }






        }

    }
}
