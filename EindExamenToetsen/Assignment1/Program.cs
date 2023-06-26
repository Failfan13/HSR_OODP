public class Program
{
    static void Main(string[] args)
    {
        switch (args[1])
        {
            case "IResizable": TestIResizable(); return;
            case "IEquatable": TestIEquatable(); return;
            case "Inheritance": TestInheritance(); return;
            case "IComparable": TestIComparable(); return;
            case "Implement": TestImplementIResizable(); return;
            case "Utils": TestUtils(); return;
            default: throw new ArgumentException();
        }
    }

    static void TestImplementInterfaces()
    {
        // Test whether the classes have implemented the interfaces.
        // If there is a compilation error here,
        // one or more interfaces have not been implemented.
        IComparable<Rectangle> comparableRectangle = new Rectangle(5, 10, 1);
        IEquatable<Shape> equatableShape = new Shape(5, 10, 1);
        IResizable resizableRectangle = new Rectangle(5, 10, 1);
    }

    static void TestIResizable()
    {
        // Test whether IResizable is an interface
        // and has the correct method signature.
        Type resizableType = typeof(IResizable);
        bool isResizableInterface = resizableType.IsInterface;
        bool hasResizeMethod = resizableType.GetMethod("Resize") != null;

        Console.WriteLine($"IResizable is an interface: {isResizableInterface}");
        Console.WriteLine($"IResizable has the Resize method: {hasResizeMethod}");
    }

    static void TestWhereConstraint()
    {
        // Test whether Utils.DoubleSize uses the 'where' constraint
        // to limit the parameter to IResizables.
        // If there is a compilation error here,
        // it is not implemented (correctly).
        Utils.DoubleSize<IResizable>(new Circle());
    }

    static void TestIEquatable()
    {
        // Test whether Shape has implemented IEquatable correctly.
        object shape1 = new Shape(5, 10, 1); //Object
        Shape shape2 = new(5, 10, 1);
        Shape shape3 = new(5, 10, 2);
        object rectangle1 = new Rectangle(5, 10, 1); //Object
        Rectangle rectangle2 = new(10, 5, 1);

        bool shapeEquality1 = shape1.Equals(shape2);
        bool shapeEquality2 = shape1.Equals(shape3);
        bool shapeEquality3 = shape1.Equals(rectangle1);
        bool shapeEquality4 = rectangle1.Equals(shape1);
        bool shapeEquality5 = rectangle1.Equals(rectangle2);
        bool shapeEquality6 = rectangle1.Equals(null);
        bool shapeEquality7 = rectangle1.Equals(new List<int>());

        Console.WriteLine($"Shape equality result 1: {shapeEquality1}"); // true
        Console.WriteLine($"Shape equality result 2: {shapeEquality2}"); // false
        Console.WriteLine($"Shape equality result 3: {shapeEquality3}"); // true
        Console.WriteLine($"Shape equality result 4: {shapeEquality4}"); // true
        Console.WriteLine($"Shape equality result 5: {shapeEquality5}"); // false
        Console.WriteLine($"Shape equality result 6: {shapeEquality6}"); // false
        Console.WriteLine($"Shape equality result 7: {shapeEquality7}"); // false
    }

    static void TestInheritance()
    {
        // Test whether Rectangle inherits from Shape.
        bool isRectangleBaseShape = typeof(Rectangle).BaseType == typeof(Shape);
        Console.WriteLine($"Rectangle inherits from Shape: {isRectangleBaseShape}");
    }

    static void TestIComparable()
    {
        // Test if Rectangle has implemented IComparable correctly.
        List<Rectangle> rectangleList = new() {
            new Rectangle(3, 10, 3),
            new Rectangle(5, 10, 2),
            null,
            new Rectangle(3, 6, 3),
            new Rectangle(7, 14, 1),
            new Rectangle(7, 14, 1),
        };

        Console.WriteLine("Before sorting:");
        PrintRectangleList(rectangleList);

        rectangleList.Sort();
        Console.WriteLine("\nAfter sorting:");
        PrintRectangleList(rectangleList);
    }

    static void PrintRectangleList(List<Rectangle> rectangles)
    {
        foreach (var r in rectangles)
        {
            Console.WriteLine(r == null
                ? "null"
                : $"Brightness: {r.Brightness}, Area: {r.CalculateArea()}");
        }
    }

    static void TestImplementIResizable()
    {
        // Test if Rectangle has implemented IResizable correctly.
        Rectangle rectangle = new(8, 4, 3);
        Console.WriteLine($"Original rectangle: Width = {rectangle.Width}, Height = {rectangle.Height}");

        rectangle.Resize(0.5);
        Console.WriteLine($"Resized rectangle: Width = {rectangle.Width}, Height = {rectangle.Height}");
        rectangle.Resize(2.5);
        Console.WriteLine($"Resized rectangle: Width = {rectangle.Width}, Height = {rectangle.Height}");
    }

    static void TestUtils()
    {
        // Test if the Utils class has been written correctly.
        Rectangle rectangle = new(2, 3, 1);
        Console.WriteLine($"Original rectangle: Width = {rectangle.Width}, Height = {rectangle.Height}");

        Utils.DoubleSize<IResizable>(rectangle);
        Console.WriteLine($"Resized rectangle: Width = {rectangle.Width}, Height = {rectangle.Height}");
        Utils.DoubleSize<IResizable>(rectangle);
        Console.WriteLine($"Resized rectangle: Width = {rectangle.Width}, Height = {rectangle.Height}");
    }
}
