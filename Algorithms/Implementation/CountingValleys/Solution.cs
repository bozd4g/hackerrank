using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static int countingValleys(int n, string s)
    {
        int valleys = 0;
        int level = 0;
        bool neg = false;

        for (int i = 0; i < n; i++)
        {
            if (s[i] == 'U')
            {
                level++;
                if (level >= 0 && neg == true)
                    neg = false;
            }
            else
            {
                level--;
                if (level < 0 && neg == false)
                {
                    neg = true;
                    valleys++;
                }
            }

        }
        return valleys;
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string s = Console.ReadLine();
        int result = countingValleys(n, s);
        Console.WriteLine(result);
    }
}
