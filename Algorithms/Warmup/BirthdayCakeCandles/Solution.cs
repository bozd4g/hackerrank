using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int birthdayCakeCandles(int n, int[] ar) {
        List<int> lst = new List<int>();
        for(int i=0;i<n;i++)
            lst.Add(ar[i]);
        
        lst.Sort();
        Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < lst.Count; i++)
            {
                if (!dic.ContainsKey(lst[i]))
                    dic.Add(lst[i], 1);
                else
                    dic[lst[i]]++;
            }

            var max = dic.OrderByDescending(x => x.Value).Take(1).ToList();
        
        return max[0].Value;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp,Int32.Parse);
        int result = birthdayCakeCandles(n, ar);
        Console.WriteLine(result);
    }
}
