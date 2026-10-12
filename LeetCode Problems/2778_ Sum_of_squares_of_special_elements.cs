//URL: https://leetcode.com/problems/sum-of-squares-of-special-elements/
public class Solution {
    public int SumOfSquares(int[] nums) {
        
        int len = nums.Length;

        //early return
        //apparently it is 0-indexed not 1-indexed array
        if(len == 1){return nums[0] * nums[0];}

        int sum = 0;
        int max = (int)Math.Sqrt(len);
        //iterate up to sqrt(n)
        for(int i = 1; i <= max; i++)
        {
          //if not divisor, skip
            if(len % i != 0){continue;}
            sum += nums[i-1] * nums[i-1];
            //divisor compliment
            sum += (len/i != i)? nums[len/i - 1] * nums[len/i - 1] : 0;
        }

        return sum;
    }
}
