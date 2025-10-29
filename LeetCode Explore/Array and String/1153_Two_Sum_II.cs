namespace LeetCode.Learn.Array_and_String
{
    public class Two_Sum_II
    {
        public int[] TwoSum(int[] numbers, int target)
        {

            //edge case
            if (numbers.Length == 2)
            { return [1, 2]; }

            //pointers
            int left = 0;
            int right = numbers.Length - 1;
            int sum = 0;

            //since it is sorted, start from the edges and work your way to center
            while (left < right)
            {
                sum = numbers[left] + numbers[right];
                if (sum == target) { break; }
                else
                {
                    if (sum < target) { left++; }
                    if (sum > target) { right--; }
                }
            }

            //1-indexed requirement
            return [left + 1, right + 1];
        }
    }
}