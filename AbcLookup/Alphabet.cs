using System;
using System.Collections.Generic;
using System.Linq;

namespace AbcLookup
{
    public class Alphabet
    {
        private static readonly List<char> AbcList = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray().ToList();

		//Is used to get the next character in the alphabet
        public static char GetNext(char input)
        {
            var i = AbcList.IndexOf(input) + 1;
            return AbcList[i];
        }
        
        //Is used to get the previous character in the alphabet
        public static char GetPrevious(char input)
        {
            var i = AbcList.IndexOf(input) - 1;
            return AbcList[i];
        }

        public static IList<char> GetVowels()
        {    
            return "AEIOU".ToCharArray().ToList();
        }
        
    }
}