using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int someValue;
        int bitValue;
        int numbersOfBits;
        bool bitArrayStart = false;
        List<bool> bitArray = new List<bool>();

        someValue = Convert.ToInt32(Console.ReadLine());
        numbersOfBits = (int) (Math.Log(someValue)/Math.Log(2) + 1);
        Console.WriteLine(numbersOfBits);

        for (int i = numbersOfBits; i >= 0; i--)
        {
            bitValue = (int) Math.Pow(2, i);

            if ((someValue / bitValue) >= 1)
            {
                someValue = someValue - bitValue;
                bitArray.Add(true);

                bitArrayStart = true;
            }
            else if (bitArrayStart == true)
            {
                bitArray.Add(false);
            }
        }
        foreach (bool bit in bitArray)
        {
            if (bit == true)
            {
                Console.Write("1");
            }
            else
            {
                Console.Write("0");
            }
        }
    }
}