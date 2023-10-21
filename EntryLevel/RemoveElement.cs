public class Solution {
    public int RemoveElement(int[] nums, int val) {
                if (nums == null || nums.Length == 0) {
            return 0;
        }

        int k = 0; // pointer for the position to overwrite in nums

        for (int i = 0; i < nums.Length; i++) {
            
            if(val!=nums[i]){
                nums[k]=nums[i];
                k++;
            }
        }

        return k;
    }
}

