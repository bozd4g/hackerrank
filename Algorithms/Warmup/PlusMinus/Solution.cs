using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        
        int pos=0;
        int neg=0;
        int zero = 0;
        for(int i=0;i<n;i++)
        {
            if(arr[i] > 0)
                pos++;
            else if(arr[i] < 0)
                neg++;
            else
                zero++;
        }
        
        Console.WriteLine(pos/(double)n);
        Console.WriteLine(neg/(double)n);
        Console.WriteLine(zero/(double)n);
    }
}
