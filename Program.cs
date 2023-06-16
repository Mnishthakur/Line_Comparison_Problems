namespace LCP;

class Program
{
    static void Main(string[] args)
    {
        Point point1 = new Point(0, 0);
        Point point2 = new Point(3, 4);
        Point point3 = new Point(0, 0);
        Point point4 = new Point(3, 4);

        LineEquals line1 = new LineEquals(point1, point2);
        LineEquals line2 = new LineEquals(point3, point4);

        if (line1.Equals(line2))
        {
            Console.WriteLine("The two lines are equal.");
        }
        else
        {
            Console.WriteLine("The two lines are not equal.");
        }
    }

}
