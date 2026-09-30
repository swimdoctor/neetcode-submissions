public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> counts = new Dictionary<int, int>();

        foreach (int i in nums) {
            if (!counts.ContainsKey(i))
                counts[i] = 1;
            else
                counts[i]++;
        }

        int[] output = new int[k];
        int filled = 0;

        foreach (int key in counts.Keys) {
            int n = key;
            for (int i = 0; i < output.Length; i++) {
                //Console.WriteLine(i + " " + output[i]);
                if (i >= filled) {
                    output[i] = n;
                    filled++;
                    break;
                }
                //Console.WriteLine(i + " " + output[i]);
                if (counts[output[i]] < counts[n]) {
                    int newKey = output[i];
                    output[i] = n;
                    n = newKey;
                }
            }
        }

        return output;
    }
}
