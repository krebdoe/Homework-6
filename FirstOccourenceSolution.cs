﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstOccourence
{
    public class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            if (needle.Length == 0)
            {
                return 0;
            }

            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                int j = 0;
                while (j < needle.Length && haystack[i + j] == needle[j])
                {
                    j++;

                }
                if (j == needle.Length)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
