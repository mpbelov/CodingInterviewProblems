using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode10 {
    public class Field {
        public Field(IReadOnlyList<Point> points) {
            _points = points;
        }
        IReadOnlyList<Point> _points;

        public long FineTuning() {
            long time = 0;
            while (!areAligned()) {
                time++;
                foreach (var p in _points) {
                    p.X += p.VX;
                    p.Y += p.VY;
                }
            }
            return time;
        }

        private static void normalize(IEnumerable<Point> points) {
            var minX = int.MaxValue;
            var minY = int.MaxValue;

            foreach (var p in points) {
                minX = Math.Min(minX, p.X);
                minY = Math.Min(minY, p.Y);
            }

            foreach (var p in points) {
                p.X -= minX;
                p.Y -= minY;
            }
        }

        public static (Point, Point, Point, Point) getCorners(IEnumerable<Point> points) {
            var leftPoint = points.First();
            var topPoint = leftPoint;
            var rightPoint = leftPoint;
            var bottomPoint = leftPoint;
            foreach (var p in points) {
                if (leftPoint.X > p.X) {
                    leftPoint = p;
                }
                if (topPoint.Y > p.Y) {
                    topPoint = p;
                }
                if (rightPoint.X < p.X) {
                    rightPoint = p;
                }
                if (bottomPoint.Y < p.Y) {
                    bottomPoint = p;
                }
            }

            return (leftPoint, topPoint, rightPoint, bottomPoint);
        }

        private bool areAligned() {
            var g = buildGraph();
            var ccBuilder = new ConnectedComponents(g);
            var ccs = ccBuilder.Build();

            return ccs.Count < 50;
        }

        private Graph buildGraph() {
            var g = new Graph();
            for (int i = 0; i < _points.Count; i++) {
                for (int j = i + 1; j < _points.Count; j++) {
                    var p1 = _points[i];
                    var p2 = _points[j];
                    if (p1.ID == p2.ID) {
                        continue;
                    }
                    g.AddVertex(p1.ID.ToString());
                    g.AddVertex(p2.ID.ToString());
                    if (adj(p1, p2)) {
                        g.AddEdge(p1.ID.ToString(), p2.ID.ToString());
                    }
                }
            }
            return g;
        }

        private bool adj(Point p1, Point p2) {
            var x = Math.Abs(p1.X - p2.X);
            var y = Math.Abs(p1.Y - p2.Y);
            return (x <= 1 && y == 0) || (x == 0 && y <= 1);
        }

        public override string ToString() {
            var points = new List<Point>(_points.Count);
            foreach (var p in _points) {
                points.Add(p.Clone());
            }
            normalize(points);
            var (leftPoint, topPoint, rightPoint, bottomPoint) = getCorners(points);
            // var field = new Dictionary<string, Point>();
            var field = new HashSet<string>();
            foreach (var p in points) {
                // field[p.ToString()] = p;
                if (!field.Contains(p.ToString())) {
                    field.Add(p.ToString());
                }
            }
            var sb = new StringBuilder();
            for (var line = 0; line <= bottomPoint.Y; line++) {
                for (var col = 0; col <= rightPoint.X; col++) {
                    // sb.Append(field.ContainsKey($"{col};{line}") ? field[$"{col};{line}"].ID.ToString("D2") : "--");
                    sb.Append(field.Contains($"{col};{line}") ? "0" : "-");
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}