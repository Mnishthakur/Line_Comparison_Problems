namespace LCP
{
    internal class Pointforline
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Pointforline(double x, double y)
        {
            X = x;
            Y = y;
        }
    }

    class Lineequalsto
    {
        public Point Point1 { get; set; }
        public Point Point2 { get; set; }

        public Lineequalsto(Point point1, Point point2)
        {
            Point1 = point1;
            Point2 = point2;
        }

        public double Length()
        {
            return Math.Sqrt(Math.Pow(Point2.X - Point1.X, 2) + Math.Pow(Point2.Y - Point1.Y, 2));
        }

        public int CompareTo(Lineequalsto other)
        {
            double length1 = Length();
            double length2 = other.Length();

            if (length1 > length2)
            {
                return 1;
            }
            else if (length1 < length2)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }

}
