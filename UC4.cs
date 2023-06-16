namespace LCP
{
    internal class Pointequals
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Pointequals(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Point other = (Point)obj;
            return X == other.X && Y == other.Y;
        }

        public override int GetHashCode()
        {
            return Tuple.Create(X, Y).GetHashCode();
        }
    }

    class Lineforequal : IComparable<Lineforequal>
    {
        public Point Point1 { get; set; }
        public Point Point2 { get; set; }

        public Lineforequal(Point point1, Point point2)
        {
            Point1 = point1;
            Point2 = point2;
        }

        public double Length()
        {
            return Math.Sqrt(Math.Pow(Point2.X - Point1.X, 2) + Math.Pow(Point2.Y - Point1.Y, 2));
        }

        public int CompareTo(Lineforequal other)
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

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Lineforequal other = (Lineforequal)obj;
            return Point1.Equals(other.Point1) && Point2.Equals(other.Point2);
        }

        public override int GetHashCode()
        {
            return Tuple.Create(Point1, Point2).GetHashCode();
        }
    }

}
