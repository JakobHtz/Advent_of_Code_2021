using System;
using System.Collections.Generic;

namespace aoc {
    public class Day3_Part1 {
        public static void Main (string[] args) {
            var lines = System.IO.File.ReadAllLines(@"input.file");
            var bits = new int[12];
            var gammaString = "";

            foreach ( var line in lines ) {
                if (string.IsNullOrWhiteSpace(line)) 
                    break;

                for (var i = 0; i < line.Length; i++) {
                    if (line[i] == '1') {
                        bits[i] += 1;
                    }
                }
            }

            foreach (var bit in bits) {
                if (bit >= lines.Length/2) {
                    gammaString += "1";
                }
                else {
                    gammaString += "0";
                }
            }

            var gamma = Convert.ToInt32(gammaString, 2);
            var epsilon = ~gamma & 0xFFF;

            Console.WriteLine((long)gamma*(long)epsilon);
        }
    }
}