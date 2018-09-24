using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    static int simpleArraySum(int n, int[] ar) {
        int result = 0;
        do{
            result += ar[n-1];
            n--;
        }
        while(n!=0);
        return result;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp,Int32.Parse);
        int result = simpleArraySum(n, ar);
        Console.WriteLine(result);
    }
}
