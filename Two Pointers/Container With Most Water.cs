// Difficulty: Medium
public class Solution
{
    public int MaxArea(int[] height)
    {
        int L = 0;
        int R = height.Length - 1;

        int res = 0;

        while (L < R)
        {
            res = Math.Max(res, (R - L) * Math.Min(height[L], height[R]));

            if (height[L] < height[R])
            {
                L++;
            }
            else
            {
                R--;
            }
        }
        return res;
    }
}