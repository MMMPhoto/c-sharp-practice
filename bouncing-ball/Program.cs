
using System;
using System.Linq;
using System.Collections.Generic;

class BouncingBall {
  static void Main() {
    static int bouncingBall(double h, double bounce, double window) {
      if (h > 0 && window < h && bounce > 0 && bounce < 1 ) {
        int times = 1;
        while (h * bounce > window) {
          times = times + 2;
          h = h * bounce;
        }
        return times;
      } else {
        return -1;
      }
    }
    Console.WriteLine(bouncingBall(3.0, 0.66, 1.5));
    Console.WriteLine(bouncingBall(30.0, 0.66, 1.5));
  }
}

