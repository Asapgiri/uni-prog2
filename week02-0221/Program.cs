namespace Shapes {
    internal class Program {
        static void Main() {
            Rectangle rect = new Rectangle(10, 12, "pink");
            Square square = new Square(10, "green");
            Circle circle = new Circle(5, "red");
            Square sc1 = new Square(1, "brown");

            Console.WriteLine(rect);
            Console.WriteLine(square);
            Console.WriteLine(circle);
            Console.WriteLine(sc1);

            Console.WriteLine();
            ShapeHandler.Holey(rect);
            ShapeHandler.Holey(square);
            ShapeHandler.Holey(circle);
            ShapeHandler.Holey(sc1);
            Console.WriteLine();

            Rectangle new_rect1 = ShapeHandler.CreateRectOrSquare(10, 3, "pink");
            Rectangle new_rect2 = ShapeHandler.CreateRectOrSquare(10, 30, "pink");
            Rectangle new_rect3 = ShapeHandler.CreateRectOrSquare(10, 10, "pink");

            Console.WriteLine();
            Console.WriteLine(new_rect1);
            Console.WriteLine(new_rect2);
            Console.WriteLine(new_rect3);
            Console.WriteLine();

            Console.WriteLine("Create array!");
            Shape[] shapes = new Shape[] {
                rect,
                square,
                circle,
                new_rect1,
                new_rect3
            };

            Console.WriteLine("Shapes in array:");
            for (int i = 0; i < shapes.Length; i++) {
                Console.WriteLine(shapes[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Shape with the highest area:");
            Console.WriteLine(ShapeHandler.GetLargestShapeArea(shapes));
        }

    }
}
