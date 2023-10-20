public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs.Length == 0) return "";
        
        string minStr = strs[0];

        for (int i = 1; i < strs.Length; i++) {
            if (strs[i].Length < minStr.Length) {
                minStr = strs[i];
            }
        }

        int end = minStr.Length;
        for (int i = 0; i < strs.Length; i++) {
            int j;
            for (j = 0; j < end; j++) {
                if (minStr[j] != strs[i][j]) {
                    break;
                }
            }
            if (j < end) {
                end = j;
            }
        }

        return minStr.Substring(0, end);
    }
}