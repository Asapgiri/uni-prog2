namespace Shapes {
    internal class Circle : Shape {
        double radius = 0.0;

        public double Radius { get => radius; set => radius = value; }

        public Circle(double radius, string color) : base(color) {
            this.radius = radius;
        }

        public override double Perimeter() {
            return 2 * Math.PI * this.radius;
        }

        public override double Area() {
            return Math.PI * this.radius * this.radius;
        }

        public override string ToString() {
            return $"{base.ToString()} (Circle)";
        }

        public override bool Equals(object? obj) {
            if (null == obj || obj.GetType() != this.GetType()) {
                return false;
            }

            return this.radius == (obj as Circle).Radius;
        }
    }
}
