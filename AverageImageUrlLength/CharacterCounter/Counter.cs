using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace AverageImageUrlLength.CharacterCounter
{
    internal class Counter
    {
        public int CharCount { get; set; }
        public int StringCount { get; set; }

        public string CountCharacters(string countChars)
        {
            foreach (var obj in countChars)
            {
                CharCount++;
            }
            return $"Number of characters in string(s): {CharCount}";
        }

        public int NumberOfCharacters(string countChars)
        {
            foreach (var obj in countChars)
            {
                CharCount++;
            }
            return CharCount;
}
    }
}

