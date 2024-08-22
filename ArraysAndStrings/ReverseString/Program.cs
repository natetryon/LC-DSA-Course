/*

LeetCode 4592
ReverseString
Course: Data Structures and Algorithms

Write a function that reverses a string. The input string is given as an array of characters s.

You must do this by modifying the input array in-place with O(1) extra memory.

*/

using System;
using System.Text;

internal class Program {
    public static void Main(string[] args) {

        char[] input = ['h', 'e', 'l', 'l', 'o'];

        Console.WriteLine("input: " + ArrayToString(input));
        ReverseString(input);
        Console.WriteLine("reversed: " + ArrayToString(input));
        

    }

    public static void ReverseString(char[] s) {

        int i = 0;
        char temp;
        int len = s.Length - 1;
        while (i < s.Length / 2)
        {
            temp = s[i];
            s[i] = s[len - i];
            s[len - i] = temp;
            i++;
        }

    }

    public static string ArrayToString(char[] s) {

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < s.Length; ++i)
        {
            sb.Append(s[i]);
        }

        return sb.ToString();

    }
}
