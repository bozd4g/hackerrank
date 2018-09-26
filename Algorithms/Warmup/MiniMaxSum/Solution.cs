using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    static void Main(String[] args) {
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        
        int n=arr.Length;
        long sum = 0;
        List<long> lst = new List<long>();
        for(int i=0;i<arr.Length;i++)
        {
            lst.Add(arr[i]);
            sum += arr[i];
        }
        
        lst.Sort();
        
        long max=lst[0];
        long min=lst[lst.Count-1];
        
        Console.Write((sum - min) + " " + (sum - max));
    }
}
