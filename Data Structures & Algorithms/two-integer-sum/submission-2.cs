public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> idx = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++) {
            if(idx.ContainsKey(target - nums[i])) return new int[]{idx[target - nums[i]], i};
            if(!idx.ContainsKey(nums[i])) idx[nums[i]] = i;
        }

        return new int[]{-1, -1};
    }
}
