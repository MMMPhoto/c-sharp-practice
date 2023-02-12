using System;
using System.Linq;
using System.Collections.Generic;

class ReverseWords {
  static void Main() {
    static string ReverseWords(string str) {
      char[] arr = str.ToCharArray(0, str.Length);
      string newString = "";
      string tempString = "";
      foreach (char ch in arr) {
        if (ch == ' ' ) {
          char[] tempArr = tempString.ToCharArray();
          Array.Reverse(tempArr);
          newString += new string(tempArr);
          newString += ch.ToString();
          tempString = "";
        } else {
          tempString += ch.ToString();
        }
      }
      char[] lastTempArr = tempString.ToCharArray();
      Array.Reverse(lastTempArr);
      newString += new string(lastTempArr);
      return newString;
    }
    Console.WriteLine(ReverseWords("This is an example!"));
  }
}


