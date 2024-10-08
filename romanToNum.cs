using System;
using System.Collections.Generic;

public class Solution 
{
    public int RomanToInt(string romanString) 
    {
        int convertetNumber = 0;
        Dictionary<Char, int> romanConversion = new Dictionary<Char, int>()
        {
            {'I', 1}, 
            {'V', 5}, 
            {'X', 10}, 
            {'L', 50}, 
            {'C', 100}, 
            {'D', 500}, 
            {'M', 1000}
        };

        for (int index = 0; index < romanString.Length; index++)
        {
            if (index == romanString.Length-1)                                                      //Last number
            {                                                                                       //Has to be added
                convertetNumber = convertetNumber + romanConversion[ romanString[index] ];
                continue;
            }

            if (romanConversion[ romanString[index] ] < romanConversion[ romanString[index +1 ] ])  // Current number smaller than the next number
            {                                                                                       // We know we must subtract this number from the total
                convertetNumber = convertetNumber - romanConversion[ romanString[index] ];
                continue;
            }

            convertetNumber = convertetNumber + romanConversion[ romanString[index] ];
        }
        return convertetNumber;
    }
}

class Program
{
    static void Main()
    {
        string romanNumbers = "MCMXCIV";
        Solution getNum = new Solution();
        Console.WriteLine(getNum.RomanToInt(romanNumbers));
    }
}