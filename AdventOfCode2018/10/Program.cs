using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace AdventOfCode10 {
    class Program {
        static void Main(string[] args) {
            var points = new List<Point>();
            using (var sr = new StreamReader("input.txt")) {
                int id = 0;
                while (!sr.EndOfStream) {
                    var line = sr.ReadLine();
                    var r = new Regex(@"position=<\s?(?<X>\-?\d+),\s\s?(?<Y>\-?\d+)> velocity=<\s?(?<VX>\-?\d+),\s\s?(?<VY>\-?\d+)>");
                    var match = r.Match(line);
                    if (!match.Success) {
                        throw new Exception("Input not matched");
                    }
                    var point = new Point() {
                        ID = id++,
                        X = int.Parse(match.Groups["X"].Value),
                        Y = int.Parse(match.Groups["Y"].Value),
                        VX = int.Parse(match.Groups["VX"].Value),
                        VY = int.Parse(match.Groups["VY"].Value),
                    };
                    points.Add(point);
                }
            }

            var field = new Field(points);
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var time = field.FineTuning();
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            var message = field.ToString();
            using (var sw = new StreamWriter("output.txt")) {
                sw.WriteLine($"Calculation time: {elapsedMs / 1000}. Virtual seconds: {time}");
                sw.Write(message);
            }
            Console.WriteLine($"Calculation time: {elapsedMs / 1000}. Virtual seconds: {time}");
            Console.Write(message);
        }
    }
}