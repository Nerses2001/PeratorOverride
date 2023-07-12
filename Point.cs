using System;

namespace PeratorOverride
{
    public struct Point : IComparable
    {
        private int x, y;
        public Point(int x, int y)
        {

            this.x = x;
            this.y = y;
        }
        public static Point operator +(Point a, Point b) => new Point
        {
            x = a.x + b.x,
            y = a.y + b.y
        };

        public static Point operator -(Point a, Point b) => new Point
        {
            x = a.x - b.x,
            y = a.y - b.y
        };


        public static Point operator *(Point a, Point b) => new Point
        {
            x = a.x * b.x,
            y = a.y * b.y
        };

        public static Point operator /(Point a, Point b)
        {
            if (b.x == 0 || b.y == 0)
            {
                return new Point
                {
                    x = 0,
                    y = 0
                };
            }

            return new Point
            {
                x = a.x / b.x,
                y = a.y / b.y
            };
        }
        public static Point operator ++(Point a) => new Point
        {
            x = a.x + 1,
            y = a.y + 1,
        };

        public static Point operator --(Point a) => new Point
        {
            x = a.x - 1,
            y = a.y - 1,
        };

        public static bool operator ==(Point a, Point b) => a.Equals(b);


        public static bool operator !=(Point a, Point b) => !a.Equals(b);

        public static int operator >(Point a, Point b) => a.CompareTo(b);
        public static int operator <(Point a, Point b) => b.CompareTo(a);

        public static Point operator &(Point a, Point b)=> (a.x >= 0 && a.y >= 0 && b.x >= 0 && b.y >= 0) ? new Point(1, 1) : new Point(-1, -1);
        public static Point operator |(Point a, Point b) => (a.x >= 0 && a.y >= 0 && b.x >= 0 && b.y >= 0) ? new Point(-1, -1) : new Point(1, 1);



        public override string ToString() => string.Format("Res x = {0}, Res y = {1}", this.x, this.y);
        public override int GetHashCode() => this.ToString().GetHashCode();

        public override bool Equals(object o) => o is Point && ((Point)o).x == this.x && ((Point)o).y == this.y;

        public int CompareTo(object obj)
        {
            if (obj is Point)
            {
                var p = (Point)obj;
                if (this.x > p.x && this.y > p.y) return 1;
                else if (this.x < p.x && this.y < p.y) return -1;
                else if (this.x > p.x && this.y < p.y) return -2;
                else if (this.x < p.y && this.y > p.y) return -3;
                else return 0;
            }
            else throw new ArgumentException();

        }
    }
}
