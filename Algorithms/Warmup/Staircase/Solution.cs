using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        
        for(int i=n-1;i>=0;i--)
        {
            Console.Write(new string(' ', i));
            Console.WriteLine(new string('#', n-i));
            
        }
    }
}
