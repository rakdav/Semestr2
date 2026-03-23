using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    public static class MyExtension
    {
        public static int CountWord(this string s, char a)
        {
            int count = 0;
            foreach (char c in s)
            {
                if(c==a) count++;
            }
            return count;
        }
    }
}
