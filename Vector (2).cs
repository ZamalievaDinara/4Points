namespace Point3D
{
    // Класс Вектор
    public class Vector : Coord
    {
        // Конструкторы
        public Vector()
            : base()
        {
        }

        public Vector(double x, double y, double z)
            : base(x, y, z)
        {
        }

        public Vector(Point start, Point end)
            : base(start.X - end.X, start.Y - end.Y, start.Z - end.Z)
        {
        }

        public double Length()
        {
            return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2));
        }

        public void Normalize()
        {
            double len = Length();
            X /= len;
            Y /= len;
            Z /= len;
        }

        // Оператор сложения двух векторов
        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }

        // Оператор вычитания двух векторов
        public static Vector operator -(Vector a, Vector b)
        {
            return new Vector(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }

        // Оператор умножения вектора на скаляр
        public static Vector operator *(Vector v, double k)
        {
            return new Vector(v.X * k, v.Y * k, v.Z * k);
        }

        // Оператор скалярного произведения двух векторов
        public static double operator *(Vector a, Vector b)
        {
            return a.X * b.X + a.Y * b.Y + a.Z * b.Z;
        }

        // Оператор векторного произведения двух векторов
        public static Vector operator ^(Vector a, Vector b)
        {
            return new Vector()
            {
                X = a.Y * b.Z - a.Z * b.Y,
                Y = a.Z * b.X - a.X * b.Z,
                Z = a.X * b.Y - a.Y * b.X
            };
        }

        // Вычисляет sin угла между векторами
        public static double SinOfAngle(Vector a, Vector b)
        {
            return (a ^ b).Length() / (a.Length() * b.Length());
        }
    }
}

