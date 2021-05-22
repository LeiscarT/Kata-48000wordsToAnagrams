using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_Anagram
{

  
   public class Anagrams
    {
        private Dictionary<string, List<string>> anagrams = new Dictionary<string, List<string>>();
        private Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();
    


        public Anagrams()
        {
          
        }

        private void sort(string[] lines)
        {
            for (int i = 0; i < lines.Length; i++)
            {
                string word = lines[i].ToLower();
                char[] letter = word.ToCharArray();
                Array.Sort(letter);

                string sorted_word = new string(letter);

                if (words.ContainsKey(sorted_word))
                {
                    if (!words[sorted_word].Contains(word))
                    {
                        words[sorted_word].Add(word);
                    }

                    if (words[sorted_word].Contains(word))
                    {
                        anagrams[sorted_word] = words[sorted_word];
                    }
                }
                else
                {
                    words.Add(word, new List<string>());
                    words[sorted_word].Add(word);
                }

            }
        }


      

    }
}
