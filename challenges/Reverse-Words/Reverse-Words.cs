using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges.Reverse_Words
{
    public class Reverse_Words
    {
        public static string ReverseWords(string sentence)
        {
            string[] words = sentence.Split(' ');
            string[] result = new string[words.Length];
            int index = 0;

            for (int i = words.Length - 1; i >= 0; i--)
            {
                result[index] = words[i];
                index++;
            }

            return string.Join(" ", result);
        }
    }
}

