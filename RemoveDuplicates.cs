using System;

public class Solution
{
    public int[] RemoveDuplicates (int[] nums) 
    {
        int largestNum = nums[0];
        int numsInRow = 1;
        int nextIndex;

        for (int currentIndex = 0; 0 < nums.Length; currentIndex++)
        {
            nextIndex = currentIndex + 1;

            if (largestNum == nums[nums.Length-1])
            {
                break;
            }

            if (nums[nextIndex] > largestNum)
            {
                largestNum = nums[nextIndex];
                numsInRow++;
                continue;
            }

            for (int seachIndex = nextIndex + 1; seachIndex <= nums.Length; seachIndex++)
            {
                if ( nums[seachIndex] > largestNum)
                {
                    nums[nextIndex] = nums[seachIndex];
                    largestNum = nums[nextIndex];
                    numsInRow++;
                    break;
                }
            }
        }

        Array.Resize(ref nums, numsInRow);
        return nums;
    }
}

class Program
{
    static void Main ()
    {
        int[] someNums = {1, 2, 2, 2, 4, 6, 7, 8, 8, 8, 9 };

        Solution algorithm = new Solution();
        someNums = algorithm.RemoveDuplicates (someNums);

        foreach (int num in someNums)
        {
            Console.Write(num + ", ");
        }
    }
}