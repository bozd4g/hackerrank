using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    static int solve(int n, int p){
        int count = 0;
        
        if(n-p == 1 && (n%2) == 0 && n>2)
            return 1;
        
        if(n-p < 2 || p<2)
            return 0;
        
        if(p > n/2)
            for(int i=p;i<n-1;i+=2)
                count++;
        else
            for(int i=p;i>1;i-=2)
                count++;
                
        return count;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int p = Convert.ToInt32(Console.ReadLine());
        int result = solve(n, p);
        Console.WriteLine(result);
    }
}
