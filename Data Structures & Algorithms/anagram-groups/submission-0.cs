public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> maps = new Dictionary<string, List<string>>();

        foreach(string str in strs) {
            int[] counts = new int[26];

            foreach(char c in str.ToCharArray()) {
                counts[c-'a']++;
            }

            string key = string.Join(",", counts);
            if(!maps.ContainsKey(key)) maps[key] = new List<string>();
            maps[key].Add(str);
        }

        return maps.Values.ToList();
    }
}
