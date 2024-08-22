/*
    A pangram is a sentence where every letter of the English alphabet appears at least once.

    Given a string sentence containing only lowercase English letters,
    return true if sentence is a pangram, or false otherwise.

    Constraints:

    1 <= sentence.length <= 1000
    sentence consists of lowercase English letters.

*/

using System.Collections.Generic;

internal class Program {

    public static void Main(string[] args) {

        string input1 = "thequickbrownfoxjumpsoverthelazydog";
        // output: true

        Console.WriteLine("input: " + input1);
        Console.WriteLine("pangram: " + CheckIfPangram(input1));
        Console.WriteLine();

    }

    public static bool CheckIfPangram(string sentence) {

        int len = sentence.Length;

        if (len < 26)
            return false;

        int unique = 0;

        HashSet<char> letters = new HashSet<char>();
        char c;

        for (int i = 0; i < len; ++i)
        {
            c = sentence[i];

            if (!letters.Contains(c))
            {
                letters.Add(c);
                ++unique;

                if (unique == 26)
                    return true;
            }
        }

        return false;
    }
}