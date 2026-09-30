public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> set = new HashSet<int>();

        foreach(int i in nums) {
            if(set.Contains(i)) return true;
            set.Add(i);
        }

        return false;
    }
}