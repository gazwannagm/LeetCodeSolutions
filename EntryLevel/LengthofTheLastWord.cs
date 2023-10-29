public class Solution {
    public int LengthOfLastWord(string s) {
         s = s.TrimEnd(); 

        if (string.IsNullOrEmpty(s)) {
            return 0; 
        }

        int lastIndex = s.LastIndexOf(' ');
        if (lastIndex == -1) {
            return s.Length; 
        }

        string lastword = s.Substring(lastIndex + 1);
        return lastword.Length;
    }
}
