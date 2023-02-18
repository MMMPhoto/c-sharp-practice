using System;
using System.Linq;
using System.Collections.Generic;

class SimplePigLatin {
  static void Main() {
    static string PigIt(string str)
    {
      string newStr = "";
      string[] arr  = str.Split(" ");
      foreach (string st in arr) {
        if (Char.IsLetter(st[0])) {
          newStr += st.Substring(1) + st[0] + "ay ";
        } else {
          newStr += st;
        }
      }
      return newStr[newStr.Length - 1] == ' ' ? newStr.Remove(newStr.Length -1, 1) : newStr;
    }
    Console.WriteLine(PigIt("Pig latin is cool"));
    Console.WriteLine(PigIt("This is my string"));
  }
}


