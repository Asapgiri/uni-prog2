namespace Shapes {
    internal class Square : Rectangle {
        public Square(double width, string color) : base(width, width, color) {}

        public override bool Equals(object? obj) {
            if (null == obj || obj.GetType() != this.GetType()) {
                return false;
            }

            Rectangle other = obj as Square;
            return this.Height == other.Height;
        }
    }
}
