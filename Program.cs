namespace LCP;

class Program
{
    static void Main(string[] args)
    {
        // Example usage
        double x1 = 0;
        double y1 = 0;
        double x2 = 3;
        double y2 = 4;

        Line line = new Line(x1, y1, x2, y2);
        double length = line.CalculateLength();
        Console.WriteLine($"Length of the line: {length}");
    }
}
