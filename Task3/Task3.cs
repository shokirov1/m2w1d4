using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2w1d4.Task3
{
    public class Task3
    {
        public bool Palindrome(string s1)
        {
            string s2 = string.Concat(s1.Reverse());
            if (s1 == s2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
