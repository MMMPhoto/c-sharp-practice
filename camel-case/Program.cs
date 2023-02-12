using System;
using System.Linq;
using System.Collections.Generic;

class CamelCase {
  static void Main() {
    static string BreakCamelCase(string str) {
      char[] arr = str.ToCharArray();
      List<int> caps = new List<int>(); 
      for (int i = 0; i < arr.Length; i++) {
        if (char.IsUpper(arr[i])) {
          caps.Add(i);
        }
      }
      string final = "";
      for (int i = 0; i < caps.Count; i++) {
        if (i == 0) {
          final += str.Substring(0, caps[i]) + " ";
        } else {
          final += str.Substring(caps[i - 1], (caps[i] - caps[i - 1])) + " ";
        }
          if (i == (caps.Count - 1)) {
            final += str.Substring(caps[i]);
          }
        }
      return final;
    }
    Console.WriteLine(BreakCamelCase("camelCasing"));
    Console.WriteLine(BreakCamelCase("camelCasingTest"));
  }
}

