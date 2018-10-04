using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    static void bonAppetit(int n, int k, int b, int[] ar) {
        int total = 0;
        for(int i=0;i<n;i++)
        {
            if(i == k)
                continue;
            total+=ar[i];
        }
        
        if(b-total/2 == 0)
            Console.WriteLine("Bon Appetit");
        else
            Console.WriteLine(b-(total/2));
    }

    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp,Int32.Parse);
        int b = Convert.ToInt32(Console.ReadLine());
        bonAppetit(n, k, b, ar);
    }
}
