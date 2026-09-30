public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> triplets = new List<List<int>>();

        Array.Sort(nums);

        for(int i = 0; i < nums.Length - 2; i++) {
            if(i > 0 && nums[i] == nums[i-1]) continue;
            int j = i + 1;
            int k = nums.Length - 1;

            while(j < k) {
                //Console.WriteLine(i + " " + j + " " + k);
                if(nums[i] + nums[j] + nums[k] > 0) {
                    k--;
                    while(nums[k] == nums[k+1] && k > j) k--;
                }
                else if(nums[i] + nums[j] + nums[k] < 0) {
                    j++;
                    while(nums[j] == nums[j-1] && j < k) j++;
                }
                else {
                    triplets.Add(new List<int>{nums[i], nums[j], nums[k]});
                    j++;
                    k--;
                    while(j < k && nums[j] == nums[j-1]) j++;
                    while(j < k && nums[k] == nums[k+1]) k--;
                }
            }
        }

        return triplets;
    }
}
