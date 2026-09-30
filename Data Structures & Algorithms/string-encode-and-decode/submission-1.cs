public class Solution {

    public string Encode(IList<string> strs) {
        string output = "";

        foreach(string str in strs) {
            output += str.Length + "!" + str;
        }

        return output;
    }

    public List<string> Decode(string s) {
        List<string> strs = new List<string>();
        
        while(s.Length > 0) {
            int index = s.IndexOf("!");
            int i = int.Parse(s.Substring(0, index));
            strs.Add(s.Substring(index + 1, i));
            s = s.Substring(index + i + 1);
        }

        return strs;
   }
}
