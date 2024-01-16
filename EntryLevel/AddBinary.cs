using System;

public class Solution {
    public string AddBinary(string a, string b) {
        
        // Convert binary strings to decimal
        int deca = Convert.ToInt32(a, 2);
        int decb = Convert.ToInt32(b, 2);

        // Sum the decimal numbers
        int sum = deca + decb;

        // Convert the sum back to binary and return
        return Convert.ToString(sum, 2);
    }
}