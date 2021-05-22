using Kata_Anagram;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestProject1
{
    public class AnagramTest
    {
       

        [Test]
        public void AnagramTest_Anagrams_isEmpty()
        {
            Anagrams anagrams = new Anagrams();
            Dictionary<string, List<string>> expected = new Dictionary<string, List<string>>();
            Assert.AreEqual(expected, anagrams);

        }
    }
}