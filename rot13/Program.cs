using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

class Rot13 {
  static void Main() {
    static string Rot13(string message)
    {
      string decoded = "";
      string code = "abcdefghijklmnopqrstuvwxyz";
      foreach (char ch in message) {
        bool upper = Char.IsUpper(ch);
        if (code.Contains(Char.ToLower(ch))) {
          int i = code.IndexOf(Char.ToLower(ch));
          i += (i > 12) ? -13 : 13;
          decoded += upper ? Char.ToUpper(code[i]) : code[i];    
        } else {
          decoded += ch;
        }      
      }
    return decoded;
    }
    Console.WriteLine(Rot13("test"));
    Console.WriteLine(Rot13("Test"));
  }
}

