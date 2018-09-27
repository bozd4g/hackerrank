using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    static string kangaroo(int x1, int v1, int x2, int v2) {
        // Complete this function
        string status = "NO";
        if((x1>x2 && v1 >v2) || (x1<x2 && v1<v2))
            status = "NO";
        else
        {
            for(int i=0;i<10000;i++) 
                if(x1 + v1 + (i*v1) == x2 + v2 + (i*v2))
                {
                    status = "YES";
                    break;
                }
        }
        
        return status;
    }

    static void Main(String[] args) {
        string[] tokens_x1 = Console.ReadLine().Split(' ');
        int x1 = Convert.ToInt32(tokens_x1[0]);
        int v1 = Convert.ToInt32(tokens_x1[1]);
        int x2 = Convert.ToInt32(tokens_x1[2]);
        int v2 = Convert.ToInt32(tokens_x1[3]);
        string result = kangaroo(x1, v1, x2, v2);
        Console.WriteLine(result);
    }
}
