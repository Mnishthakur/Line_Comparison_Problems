using System;
namespace LCP
{
    {
    internal class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }

    class LineEquals
    {
        public Point Point1 { get; set; }
        public Point Point2 { get; set; }

        public LineEquals(Point point1, Point point2)
        {
            Point1 = point1;
            Point2 = point2;
        }

        public bool Equals(LineEquals other)
        {
            return (Point1.X == other.Point1.X && Point1.Y == other.Point1.Y &&
                    Point2.X == other.Point2.X && Point2.Y == other.Point2.Y) ||
                   (Point1.X == other.Point2.X && Point1.Y == other.Point2.Y &&
                    Point2.X == other.Point1.X && Point2.Y == other.Point1.Y);
        }
    }
}
