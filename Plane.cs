namespace Point3D
{
    public class Plane
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double D { get; set; }

        public Plane(Point pnt1, Point pnt2, Point pnt3)
        {
            // (X - A11) * (A22 * A33 - A32 * A23) + (Y - A12) * (A23 * A31 - A21 * A33) + (Z - A13) * (A21 * A32 - A22 * A31)
            double A11 = pnt1.X; // X - X1 
            double A21 = pnt2.X - pnt1.X;
            double A31 = pnt3.X - pnt1.X;
            double A12 = pnt1.Y; // Y - Y1 
            double A22 = pnt2.Y - pnt1.Y;
            double A32 = pnt3.Y - pnt1.Y;
            double A13 = pnt1.Z; // Z - Z1 
            double A23 = pnt2.Z - pnt1.Z;
            double A33 = pnt3.Z - pnt1.Z;

            A = A22 * A33 - A32 * A23;
            B = A23 * A31 - A21 * A33;
            C = A21 * A32 - A22 * A31;
            D = 0.0 - A11 * A - A12 * B - A13 * C;
        }

        public override string ToString()
        {
            // Метод возвращает строку, содержащую уравнение плоскости вида:
            // Ax + By + Cz + D = 0
            return string.Format("{0} * x + {1} * y + {2} * z + {3} = 0", A, B, C, D);
        }

        // Проверяет, содержит ли плоскость заданную точку
        public bool IsContainsPoint(Point pnt)
        {
            return (A * pnt.X + B * pnt.Y + C * pnt.Z + D) == 0;
        }
    }
}
