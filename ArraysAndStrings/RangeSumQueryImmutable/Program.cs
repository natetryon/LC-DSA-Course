/*
    LeetCode 303
    Range Sum Query - Immutable (Easy)

    Given an integer array nums, handle multiple queries of the following type:

     - Calculate the sum of the elements of nums between indices left and right inclusive where left <= right.

    Implement the NumArray class:

     - NumArray(int[] nums): Initializes the object with the integer array nums.
     - int sumRange(int left, int right): Returns the sum of the elements of nums between
        indices left and right inclusive (i.e. nums[left] + nums[left + 1] + ... + nums[right]).

    Your NumArray object will be instantiated and called as such:
    * NumArray obj = new NumArray(nums);
    * int param_1 = obj.SumRange(left,right);

    Constraints:

    1 <= nums.length <= 104
    -105 <= nums[i] <= 105
    0 <= left <= right < nums.length
*/

internal class Program {

    public static void Main(string[] args) {

        int[] nums = [-2, 0, 3, -5, 2, -1];
        int left = 0;
        int right = 2;

        NumArray obj = new NumArray(nums);
        int result = obj.SumRange(left, right);
        Console.WriteLine("Result: " + result);

    }
}

public class NumArray {

    private int[] sums;

    public NumArray(int[] nums) {

        int len = nums.Length;
        sums = new int[len];
        sums[0] = nums[0];
        for (int i = 1; i < len; ++i)
            sums[i] = sums[i - 1] + nums[i];

    }

    public int SumRange(int left, int right) {

        if (left == 0)
            return sums[right];

        return sums[right] - sums[left - 1];

    }
}