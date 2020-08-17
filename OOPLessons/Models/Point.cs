namespace OOPLessons.Models
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point() { }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Point operator +(Point p, Point p1)
        {
            return new Point() { X = p.X + p1.X, Y = p.Y + p1.Y };
        }

        public override string ToString()
        {
            return $"X = {X}, Y = {Y}";
        }

        public static Point operator ++(Point p)
        {
            p.X++;
            p.Y++;
            return p;
        }

        public static Point operator --(Point p)
        {
            p.X--;
            p.Y--;
            return p;
        }

        public static bool operator ==(Point p1, Point p2)
        {
            return p1.X == p2.X && p1.Y == p2.Y; // !(p1.X != p2.X || p2.Y != p2.Y) -> hakadardz
        }

        public static bool operator !=(Point p1, Point p2)
        {
            return p1.X != p2.X || p2.Y != p2.Y;
        }

        public override bool Equals(object obj)
        {
            if (obj != null && obj is Point)
            {
                Point p = (Point)obj;
                return (this.X == p.X) && (this.Y == p.Y);
            }

            return false;
        }

        public override int GetHashCode()
        {
            return this.GetHashCode();
        }
    }
}
