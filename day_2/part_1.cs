using System;
using System.Collections.Generic;

namespace aoc {
    public class Day2_Part1 {
        public static void Main (string[] args) {
            var lines = System.IO.File.ReadAllLines(@"input.file");
            int depth = 0;
            int distance = 0;

            foreach ( var line in lines ) {
                if (string.IsNullOrWhiteSpace(line)) 
                    break;
                var instruction = line.Split(" ");
                switch (instruction[0]) {
                    case "forward":
                        distance += int.Parse(instruction[1]);
                        break;
                    case "up":
                        depth -= int.Parse(instruction[1]);
                        break;
                    case "down":
                        depth += int.Parse(instruction[1]);
                        break;
                }
            }

            Console.WriteLine(depth * distance);
        }
    }
}