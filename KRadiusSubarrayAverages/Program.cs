/*

LeetCode 4836
K Radius Subarray Averages
Course: Data Structures and Algorithms

You are given a 0-indexed array nums of n integers, and an integer k.

The k-radius average for a subarray of nums centered at some index i with the radius k is the average
of all elements in nums between the indices i - k and i + k (inclusive).
If there are less than k elements before or after the index i, then the k-radius average is -1.

Build and return an array avgs of length n where avgs[i] is the k-radius average for the subarray centered at index i.

The average of x elements is the sum of the x elements divided by x, using integer division.
The integer division truncates toward zero, which means losing its fractional part.

*/

using System.Text;

internal class Program {

    public static void Main(string[] args) {

        int[] input1 = [7,4,3,9,1,8,5,2,6];
        int k1 = 3;
        // expected output: [-1,-1,-1,5,4,4,-1,-1,-1]

        int[] input2 = [1, 11, 17, 21, 29];
        int k2 = 4;
        // expected output: [100000]

        int[] input3 = [8];
        int k3 = 100000;
        // expected output: [-1]


        Console.WriteLine("Input 1: " + IntArrayToString(input1) + ", k = " + k1);
        Console.WriteLine("Output: " + IntArrayToString(GetAverages(input1, k1)));
        Console.WriteLine();

        Console.WriteLine("Input 2: " + IntArrayToString(input2) + ", k = " + k2);
        Console.WriteLine("Output: " + IntArrayToString(GetAverages(input2, k2)));
        Console.WriteLine();

        Console.WriteLine("Input 3: " + IntArrayToString(input3) + ", k = " + k3);
        Console.WriteLine("Output: " + IntArrayToString(GetAverages(input3, k3)));

    }

    public static int[] GetAverages(int[] nums, int k) {

        if (k < 1)
            return nums;

        int len = nums.Length;
        int subLen = 2*k + 1;

        int[] result = new int[len];
        if (len < subLen)
        {
            for (int i = 0; i < len; ++i)
                result[i] = -1;
            return result;
        }

        long[] sums = new long[len];

        sums[0] = (long)nums[0];
        for (int i = 1; i < len; ++i)
            sums[i] = sums[i - 1] + nums[i];

        for (int j = 0; j < len; ++j)
        {
            if (j >= k && j < len - k)
                result[j] = (int)((sums[j + k] - (j == k? 0 : sums[j - k - 1]))/(subLen));
            else
                result[j] = -1;
        }

        return result;

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