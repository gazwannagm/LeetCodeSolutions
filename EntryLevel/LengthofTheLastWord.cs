public class Solution {
    public int LengthOfLastWord(string s) {
         s = s.TrimEnd(); 
        if (string.IsNullOrEmpty(s)) {
            return 0; 
        }
        string lastword = s.Substring(s.LastIndexOf(' ') + 1);
        return lastword.Length;
    }
}
