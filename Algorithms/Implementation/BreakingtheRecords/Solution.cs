using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {
    static string getRecord(int[] s, int n){
        
        int min = s[0];
        int max = s[0];
        
        int mostCount=0;
        int leastCount=0;
        
        for(int i=0;i<s.Length;i++) 
        {
            if(s[i] < min)
            {
                leastCount++;
                min = s[i];
            }
            else if(s[i] > max)
            {
                mostCount++;
                max = s[i];
            }
                
        }
        
        return (mostCount + " " + leastCount);
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] s_temp = Console.ReadLine().Split(' ');
        int[] s = Array.ConvertAll(s_temp,Int32.Parse);
        string result = getRecord(s, n);
        Console.WriteLine(result);
    }
}
