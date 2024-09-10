/*
    LC 1941
    Check if All Characters Have Equal Number of Occurrences (easy)

    Given a string s, return true if s is a good string, or false otherwise.

    A string s is good if all the characters that appear in s have the same number of occurrences
    (i.e., the same frequency).

    Constraints:

    1 <= s.length <= 1000
    s consists of lowercase English letters.

*/

using System.Collections;

internal class Program {

    public static void Main(string[] args) {

        string input1 = "abacbc";
        // output: true

        string input2 = "aaabb";
        // output: false

        Console.WriteLine("input 1: " + input1);
        Console.WriteLine("result: " + AreOccurrencesEqual(input1));
        Console.WriteLine();

        Console.WriteLine("input 2: " + input2);
        Console.WriteLine("result: " + AreOccurrencesEqual(input2));
        Console.WriteLine();

    }

    public static bool AreOccurrencesEqual(string s) {

        Dictionary<char, int> d = new Dictionary<char, int>();
        HashSet<int> f = new HashSet<int>();

        foreach (char c in s) {

            if (d.ContainsKey(c))
                ++d[c];
            else
                d[c] = 1;
        }
        
        foreach(int v in d.Values)
            f.Add(v);


        return f.Count == 1;
    }
}