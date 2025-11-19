public class Solution {
    public int MinSubArrayLen(int target, int[] nums)
        {

            //edge case: only 1 element
            if (nums.Length == 1)
            {
                if (nums[0] >= target) { return 1; }
                else { return 0; }
            }

            //use sliding window approach

            //keep increasing LHP to exceed target then increase RHP
            //then start shifteing LHP and RHP to find smallest window
            int min = nums.Length + 1; // upper limit +1
            int rhp = 0; // right hand pointer
            int lhp = 0;
            int sum = nums[rhp]; //curent sum
            int win; // window size, for readability

            while (lhp >= rhp && min > 1)
            {
                win = lhp - rhp + 1;
                switch (true)
                {
                    case true when (win > min):
                    //the window should not be wider than prevoiusly found min
                    sum -= nums[rhp];
                    rhp++;
                    break;

                    case true when (sum < target):
                    //increase window size
                    if (lhp < nums.Length-1){lhp++; sum+= nums[lhp];}
                    //sum cannot increase, break from while loop
                    else { rhp = lhp + 1;}
                    break;

                    // since !(win>min) incremet RHP to narrow the window
                    case true when (sum >= target):
                    min = win;
                    sum -= nums[rhp];
                    rhp++;
                    break;
                }

            }

           if (min < nums.Length + 1){ return min;}

            return 0;
        }
    }
