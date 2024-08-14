/*
    LeetCode 1732
    Find the Highest Altitude (Easy)

    There is a biker going on a road trip.
    The road trip consists of n + 1 points at different altitudes.
    The biker starts his trip on point 0 with altitude equal to 0.

    You are given an integer array gain of length n where
    gain[i] is the net gain in altitude between points i and i + 1
    for all (0 <= i <= n).
    Return the highest altitude of a point.

    Constraints:

    n == gain.length
    1 <= n <= 100
    -100 <= gain[i] <= 100

*/

using System.Text;

internal class Program {

    public static void Main(string[] args) {

        int[] gain1 = [-5, 1, 5, 0, -7];
        // output: 1

        int[] gain2 = [-4, -3, -2, -1, 4, 3, 2];
        // output: 0

        Console.WriteLine("input: " + IntArrayToString(gain1));
        Console.WriteLine("output: " + LargestAltitude(gain1));
        Console.WriteLine();

        Console.WriteLine("input: " + IntArrayToString(gain2));
        Console.WriteLine("output: " + LargestAltitude(gain2));

    }

    public static int LargestAltitude(int[] gain) {

        int max = 0, cur = 0;

        for (int i = 0; i < gain.Length; ++i)
        {
            cur += gain[i];
            max = Math.Max(max, cur);
        }

        return max;
    }

    public static string IntArrayToString(int[] nums) {

        StringBuilder sb = new StringBuilder();

        sb.Append('[');

        for (int i = 0; i < nums.Length; i++)
        {
            sb.Append(nums[i]);
            if (i < nums.Length - 1)
                sb.Append(", ");
        }

        sb.Append(']');

        return sb.ToString();

    }
}