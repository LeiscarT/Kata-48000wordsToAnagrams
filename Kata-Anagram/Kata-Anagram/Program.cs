using System;
using System.Diagnostics;
using System.IO;

namespace Kata_Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            FileManager file = new FileManager(args[0]);
            FileManager diccionary = new FileManager(file.getArray());
            Anagrams anagram = new Anagrams(diccionary);

            TextWriter sw = new StreamWriter(Console.OpenStandardOutput());
            Console.SetOut(sw);
            anagram.Print(sw);
            timer.Stop();


            Console.WriteLine();
            Console.WriteLine($"Cantidad de tiempo: {timer.Elapsed}");
            Console.WriteLine($"Cantidad de palabras en este archivo: {file.get_array().Length}");
            Console.WriteLine($"Cantidad de sets de anagramas: {anagram.anagrams_sets_quantity}");
            Console.WriteLine($"Cantidad de palabras con anagramas: {anagram.anagram_words_count}");

            Console.WriteLine($"Set de anagramas con mas palabras: {string.Join(", ", anagram.longests_set)} \nTamano: {anagram.longests_set.Count}");
            Console.WriteLine($"Set de anagramas con palabras mas largas: {string.Join(", ", anagram.longests_words)} \nTamano: {anagram.longest_key.Length}");

            sw.Flush();
            Console.ReadKey();
        }
    }
}
