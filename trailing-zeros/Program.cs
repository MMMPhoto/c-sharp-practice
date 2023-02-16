using System;
using System.Linq;
using System.Collections.Generic;

class TrailingZeros {
  static void Main() {
    static int TrailingZeros(int n)
    {
      int x = 0;
      int DivByFive(int n) {
        n = n / 5;
        x += n;
        return (n < 5) ? x : DivByFive(n);
      }
      return DivByFive(n);
    }
    Console.WriteLine(TrailingZeros(5));
    Console.WriteLine(TrailingZeros(25));
    Console.WriteLine(TrailingZeros(531));
  }
}


