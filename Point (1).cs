namespace Point3D
{
    // Класс Точка
    public class Point : Coord
    {
        // Конструктор по умолчанию 
        public Point()
            : base()
        {
        }

        // Конструктор
        public Point(double x, double y, double z)
            : base(x, y, z)
        {
        }

        // Метод рассчитывает расстояние между двумя точками
        public static double Dist(Point point1, Point point2)
        {
            return Math.Sqrt(
                Math.Pow(point1.X - point2.X, 2) +
                Math.Pow(point1.Y - point2.Y, 2) +
                Math.Pow(point1.Z - point2.Z, 2)
            );
        }

        // Метод рассчитывает расстояние от текущей точки до точки pnt 
        public double Dist(Point pnt)
        {
            return Dist(this, pnt);
        }

        // Метод рассчитывает расстояние от текущей точки до начала координат 
        public double Dist()
        {
            return Dist(this, new Point());
        }

        // Оператор сложения двух точек
        public static Point operator +(Point pnt1, Point pnt2)
        {
            return new Point(pnt1.X + pnt2.X, pnt1.Y + pnt2.Y, pnt1.Z + pnt2.Z);
        }

        // Оператор вычитания двух точек
        public static Point operator -(Point pnt1, Point pnt2)
        {
            return new Point(pnt1.X - pnt2.X, pnt1.Y - pnt2.Y, pnt1.Z - pnt2.Z);
        }

        // Оператор скалярного произведения двух точек 
        public static double operator *(Point pnt1, Point pnt2)
        {
            return pnt1.X * pnt2.X + pnt1.Y * pnt2.Y + pnt1.Z * pnt2.Z;
        }
    }
}

