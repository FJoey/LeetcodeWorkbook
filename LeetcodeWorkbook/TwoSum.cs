namespace ArrayProblems;

using System;

class TwoSum
{
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
    }

    public static int[] twoSum(int[] nums, int target)
    {
        

        int[] arr = { 0, 0 };

        return arr;
    }

}
