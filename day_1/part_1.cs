using System;

namespace aoc {
    public class Day1_Part1 {
        public static void Main (string[] args) {
            var lines = System.IO.File.ReadAllLines(@"input.file");
            int count = 0;

            for (var i = 0; i < lines.Length -1; i++) {
                if ((!string.IsNullOrWhiteSpace(lines[i+1])) && int.Parse(lines[i]) < int.Parse(lines[i+1])) {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}