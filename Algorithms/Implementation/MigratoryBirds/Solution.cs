using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    static int migratoryBirds(int n, int[] ar) {
        int[] birdsCount = new int[5];
        int max = 0;
        int index = 0;

        for (int i = 0; i < n; i++)
            birdsCount[ar[i] - 1]++;

        for (int i = 0; i < 5; i++)
            if (birdsCount[i] > max)
            {
                max = birdsCount[i];
                index = i + 1;
            }
        return index;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp,Int32.Parse);
        int result = migratoryBirds(n, ar);
        Console.WriteLine(result);
    }
}
