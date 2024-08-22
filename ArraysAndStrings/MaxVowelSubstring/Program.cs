/*
    LeetCode 1456
    Maximum Number of Vowels in a Substring of Given Length (Medium)

    Given a string s and an integer k, return the
    maximum number of vowel letters in any substring of s with length k.

    Constraints:

    1 <= s.length <= 10^5
    s consists of lowercase English letters.
    1 <= k <= s.length

*/

internal class Program {

    public static void Main(string[] args) {

        string input1 = "ibpbhixfiouhdljnjfflpapptrxgcomvnb";
        int k1 = 33;
        // output: 7

        string input2 = "aeiou";
        int k2 = 2;
        // output: 2

        string input3 = "leedcote";
        int k3 = 3;
        // output: 2

        Console.WriteLine("input 1: " + input1 + ", k = " + k1);
        Console.WriteLine("output: " + MaxVowels(input1, k1));
        Console.WriteLine();

        Console.WriteLine("input 2: " + input2 + ", k = " + k2);
        Console.WriteLine("output: " + MaxVowels(input2, k2));
        Console.WriteLine();

        Console.WriteLine("input 3: " + input3 + ", k = " + k3);
        Console.WriteLine("output: " + MaxVowels(input3, k3));
        Console.WriteLine();

    }

    public static int MaxVowels(string s, int k) {

        int max = 0, count = 0;
        int left = 0, right = k - 1;

        for (int i = 0; i < k; ++i)
            if (IsVowel(s[i]))
                ++count;

        if (count == k)
            return k;

        max = count;

        while (right < s.Length - 1)
        {
             ++right;

            if (IsVowel(s[left]))
                --count;

            ++left;

            if (IsVowel(s[right]))
                ++count;

            if (count == k)
                return k;

            max = Math.Max(max, count);
        }


        return max;
    }

    public static bool IsVowel (char c) {
        return c == 'a' || c == 'e' || c == 'i' || c =='o' || c == 'u';
    }

}