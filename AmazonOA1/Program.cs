/*
    Amazon OA Question (seen on Reddit)
    (similar LC question: 239 Sliding Window Maximum)

    The Amazon distribution center consists of arrays of products, each possessing unique attributes.
    The task at hand is to compute the beauty of these product arrays, with the goal of
    achieving an efficient selection process.

    More specifically, there are arrays of products, and each array corresponds to a list of attributes.
    The beauty of a subarray B = [products[l], products[l + 1], ... , products[r]] is quantified
    by counting the indices i that satisfy these conditions:

    l <= i <= r
    for every index j such that i <= j <= r, products[i] > products[j]

    An array B is a subarray of an array A if B can be obtained from A by deletion of several
    (possibly zero or all) elements from the beginning and several (possibly zero or all) elements
    from the end. In particular, an array is a subarray of itself.

    The beautiness of the entire array of products in determined by the sum of beauty values across
    all subarrays of a given size k.

    Given an array products of size n and an integer k, compute the total beautiness of the array of products.

    Example:

    n = 6
    products = [3, 6, 2, 9, 4, 1]
    k = 3

    B = [3, 6, 2]   beauty = 2 (index 1 and 2)
    B = [6, 2, 9]   beauty = 1 (index 2)
    B = [2, 9, 4]   beauty = 2 (index 1 and 2)
    B = [9, 4, 1]   beauty = 3 (index 0, 1, 2)

    Total beauty of products = 2 + 1 + 2 + 3 = 8.

*/

using System.Text;

internal class Program {

    public static void Main(string[] args) {

        int[] products = [3, 6, 2, 9, 4, 1];
        int k = 3;

        Console.WriteLine("products: " + IntArrayToString(products) + ", k = " + k);
        Console.WriteLine("beauty: " + GetBeauty(products, k));
    }

    public static int GetBeauty(int[] products, int k) {

        int len = products.Length;

        if (k < 1 || k > len)
            return 0;

        if (k == 1)
            return k;        

        int totalB = len - k + 1;
        int right, left;

        for (right = k - 1; right < len; ++right)
        {
            for (left = right - 1; left >= right - k + 1; --left)
            {
                if (products[left] > products[left + 1])
                    ++totalB;

                else
                    left = -1;
                
            }
        }

        return totalB;
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