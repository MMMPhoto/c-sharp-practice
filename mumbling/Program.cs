using System;
using System.Linq;
using System.Collections.Generic;

class Accum {
  static void Main() {
    static String Accum(string s) {
      string[] arr = new string[s.Length];
      for(int i = 0; i < arr.Length; i++) {
        string str = "";
        for (int j = 0; j < i + 1; j++) {
          if (j == 0) {
            str += s[i].ToString().ToUpper();
          } else {
            str += s[i].ToString().ToLower();
          }
          arr[i] = str;
        }
      }
      return String.Join("-", arr);
    }
    Console.WriteLine(Accum("ZpglnRxqenU"));
    Console.WriteLine(Accum("NyffsGeyylB"));
    Console.WriteLine(Accum("MjtkuBovqrU"));
    Console.WriteLine(Accum("EvidjUnokmM"));
    Console.WriteLine(Accum("HbideVbxncC"));
  }
}


