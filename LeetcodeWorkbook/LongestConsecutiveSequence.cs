namespace ArrayProblems;

using System;

class LongestConsecutiveSequence
{

    public static void run()
    {
        //Test case 1
        int[] nums1 = [100, 4, 200, 1, 3, 2];
        Console.WriteLine("test case 1: " +
                        longestConsecutiveSequence(nums1));

        //Test case 2
        int[] nums2 = [0, 3, 7, 2, 5, 8, 4, 6, 0, 1];
        Console.WriteLine("test case 2: " +
                        longestConsecutiveSequence(nums2));

        //Test case 3
        int[] nums3 = [1, 0, 1, 2];
        Console.WriteLine("test case 3: " +
                        longestConsecutiveSequence(nums3));

        //Test case 4
        int[] nums4 = [9, 1, 4, 7, 3, -1, 0, 5, 8, -1, 6];
        Console.WriteLine("test case 4: " +
                        longestConsecutiveSequence(nums4));
    }


    // --------------------Longest Consecutive Sequence: New attempts, past attempts, and suggested solutions
    // New attempts go here 
    public static int longestConsecutiveSequence(int[] nums)
    {
        //Consecutive elements includes elements that are only 1 unit apart
        //We could sort the array, and then increment a counter for every consecutive element
        if (nums.Length == 0) return 0;

        Array.Sort(nums);

        Console.Write("[");
        for (int i = 0; i < nums.Length - 1; i++)
        {
            Console.Write(nums[i] + " ");
        }
        Console.Write("] ");

        int count = 1;
        int record = 0;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (Math.Abs((nums[i + 1] - nums[i])) == 1)
            {
                count++;
            }
            if (count > record)
            {
                record = count;
            }
            else
            {
                count = 1;
            }
        }

        return record;
    }

    // Suggested Solution (user Tabriz via Leetcode)
    /*
     *
     Approach
        Firstly, we need to catch nonrepeated numbers. 
        That's why, we use HashSet. 
        After, in the loop we check previous number of the current number exist or not in the array. 
        If previous number doesn't exist, then we guess that our sequence is starting.

     Complexity
        Time complexity: O(N)
        Space complexity: O(N)
     *
     */
    public static int longestConsecutiveSequenceSuggested(int[] nums)
    {
        HashSet<int> set = new HashSet<int>(nums);
        int maxLength = 0;

        foreach(int num in nums) {
            if(set.Contains(num - 1)) continue;
            
            int length = 0;
            while(set.Contains(num + length)) length++;

            maxLength = Math.Max(maxLength, length);
        }

        return maxLength;
    }

}
