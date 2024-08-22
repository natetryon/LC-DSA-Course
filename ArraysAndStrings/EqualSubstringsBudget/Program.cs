/*
    LeetCode 1208
    Get Equal Substrings Within Budget (Medium)

    You are given two strings s and t of the same length and an integer maxCost.
    You want to change s to t. Changing the ith character of s to ith character of t costs |s[i] - t[i]|
    (i.e., the absolute difference between the ASCII values of the characters).

    Return the maximum length of a substring of s that can be changed to be the same as the
    corresponding substring of t with a cost less than or equal to maxCost.
    If there is no substring from s that can be changed to its corresponding substring from t, return 0.

    Constraints:

    1 <= s.length <= 105
    t.length == s.length
    0 <= maxCost <= 106
    s and t consist of only lowercase English letters.

*/

internal class Program {

    public static void Main(string[] args) {

        string s1 = "abcd", t1 = "bcdf";
        int max1 = 3;
        // output: 3

        string s2 = "abcd", t2 = "cdef";
        int max2 = 3;
        // output: 1

        Console.WriteLine("Input: s = " + s1 + ", t = " + t1 + ", maxCost = " + max1);
        Console.WriteLine("Output: " + EqualSubstring(s1, t1, max1));
        Console.WriteLine();


        Console.WriteLine("Input: s = " + s2 + ", t = " + t2 + ", maxCost = " + max2);
        Console.WriteLine("Output: " + EqualSubstring(s2, t2, max2));


    }

    public static int EqualSubstring(string s, string t, int maxCost) {

        int len = s.Length;
        int left = 0, right = 0;
        int curSum = Math.Abs(s[right] - t[right]);
        int maxLen = 0;

        while (right < len - 1)
        {
            if (curSum <= maxCost)
                maxLen = Math.Max(maxLen, right - left + 1);

            else
                curSum -= Math.Abs(s[left] - t[left++]);

            curSum += Math.Abs(s[++right] - t[right]);
        }

        if (curSum <= maxCost)
                maxLen = Math.Max(maxLen, right - left + 1);

        return maxLen;
    }
}