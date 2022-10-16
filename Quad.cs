namespace Point3D
{
    public class Quad : Polygon
    {
        public Quad(Point a, Point b, Point c, Point d)
            : base(4)
        {
            AddVertex(0, a);
            AddVertex(1, b);
            AddVertex(2, c);
            AddVertex(3, d);
        }

        public double DiagLen()
        {
            return Vertices[0].Dist(Vertices[2]);
        }

        // Вычисляет периметр по диагоналям и углу между ними
        public double Square()
        {
            Vector d1 = new(Vertices[0], Vertices[2]);
            Vector d2 = new(Vertices[1], Vertices[3]);

            double sin_d1_d2 = Vector.SinOfAngle(d1, d2);

            return 0.5 * d1.Length() * d2.Length() * sin_d1_d2;
        }
    }
}

