using System;
using System.Collections.Generic;

namespace aoc {
    public class Day1_Part1 {
        public static void Main (string[] args) {
            var lines = System.IO.File.ReadAllLines(@"input.file");
            int count = 0;
            var sums = new List<int>();

            for ( var i = 0; true; i++) {
                if (string.IsNullOrWhiteSpace(lines[i+2])) 
                    break;
                sums.Add(int.Parse(lines[i]) + int.Parse(lines[i+1]) + int.Parse(lines[i+2]));
            }

            for (var i = 0; i < sums.Count -1; i++) {
                if ( sums[i] < sums[i+1]) {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}