namespace ArrayProblems;

using System;

class TwoSum
{
    // Runs the tests
    public static void run()
    {
        //Test case 1
        int[] arr1 = { 2, 7, 11, 15 };
        int target1 = 9;
        printIntArray(twoSum(arr1, target1));

        //Test case 2
        int[] arr2 = { 3, 2, 4 };
        int target2 = 6;
        printIntArray(twoSum(arr2, target2));

        //Test case 3
        int[] arr3 = { 3, 3 };
        int target3 = 6;
        printIntArray(twoSum(arr3, target3));

        //Test case 4
        int[] arr4 = { 2, 4, 11, 3 };
        int target4 = 6;
        printIntArray(twoSum(arr4, target4));

        //Test case 5
        int[] arr5 = { 3, 2, 4 };
        int target5 = 6;
        printIntArray(twoSum(arr5, target5));
    }

    // Prints the array
    public static void printIntArray(int[] arr)
    {
        Console.Write("[");
        for (int i = 0; i < arr.Length; i++)
        {
            if (i == arr.Length - 1)
            {
                Console.Write(arr[i]);
            }
            else
            {
                Console.Write(arr[i] + ", ");
            }
        }
        Console.Write("]");
    }

    // --------------------TwoSum: New attempts, past attempts, and suggested solutions
    // New attempts go here 

    // Accepted -> beats 96.19% (Memory) and 10.64% (Runtime)
    public static int[] twoSum(int[] nums, int target)
    {
        int[] arr = { 0, 0 };
        bool targetReached = false;

        Console.WriteLine();

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine(nums[i] + " + " + nums[j] + " = " + (nums[i] + nums[j]));
                if ((nums[i] + nums[j]).Equals(target) && i != j)
                {
                    arr[0] = i;
                    arr[1] = j;
                    targetReached = true;
                    break;
                }
            }
            if (targetReached == true)
            {
                break;
            }
        }

        return arr;
    }

    // Suggested Solution (user Otabek via Leetcode)
    /*
     *
        Approach

        1. Create a hash table (num_map) to store numbers along with their indices.
        
        2. Iterate through the array:
            Compute the complement of the current number (target - num).
            Check if the complement is already in the hash table.
            If it is, return the indices of the complement and the current number.
            Otherwise, store the current number with its index in the hash table.
        
        3. Since there is exactly one solution, we are guaranteed to find a valid pair.
     *
     */
        public int[] TwoSumSuggested(int[] nums, int target)
    {
        Dictionary<int, int> numMap = new Dictionary<int, int>(); // A mapping to store numbers and their indices
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i]; // Find the required number to reach the target
            if (numMap.ContainsKey(complement))
            {
                return new int[] { numMap[complement], i }; // Return indices of the complement and current number
            }
            numMap[nums[i]] = i; // Store the number with its index
        }
        return new int[] { }; // This line is never reached due to the problem guarantee
    }
}
