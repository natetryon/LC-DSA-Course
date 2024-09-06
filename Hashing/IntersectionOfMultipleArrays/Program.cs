/*
    LeetCode 2248
    Intersection of Multiple Arrays (easy)

    Given a 2D integer array nums where nums[i] is a non-empty array of distinct positive integers,
    return the list of integers that are present in each array of nums sorted in ascending order.

    Constraints:

    1 <= nums.length <= 1000
    1 <= sum(nums[i].length) <= 1000
    1 <= nums[i][j] <= 1000
    All the values of nums[i] are unique.

*/

using System.Text;
using System.Collections;

internal class Program {

    public static void Main(string[] args) {

        int[][] input1 = [[3,1,2,4,5],[1,2,3,4],[3,4,5,6]];
        // output: [3, 4]

        int[][] input2 = [[1,2,3],[4,5,6]];
        // output: []

        Console.WriteLine("input 1: ");
        Console.WriteLine("output: " + IntListToString(Intersection(input1)));
        Console.WriteLine();

        Console.WriteLine("input 2: ");
        Console.WriteLine("output: " + IntListToString(Intersection(input2)));
        Console.WriteLine();


    }

    public static IList<int> Intersection(int[][] nums) {

        List<int> result = new List<int>();
        Dictionary<int, int> counts = new Dictionary<int, int>();

        int arrayCount = nums.Length;

        for (int i = 0; i < arrayCount; ++i)
        {
            for (int j = 0; j < nums[i].Length; ++j)
            {
                if (counts.ContainsKey(nums[i][j]))
                    ++counts[nums[i][j]];
                else
                    counts[nums[i][j]] = 1;
            }
        }

        foreach (KeyValuePair<int, int> kvp in counts)
        {
            if (kvp.Value == arrayCount)
                result.Add(kvp.Key);
        }

        result.Sort();
        return result;
    }


    public static string IntListToString(IList<int> nums) {

        StringBuilder sb = new StringBuilder();

        sb.Append('[');

        for (int i = 0; i < nums.Count; i++)
        {
            sb.Append(nums[i]);
            if (i < nums.Count - 1)
                sb.Append(", ");
        }

        sb.Append(']');

        return sb.ToString();

    }

}