namespace LCP

class Program
{
    static void Main(string[] args)
    {
        Point point1 = new Point(0, 0);
        Point point2 = new Point(3, 4);
        Point point3 = new Point(0, 0);
        Point point4 = new Point(4, 3);

        Lineforequal line1 = new Lineforequal(point1, point2);
        Lineforequal line2 = new Lineforequal(point3, point4);

        if (line1.Equals(line2))
        {
            Console.WriteLine("Line 1 is equal to Line 2.");
        }
        else
        {
            Console.WriteLine("Line 1 is not equal to Line 2.");
        }

        int result = line1.CompareTo(line2);

        if (result == 1)
        {
            Console.WriteLine("Line 1 is greater than Line 2.");
        }
        else if (result == -1)
        {
            Console.WriteLine("Line 1 is less than Line 2.");
        }
        else
        {
            Console.WriteLine("Line 1 is equal to Line 2.");
        }
    }

}
