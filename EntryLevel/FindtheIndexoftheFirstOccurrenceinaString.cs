public class Solution {
    public int StrStr(string haystack, string needle) {
        int hLength = haystack.Length;
        int nLength = needle.Length;

        for (int i = 0; i <= hLength - nLength; i++) {
            if (haystack.Substring(i, nLength) == needle) {
                return i; 
            }
        }
        
        
        return -1; 
    }
}