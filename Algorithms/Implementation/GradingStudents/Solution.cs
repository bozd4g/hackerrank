using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    static int[] solve(int[] grades){
        // Complete this function
        
        int[] finalGrades = new int[grades.Length];
        for(int i=0;i<grades.Length;i++) 
        {
            int result = grades[i];
            if (grades[i] >= 38)
                if ((5 - (grades[i] % 5) + grades[i]) - grades[i] < 3)
                    result = 5 - (grades[i] % 5) + grades[i];
                    
            finalGrades[i] = result;
        }
        
        return finalGrades;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] grades = new int[n];
        for(int grades_i = 0; grades_i < n; grades_i++){
           grades[grades_i] = Convert.ToInt32(Console.ReadLine());   
        }
        int[] result = solve(grades);
        Console.WriteLine(String.Join("\n", result));
    }
}
