public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] output = new int[nums.Length];

        int running = 1;
        for(int i = 0; i < nums.Length; i++) {
            output[i] = running;
            running *= nums[i];
        }

        running = 1;
        for(int i = nums.Length-1; i >= 0; i--) {
            output[i] *= running;
            running *= nums[i];
        }

        return output;
    }
}
