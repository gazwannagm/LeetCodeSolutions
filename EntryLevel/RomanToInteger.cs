public class Solution {
    public int RomanToInt(string s) {

        Dictionary<string, int> map = new Dictionary<string, int>();
        int sum = 0;
        map.Add("I", 1);
        map.Add("V", 5);
        map.Add("X", 10);
        map.Add("L", 50);
        map.Add("C", 100);
        map.Add("D", 500);
        map.Add("M", 1000);
        
        s = s.Replace("IV", "IIII");
        s = s.Replace("IX", "VIIII");
        s = s.Replace("XL", "XXXX");
        s = s.Replace("XC", "LXXXX");
        s = s.Replace("CD", "CCCC");
        s = s.Replace("CM", "DCCCC");

        for (int i = 0; i < s.Length; i++) {
            sum = sum + map[s[i].ToString()]; 
        }
        
        return sum;
    }
}