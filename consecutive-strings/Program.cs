using System;
using System.Linq;
using System.Collections.Generic;

class ConsecutiveStrings {
  static void Main() {
    static string ConsecutiveStrings(string[] strarr, int k) {
      // Set string variable
      string longestStr = "";
      
      // Iterate through array
      for (int i = 0; i < strarr.Length - k + 1; i++) {
        // Build test string
        string test = "";
        for (int j = 0; j < k; j++) {
          test += strarr[i + j];
        }
        // Check if test is longer than longest string
        if (test.Length > longestStr.Length) {
          longestStr = test;
        }
      }
      return longestStr;
    }
    Console.WriteLine(ConsecutiveStrings(new String[] {"zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail"}, 2));
    Console.WriteLine(ConsecutiveStrings(new String[] {"ejjjjmmtthh", "zxxuueeg", "aanlljrrrxx", "dqqqaaabbb", "oocccffuucccjjjkkkjyyyeehh"}, 1));
    Console.WriteLine(ConsecutiveStrings(new String[] {}, 3));
  }
}
