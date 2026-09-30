public class Solution {
    public bool IsPalindrome(string s) {
        s = s.ToLower();
        int i = 0; 
        int j = s.Length - 1;
        while(i < s.Length && !Char.IsLetterOrDigit(s, i)) i++;
        while(j >= 0 && !Char.IsLetterOrDigit(s, j)) j--;

        while(i <= j) {
            Console.WriteLine(i + ":" + s[i] + " " + j + ":" + s[j]);
            if(s[i] != s[j]) return false;
            i++;
            j--;
            
            while(i < s.Length && !Char.IsLetterOrDigit(s, i)) i++;
            while(j >= 0 && !Char.IsLetterOrDigit(s, j)) j--;
        }

        return true;
    }
}
