namespace Shapes {
    internal static class ShapeHandler {
        public static void Holey(Shape shape) {
            if (shape.Area() > shape.Perimeter()) {
                shape.MakeHoley();
                Console.WriteLine($"Holeyed: {shape}");
            }
        }

        public static Rectangle CreateRectOrSquare(double width, double height, string color) {
            if (width == height) {
                Console.WriteLine("Creating Square..");
                return new Square(width, color);
            }
            else {
                Console.WriteLine("Creating Rectangle..");
                return new Rectangle(height, width, color);
            }
        }

        public static Shape GetLargestShapeArea(Shape[] shapes) {
            Shape largersShape = shapes[0];

            for (int i = 1; i < shapes.Length; i++) {
                if (shapes[i].Area() > largersShape.Area()) {
                    largersShape = shapes[i];
                }
            }

            return largersShape;
        }
    }
}
