public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> sDict = new Dictionary<char,int>();
        Dictionary<char, int> tDict = new Dictionary<char,int>();

        foreach(char c in s.ToCharArray()) {
            if(sDict.ContainsKey(c)) sDict[c]++;
            else sDict[c] = 1;
        }
        foreach(char c in t.ToCharArray()) {
            if(tDict.ContainsKey(c)) tDict[c]++;
            else tDict[c] = 1;
        }

        foreach(char key in sDict.Keys) {
            if(!tDict.ContainsKey(key) || tDict[key] != sDict[key]) return false;
            tDict.Remove(key);
        }

        return tDict.Keys.Count == 0;
    }
}
