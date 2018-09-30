using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    static int getTotalX(int[] a, int[] b){
        int count = 0;
         for(int i=a.Min(); i<=b.Max();i++)
             if(a.All(x=> i%x == 0) && b.All(y=> y%i == 0))
                 count++; 
        return count;
    }

    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int m = Convert.ToInt32(tokens_n[1]);
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);
        string[] b_temp = Console.ReadLine().Split(' ');
        int[] b = Array.ConvertAll(b_temp,Int32.Parse);
        int total = getTotalX(a, b);
        Console.WriteLine(total);
    }
}
