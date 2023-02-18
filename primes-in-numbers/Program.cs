using System;
using System.Linq;
using System.Collections.Generic;

class PrimesInNumbers {
  static void Main() {
    static string Factors(int lst)
    {
      // Set string to print
      string output = "";
      // Loop primes to test
      for (int i = 2; i < lst + 1; i++) {
        // Check if fac divisible and count
        int count = 0;
        while (lst % i == 0) {
          lst = lst / i;
          count++;
        }
        // Print fac w/ count
        if (count > 1) {
          output += $"({i}**{count})";
        } else if (count == 1) {
          output += $"({i})";
        }
      }
      return output;
    }
    Console.WriteLine(Factors(7775460));
  }
}


