namespace Shapes {
    internal abstract class Shape {
        bool isHoley = false;
        string color = string.Empty;

        public string Color { get => color; set => color = value; }

        public Shape(string color, bool isHoley = false) {
            this.isHoley = isHoley;
            this.color = color;
        }

        public void MakeHoley() {
            this.isHoley = true;
        }

        public override string ToString() {
            string ret = this.color;

            if (this.isHoley) {
                ret += " (holey)";
            }

            return $"{ret}, Perimeter: {this.Perimeter()}, Area: {this.Area()}";
        }

        public abstract double Perimeter();
        public abstract double Area();
    }
}
