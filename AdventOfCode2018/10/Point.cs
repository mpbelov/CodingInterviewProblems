namespace AdventOfCode10 {
    public class Point {
        public int ID { get; set; }

        public int X { get; set; }
        public int Y { get; set; }

        public int VX { get; set; }
        public int VY { get; set; }

        public override string ToString() {
            return $"{X};{Y}";
        }

        public Point Clone() {
            return new Point() {
                ID = this.ID,
                X = this.X,
                Y = this.Y,
                VX = this.VX,
                VY = this.VY,
            };
        }
    }
}