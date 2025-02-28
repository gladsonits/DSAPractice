using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice
{
    class PalindromeExercise
    {
        public bool IsPalindrome(string _text)
        {
            int len = _text.Length-1;

            int i = 0;

            while (i <= len)
            {
                if (_text[i] != _text[len])
                {
                    return false;
                }
                i++;
                len--;
            }
            return true;
        }
    }
}
