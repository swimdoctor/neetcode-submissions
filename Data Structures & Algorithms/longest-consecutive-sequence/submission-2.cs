public class Solution {
    public int LongestConsecutive(int[] nums) {
        Dictionary<int, int> ranges = new Dictionary<int, int>();

        foreach (int i in nums) {
            //Console.WriteLine("Starting: " + i);
            //foreach (int j in ranges.Keys) Console.WriteLine(j + "->" + ranges[j]);
            if (ranges.ContainsKey(i))
                continue;

            bool up = ranges.ContainsKey(i + 1);
            bool down = ranges.ContainsKey(i - 1);

            if (!up && !down)
                ranges[i] = i;
            if (up && !down) {
                if (ranges[i + 1] >= i + 1) {
                    ranges[i] = ranges[i + 1];
                    ranges.Remove(i + 1);
                    ranges[ranges[i]] = i;
                }
            }
            if (!up && down) {
                if (ranges[i - 1] <= i - 1) {
                    ranges[i] = ranges[i - 1];
                    ranges.Remove(i - 1);
                    ranges[ranges[i]] = i;
                }
            }
            if (up && down && ranges[i + 1] >= i + 1 && ranges[i - 1] <= i - 1) {
                int max = ranges[i+1];
                int min = ranges[i-1];
                ranges.Remove(i+1);
                ranges.Remove(i-1);
                ranges[max] = min;
                ranges[min] = max;
            }
        }

        int maxRange = 0;

        foreach (int i in ranges.Keys) {
            //Console.WriteLine(i + "->" + ranges[i]);
            if (maxRange < Math.Abs(ranges[i] - i) + 1)
                maxRange = Math.Abs(ranges[i] - i) + 1;
        }

        return maxRange;
    }
}
