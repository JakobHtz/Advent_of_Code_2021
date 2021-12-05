using System;
using System.Collections.Generic;
using System.Linq;

namespace aoc {
    public class Day3_Part2 {

        public static void Main (string[] args) {
            var lines = System.IO.File.ReadAllLines(@"input.file");
            var lineList = new List<string>(lines);

            for (var i = 0; i < lineList[0].Length; i++) {
                var mostCommonBits = GetMostCommonBits(lineList);
                var freshhold = lineList.Count/2;
                lineList.RemoveAll(
                    (string num) => {
                        var isBitSet = (Convert.ToInt32(num, 2) & (int)Math.Pow(2, num.Length-1 - i)) > 0;
                        var shouldBitBeSet = (mostCommonBits[i] >= freshhold);
                        return isBitSet != shouldBitBeSet;
                    });
                if (lineList.Count <= 1) {
                    break;
                }
            }
            var oxygen = lineList.First();

            lineList = new List<string>(lines);
            for (var i = 0; i < lineList[0].Length; i++) {
                var mostCommonBits = GetMostCommonBits(lineList);
                var freshhold = lineList.Count/2;
                lineList.RemoveAll(
                    (string num) => {
                        var isBitSet = (Convert.ToInt32(num, 2) & (int)Math.Pow(2, num.Length-1 - i)) > 0;
                        var shouldBitBeSet = mostCommonBits[i] < freshhold;
                        return isBitSet != shouldBitBeSet;
                    });
                if (lineList.Count <= 1) {
                    break;
                }
            }
            var co2 = lineList.First();

            Console.WriteLine(co2 +" - "+Convert.ToInt32(co2, 2) +"*"+ oxygen + " - " + Convert.ToInt32(oxygen, 2));
        }

        private static List<int> GetMostCommonBits(List<string> lineList) {
            var bits = new List<int>(new int[lineList.First().Length]);

            foreach ( var line in lineList ) {
                if (string.IsNullOrWhiteSpace(line)) 
                    break;

                for (var i = 0; i < line.Length; i++) {
                    if (line[i] == '1') {
                        bits[i] += 1;
                    }
                }
            }
            return bits;
        }
    }
}