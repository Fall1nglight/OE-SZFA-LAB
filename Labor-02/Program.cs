namespace Labor_02;

internal class Program
{
    public static void Main(string[] args)
    {
        Circle circle1 = new Circle(10, false, "red");
        Circle circle2 = new Circle(3, true, "green");
        Rectangle rectangle1 = new Rectangle(5, 6, false, "blue");
        Rectangle rectangle2 = new Rectangle(10, 1, true, "yellow");
        Square sqare = new Square(7, false, "black");

        Shape[] shapes = { circle1, circle2, rectangle1, rectangle2, sqare };

        #region 1. exercise
        Console.WriteLine("[1] Shapes in array");

        foreach (var t in shapes)
        {
            Console.WriteLine(t);
        }

        Console.WriteLine("=======");
        #endregion

        #region 2. exercise
        Console.WriteLine("[2] Make shape holey if its area is bigger than perimeter");

        foreach (var t in shapes)
        {
            MakeShapeHoleyIfAreaBiggerThanPerimeter(t);
            Console.WriteLine(t);
        }

        Console.WriteLine("=======");
        #endregion

        #region 3. exercise
        Console.WriteLine("[3] Create a Square or Rectangle based on width and height");
        Console.Write("Height: ");
        var height = int.Parse(Console.ReadLine()!);

        Console.Write("Width: ");
        var width = int.Parse(Console.ReadLine()!);

        Console.Write("Is Holey? (true / false): ");
        var isHoley = bool.Parse(Console.ReadLine()!);

        Console.Write("Color: ");
        var color = Console.ReadLine()!;

        var newShape = MakeRectangleOrSquare(height, width, isHoley, color);

        Console.WriteLine($"Created shape: {newShape}");
        Console.WriteLine("=======");
        #endregion

        #region 4. exercise
        Console.WriteLine("[4] Select Shape with the biggest perimeter");

        int largestIdx = GetLargestPerimeterShape(shapes);

        Console.WriteLine(shapes[largestIdx]);
        #endregion

        void MakeShapeHoleyIfAreaBiggerThanPerimeter(Shape shape)
        {
            if (shape.Area() > shape.Perimeter())
                shape.MakeHoley();
        }

        Shape MakeRectangleOrSquare(int sHeight, int sWidth, bool sIsHoley, string sColor)
        {
            return sHeight == sWidth
                ? new Square(sHeight, sIsHoley, sColor)
                : new Rectangle(sHeight, sWidth, sIsHoley, sColor);
        }

        int GetLargestPerimeterShape(IReadOnlyList<Shape> arrOfShapes)
        {
            int maxIdx = 0;

            for (var i = 1; i < arrOfShapes.Count; i++)
            {
                if (arrOfShapes[i].Perimeter() > arrOfShapes[0].Perimeter())
                    maxIdx = i;
            }

            return maxIdx;
        }
    }
}
