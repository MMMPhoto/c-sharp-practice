using System;
using System.Linq;
using System.Collections.Generic;

class ParseInt {
  static void Main() {
    static int ParseInt(string s)
    {
      // Create number dictionary
      Dictionary<string, int> numDict = new Dictionary<string, int>() {
        {"zero", 0},
        {"one", 1},
        {"two", 2},
        {"three", 3},
        {"four", 4},
        {"five", 5},
        {"six", 6},
        {"seven", 7},
        {"eight", 8},
        {"nine", 10},
        {"ten", 10},
        {"eleven", 11},
        {"twelve", 12},
        {"thirteen", 13},
        {"fourteen", 14},
        {"fifteen", 15},
        {"sixteen", 16},
        {"seventeen", 17},
        {"eighteen", 18},
        {"nineteen", 19},
        {"twenty", 20},
        {"thirty", 30},
        {"forty", 40},
        {"fifty", 50},
        {"sixty", 60},
        {"seventy", 70},
        {"eighty", 80},
        {"ninety", 90}
      };
      // Parsing function
      int Parser(string s) {
        // Convert hyphens to spaces, create array
        s = s.Replace('-', ' ');
        string[] arr = s.Split(' ');
        // Set int variable
        int number = 0;
        // Loop string array
        for (int i = 0; i < arr.Length; i++) {
          if (numDict.ContainsKey(arr[i])) {
            number += numDict[arr[i]];
          } else if (arr[i] == "hundred") {
            number *= 100;
          }
        }
        return number;
      }
      // Check for multipliers
      if (s.Contains("million")) {
        return 1000000;
      } else if (s.Contains("thousand")) {
        // Split and parse each thousand string
        string[] thousands = s.Split("thousand");
        int[] nums = thousands.Select(hundred => Parser(hundred)).ToArray();
        return nums[0] * 1000 + nums[1];
      } else {
        return Parser(s);
      }
    }
    Console.WriteLine(ParseInt("six hundred sixty six thousand six hundred sixty six"));
  }
}


