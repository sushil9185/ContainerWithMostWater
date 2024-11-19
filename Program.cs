namespace ContainerWithMostWater
{
    internal class Program
    {
        //Problem Link: https://leetcode.com/problems/container-with-most-water
        public static void Main(string[] args)
        {
            int[] height1 = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            int[] height2 = { 1, 1 };

            Console.WriteLine(MaxAreaBruteForce(height1)); // Output: 49
            Console.WriteLine(MaxAreaTwoPointers(height1)); // Output: 49

            Console.WriteLine(MaxAreaBruteForce(height2)); // Output: 1
            Console.WriteLine(MaxAreaTwoPointers(height2)); // Output: 1
        }

        //Optimal Solution
        public static int MaxAreaTwoPointers(int[] height)
        {

            int n = height.Length;
            int maxArea = 0;
            int left = 0;
            int right = n - 1;

            while (left < right)
            {
                int area = Math.Min(height[left], height[right]) * (right - left);
                maxArea = Math.Max(maxArea, area);

                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }

            }


            return maxArea;
        }

        public static int MaxAreaBruteForce(int[] height)
        {

            int n = height.Length;
            int maxArea = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    int area = Math.Min(height[i], height[j]) * (j - i);
                    maxArea = Math.Max(maxArea, area);
                }
            }

            return maxArea;
        }
    }
}
