/*
    LeetCode 917
    Reverse Only Letters (Easy)

    Given a string s, reverse the string according to the following rules:

     - All the characters that are not English letters remain in the same position.
     - All the English letters (lowercase or uppercase) should be reversed.

    Return s after reversing it.

    Constraints:

    1 <= s.length <= 100
    s consists of characters with ASCII values in the range [33, 122].
    s does not contain '\"' or '\\'.

*/
using System.Text;

internal class Program {

    public static void Main(string[] args) {

        string input1 = "ab-cd";
        string input2 = "a-bC-dEf-ghIj";
        string input3 = "Test1ng-Leet=code-Q!";

        // ReverseOnlyLetters(input3);

        Console.WriteLine("input 1: " + input1);
        Console.WriteLine("output 1: " + ReverseOnlyLetters(input1));
        Console.WriteLine();

        Console.WriteLine("input 2: " + input2);
        Console.WriteLine("output 2: " + ReverseOnlyLetters(input2));
        Console.WriteLine();

        Console.WriteLine("input 3: " + input3);
        Console.WriteLine("output 3: " + ReverseOnlyLetters(input3));
        Console.WriteLine();

    }

    public static string ReverseOnlyLetters(string s) {

        StringBuilder sb = new StringBuilder();

        int len = s.Length;

        int left = 0, right = len - 1;

        while (left < len)
        {
            if (IsLetter(s[left]))
            {
                while (!IsLetter(s[right]))
                    --right;
                sb.Append(s[right--]);
            }

            else
                sb.Append(s[left]);

            ++left;
        }
        return sb.ToString();
    }

    public static bool IsLetter(char c) {

        return (c >= 65 && c <= 90) || (c >= 97 && c <= 122);

    }
}