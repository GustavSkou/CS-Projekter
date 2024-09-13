using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int someValue, bitValue, numbersOfBits;
        List<bool> bitArray = new List<bool>();

        someValue = Convert.ToInt32(Console.ReadLine());
        numbersOfBits = (int) (Math.Log(someValue)/Math.Log(2)); //Calc the exponet of 2, casted to an int to be used as the smallest numbers of bits needed.
        Console.WriteLine(numbersOfBits);

        for (int i = numbersOfBits; i >= 0; i--)
        {
            bitValue = (int) Math.Pow(2, i);

            if ((someValue / bitValue) >= 1) // When someValue can be divided by a given bitValue, we know this bit must be 1
            {
                someValue = someValue - bitValue; // 
                bitArray.Add(true);
            }
            else
            {
                bitArray.Add(false);
            }
        }
        foreach (bool bit in bitArray)
        {
            switch (bit) //something
            {
                case true:
                    Console.Write("1 ");
                break;

                case false:
                    Console.Write("0 ");
                break;
            }
        }
    }
}