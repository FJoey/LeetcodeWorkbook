namespace ArrayProblems;

using System;

class LongestSubstringWithoutRepeatingCharacters
{

    public static void run()
    {
        //Test case 1
        string string1 = "abcabcbb";
        Console.WriteLine("test case 1: " +
            LengthOfLongestSubstring(string1));

        //Test case 2
        string string2 = "bbbbb";
        Console.WriteLine("test case 1: " +
            LengthOfLongestSubstring(string2));

        //Test case 3
        string string3 = "pwwkew";
        Console.WriteLine("test case 1: " +
            LengthOfLongestSubstring(string3));
    }

    // --------------------Longest Consecutive Sequence: New attempts, past attempts, and suggested solutions
    // New attempts go here 
    public static int LengthOfLongestSubstring(string s)
    {
        // This is where we would want to use a HashSet, since it only allows unique values
        HashSet<char> substring = new HashSet<char>();
        int count = 0;

        s.Split("").ToHashSet<string>();

        for (int i = 0; i < s.Length; i++)
        {
            if (!substring.Contains(s[i]))
            {
                Console.WriteLine("Adding " + s[i] + " ");
                substring.Add(s[i]);
            }
            else
            {
                if (substring.Count() >= count)
                {
                    count = substring.Count();
                }
                substring.Clear();
            }
        }

        return count;
    }


    // Suggested Solution (user Mina via Leetcode)
    /*
     *
     * Approach 1: Sliding Window
     *
     */
    public int LengthOfLongestSubstringSuggested(string s) {
        var letters = new Dictionary<char, int>(); // key:letter, val: latest index
        int maxCount = 0, left = 0, right;

        for (right = 0; right < s?.Length; right++) {
            char letter = s[right];

            if (letters.ContainsKey(letter)) { // End the window
                left = Math.Max(left, letters[letter] + 1); // Update left of window
            }

            letters[letter] = right; //Update index of letter on map

            maxCount = Math.Max(maxCount, right - left + 1); // Get the longest window length 
        }
	    return maxCount;
    }
    
}
