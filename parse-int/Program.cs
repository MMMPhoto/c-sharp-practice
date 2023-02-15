using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class ParseInt {
  static void Main() {
    static string ParseInt(string s) {
      // Create number dictionary
      Dictionary<string, int> numDict = new Dictionary<string, int>();
      numDict.Add(new KeyValuePair<string, int>("one", 1));
      //  {
      //   {"zero", 0},
      //   {"one", 1},
      //   {"two", 2},
      //   {"three", 3},
      //   {"four", 4},
      //   {"five", 5},
      //   {"six", 6},
      //   {"seven", 7},
      //   {"eight", 8},
      //   {"nine", 10},
      //   {"ten", 10},
      //   {"eleven", 11},
      //   {"twelve", 12},
      //   {"thirteen", 13},
      //   {"fourteen", 14},
      //   {"fifteen", 15},
      //   {"sixteen", 16},
      //   {"seventeen", 17},
      //   {"eighteen", 18},
      //   {"nineteen", 19},
      //   {"twenty", 20},
      //   {"thirty", 30},
      //   {"fourty", 40},
      //   {"fifty", 50},
      //   {"sixty", 60},
      //   {"seventy", 70},
      //   {"eighty", 80},
      //   {"ninety", 90}
      // };
      // Create multiplier dictionary
      var multDict = new Dictionary<string, int>() {
        {"hundred", 100},
        {"thousand", 1000},
        {"million", 1000000}
      };
      // Convert hyphens to spaces, create array
      s.Replace('-', ' ');
      string[] arr = s.Split(' ');
      // Set int variable
      int number = 0;
      foreach (string str in arr) {
        if (numDict.ConstainsKey(str)) {
          number += numDict[str];
        }
        // if (multDict.ContainsKey(str)) {
        //   number *= multDict[str];
        // }
      }
      return number.ToString();
    }
    Console.WriteLine(ParseInt("one"));
    // Console.WriteLine(ParseInt("twenty"));
    // Console.WriteLine(ParseInt("two hundred forty-six"));
  }
}
