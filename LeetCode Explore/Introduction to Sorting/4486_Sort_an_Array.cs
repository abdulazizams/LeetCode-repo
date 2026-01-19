public class Solution {
    
    // heap sort should satisfy the requirements
    
    //heapify method
    public void Heapify (ref int[] list, int ParentIdx, int count)
    {
        //initilize family
        int parentIdx = ParentIdx;
        int leftChildIdx = 2 * parentIdx + 1;
        int rightChildIdx = 2 * parentIdx + 2;
        
        //if child > parent; switch them. start with left and ensure childIdx < count
        if((leftChildIdx < count) && (list[leftChildIdx] > list[parentIdx])){parentIdx = leftChildIdx;}
        if((rightChildIdx < count) && (list[rightChildIdx] > list[parentIdx])){parentIdx = rightChildIdx;}
        
        //update the list, if needed, by switching new parent with old Parent
        if(parentIdx != ParentIdx)
        {
            int temp = list[parentIdx]; list[parentIdx] = list[ParentIdx]; list[ParentIdx] = temp;
            
            //heapify subtree
            Heapify(ref list, parentIdx, count);
        }
        
        
    }
    
    public int[] SortArray(int[] nums) {
        
        int count = nums.Length;
        
        //1 - build max heap
        
        for(int i = count/2 - 1; i >= 0; i--)
        {
            Heapify(ref nums, i, count);
        }
        
        //2 - recursively push root node to last index
        
        for (int i = count - 1; i >= 0; i--)
        {
            //swap first and last elements
            int temp = nums[0]; nums[0] = nums[i]; nums[i] = temp;
            
            //heapfy list with count = i
            Heapify(ref nums, 0, i);
        }
        
        return nums;
    }
}
