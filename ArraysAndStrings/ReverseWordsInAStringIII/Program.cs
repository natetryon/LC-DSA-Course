/*

LeetCode 557
Reverse Words in a String III (Easy)

Given a string s, reverse the order of characters in each word within a sentence
while still preserving whitespace and initial word order.

Constraints:

1 <= s.length <= 5x10^4
s contains printable ASCII characters.
s does not contain any leading or trailing spaces.
There is at least one word in s.
All the words in s are separated by a single space.

*/

using System.Text;

internal class Program {

    public static void Main(string[] args) {

        string input1 = "Get Me the President!";
        string input2 = "Is you is or is you ain't my baby?";
        string input3 = "Nobody does it better";

        Console.WriteLine("input 1: " + input1);
        Console.WriteLine("output: " + ReverseWords(input1));
        Console.WriteLine();

        Console.WriteLine("input 2: " + input2);
        Console.WriteLine("output: " + ReverseWords(input2));
        Console.WriteLine();

        Console.WriteLine("input 3: " + input3);
        Console.WriteLine("output: " + ReverseWords(input3));

    }

    public static string ReverseWords(string s) {

        StringBuilder sb = new StringBuilder();

        int left = 0, right = 0;

        while (right < s.Length)
        {
            if (s[right] == ' ')
            {
                left = right - 1;
                while (left >= 0 && s[left] != ' ')
                {
                    sb.Append(s[left]);
                    --left;
                }
                
                sb.Append(' ');
            }
            
            ++right;
        }

        left = s.Length - 1;
        while (left >= 0 && s[left] != ' ')
        {
            sb.Append(s[left]);
            --left;
        }


        return sb.ToString();
    }

}