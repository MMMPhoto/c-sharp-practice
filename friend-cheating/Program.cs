using System;
using System.Linq;
using System.Collections.Generic;

class FriendCheating {
  static void Main() {
    static List<long[]> removNb(long n) {
      // Get total sum
	    long sum = Enumerable.Range(1, (int)n).ToArray().Select(i => (long)i).Aggregate((a, b) => a + b);
      // Create List<long>[] var
      List<long[]> output = new List<long[]> {};
      // Check each number 1 to n
      for (int i = 1; i < (int)n + 1; i++) {
        decimal pair = ((decimal)sum - (decimal)i) / ((decimal)i + 1);
        if (pair % 1 == 0 && pair <= (int)n) {
          output.Add(new long[] { (long)i, (long)pair });          
        }
      }
		  return output;
	  }
    Console.WriteLine(removNb(26));
  }
}

	
  
  
