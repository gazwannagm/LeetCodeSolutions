public class Solution {
public bool BackspaceCompare(string s, string t) {
    int i = s.Length - 1;
    int j = t.Length - 1;
    
    
    while (i >= 0 || j >= 0) {
        int backspaces = 0;
        
        while (i >= 0 && (s[i] == '#' || backspaces > 0)) {
            backspaces += s[i] == '#' ? 1 : -1;
            i--;
        }
        
        backspaces = 0;
        while (j >= 0 && (t[j] == '#' || backspaces > 0)) {
            backspaces += t[j] == '#' ? 1 : -1;
            j--;
        }
        
        if (i < 0 || j < 0) {
            return i == j;  // this checks if both strings are finished
        }
        
        if (s[i] != t[j]) {
            return false;
        }
        
        i--;
        j--;
    }
    
    return true;
}
}
