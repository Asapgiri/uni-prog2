namespace Shapes {
    internal class Rectangle : Shape {
        double height = 0.0;
        double width = 0.0;

        public double Height { get => height; set => height = value; }
        public double Width { get => width; set => width = value; }

        public Rectangle(double height, double width, string color) : base(color) {
            this.height = height;
            this.width = width;
        }

        public override string ToString() {
            return $"{base.ToString()} (Rectangle)";
        }

        public override double Perimeter() {
            return 2 * (height + width);
        }

        public override double Area() {
            return height * width;
        }

        public override bool Equals(object? obj) {
            if (null == obj || obj.GetType() != this.GetType()) {
                return false;
            }

            Rectangle other = obj as Rectangle;
            return this.height == other.Height && this.width == other.Width;
        }
    }
}
