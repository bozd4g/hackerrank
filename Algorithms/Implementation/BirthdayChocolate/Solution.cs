using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    static int getWays(int[] squares, int d, int m)
    {
        int ways = 0;
        for (int i = 0; i < squares.Length - (m - 1); i++)
            if (squares.Skip(i).Take(m).Sum() == d) ways++;
        return ways;
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] s_temp = Console.ReadLine().Split(' ');
        int[] s = Array.ConvertAll(s_temp, Int32.Parse);
        string[] tokens_d = Console.ReadLine().Split(' ');
        int d = Convert.ToInt32(tokens_d[0]);
        int m = Convert.ToInt32(tokens_d[1]);
        int result = getWays(s, d, m);
        Console.WriteLine(result);
    }
}
