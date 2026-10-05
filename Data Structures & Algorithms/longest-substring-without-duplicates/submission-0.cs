public class Solution {
    public int LengthOfLongestSubstring(string s) {
        string current = "";
        int maxLen = 0;

        foreach(char c in s) {
            if(current.IndexOf(c) == -1) {
                current += c;
                if(current.Length > maxLen) maxLen = current.Length;
            }
            else {
                current = current.Substring(current.IndexOf(c) + 1);
                current += c;
            }
        }

        return maxLen;
    }
}
