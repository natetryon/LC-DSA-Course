/*
    You are given a string s and an integer k. Find the length of the longest
    substring that contains at most k distinct characters.

    For example, given s = "eceba" and k = 2, return 3. The longest substring
    with at most 2 distinct characters is "ece".

*/

using System.Collections;

internal class Program {

    public static void Main(string[] args) {

        string input1 = "eceba";
        int k1 = 2;

        Console.WriteLine("input 1: \"" + input1 + "\", k = " + k1);
        Console.WriteLine("output: " + LongestSubstringDistinct(input1, k1));
        Console.WriteLine();

    }

    public static int LongestSubstringDistinct(string s, int k) {

        Dictionary<char, int> counts = new Dictionary<char, int>();

        int left  = 0, right = 0, len = 0;

        while (right < s.Length)
        {
            if (counts.ContainsKey(s[right]))
                ++counts[s[right]];
            else
                counts[s[right]] = 1;

            while (counts.Count > k)
            {
                --counts[s[left]];

                if (counts[s[left]] == 0)
                    counts.Remove(s[left]);
                
                ++left;
            }

            len = Math.Max(len, right - left + 1);
            
            ++right;
            
        }

        return len;
    }

}