using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    static string timeConversion(string s) {
        // Complete this function
        string[] numbers = s.Split(':');
        int day = Convert.ToInt32(numbers[0]);
        if(numbers[2].Contains("AM") ||numbers[2].Contains("am"))
        {
            if(day == 12)
                return (day - 12 ).ToString() + "0" + ":" + numbers[1] + ":" + numbers[2].Remove(2,2);
            
            return "0" + day.ToString() + ":" + numbers[1] + ":" + numbers[2].Remove(2,2);
        }
        else if(numbers[2].Contains("PM") ||numbers[2].Contains("pm"))
        {
            if(day == 12)
                return day.ToString() + ":" + numbers[1] + ":" + numbers[2].Remove(2,2);
                
            return (day + 12 ).ToString() + ":" + numbers[1] + ":" + numbers[2].Remove(2,2);
        }
        else
            return numbers[0] + ":" + numbers[1] + ":" + numbers[2].Remove(2,2);
    }

    static void Main(String[] args) {
        string s = Console.ReadLine();
        string result = timeConversion(s);
        Console.WriteLine(result);
    }
}
