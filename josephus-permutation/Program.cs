using System;
using System.Linq;
using System.Collections.Generic;

class JosephusPermutation {
  static void Main() {
    static List<object> JosephusPermutation(List<object> items, int k) {
      // New list object
      List<object> newList = new List<object>();
      // Track postion
      int pos = 0;
      // Loop list and iterate by k
      while (items.Count > 0) {
        pos = (pos + k - 1) % items.Count;
        // Move from old list to new
        newList.Add(items[pos]);
        items.RemoveAt(pos);
      }
      return newList;
	  }
    Console.WriteLine(JosephusPermutation(new List<object> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 1));
    Console.WriteLine(JosephusPermutation(new List<object> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 2));
    Console.WriteLine(JosephusPermutation(new List<object> { "C", "o", "d", "e", "W", "a", "r", "s" }, 4));
    Console.WriteLine(JosephusPermutation(new List<object> { 1, 2, 3, 4, 5, 6, 7 }, 3));
    Console.WriteLine(JosephusPermutation(new List<object> { }, 3));
  }
}
