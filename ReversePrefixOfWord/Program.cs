/*
    LeetCode 2000
    Reverse Prefix of Word (Easy)

    Given a 0-indexed string word and a character ch, reverse the segment of word
    that starts at index 0 and ends at the index of the first occurrence of ch (inclusive).
    If the character ch does not exist in word, do nothing.

    For example, if word = "abcdefd" and ch = "d",
    then you should reverse the segment that starts at 0 and ends at 3 (inclusive).
    The resulting string will be "dcbaefd".

    Constraints:

    1 <= word.length <= 250
    word consists of lowercase English letters.
    ch is a lowercase English letter.

*/

using System.Text;

internal class Program {

    public static void Main(string[] args) {

        string input1 = "abcdefd";
        char ch1 = 'd';
        // output: "dcbaefd"

        string input2 = "xyxzxe";
        char ch2 = 'z';
        // output: "zxyxxe"

        string input3 = "abcd";
        char ch3 = 'z';
        // output: "abcd"

        Console.WriteLine("input 1: " + input1);
        Console.WriteLine("output 1: " + ReversePrefix(input1, ch1));
        Console.WriteLine();

        Console.WriteLine("input 2: " + input2);
        Console.WriteLine("output 2: " + ReversePrefix(input2, ch2));
        Console.WriteLine();

        Console.WriteLine("input 3: " + input3);
        Console.WriteLine("output 3: " + ReversePrefix(input3, ch3));
        Console.WriteLine();


    }

    public static string ReversePrefix(string word, char ch) {

        StringBuilder sb = new StringBuilder();
        int len = word.Length;
        char c;

        for (int i = 0; i < len; ++i)
        {
            c = word[i];
            sb.Insert(0, c);
            if (c == ch)
            {
                if (i + 1 < len)
                    sb.Append(word.Substring(i+1));
                return sb.ToString();
            }
        }
        
        return word;
    }
}