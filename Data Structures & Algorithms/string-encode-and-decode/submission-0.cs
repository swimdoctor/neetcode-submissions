public class Solution {

    public string Encode(IList<string> strs) {
        string output = "";

        foreach(string str in strs) {
            string encoded = str.Replace("\\", "\\\\");
            output += encoded + " \\|";
        }

        return output;
    }

    public List<string> Decode(string s) {
        List<string> strs = s.Split(" \\|").ToList();
        strs.RemoveAt(strs.Count - 1);

        for(int i = 0; i < strs.Count; i++) {
            strs[i] = strs[i].Replace("\\\\", "\\");
        }

        return strs;
   }
}
