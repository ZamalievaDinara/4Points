namespace Point3D
{
    public class Polygon
    {
        private readonly int N;

        public Point[] Vertices { get; }

        public Polygon(int N)
        {
            if (N < 3)
                throw new IndexOutOfRangeException();

            this.N = N;
            Vertices = new Point[N];
        }
        
        // Добавление вершин
        public void AddVertex(int index, Point vertex)
        {
            if (index < 0 || index >= N)
                throw new IndexOutOfRangeException();
            Vertices[index] = vertex;
        }

        // Проверяет является ли многоугольник плоским (все точки на одной плоскости)
        public bool IsFlat()
        {
            if (N == 3) // Треугольник всегда плоский
                return true;

            Plane plane = new(Vertices[0], Vertices[1], Vertices[2]);
            for (int i = 3; i < N; ++i)
            {
                if (!plane.IsContainsPoint(Vertices[i]))
                    return false; // если хоть одна точка не на плоскости, то не плоский
            }
            return true;
        }

        // Проверяет является ли фигура выпуклой
        public bool IsConvex()
        {
            // Обходим стороны четерехугольника в одном направлении
            Vector[] vectors = new Vector[N];
            for (int i = 0; i < N; ++i)
            {
                vectors[i] = new(Vertices[i], Vertices[(i + 1) % N]);
            }

            bool allNegative = true, allPositive = true;
            for (int i = 0; i < N; ++i)
            {
                // попарно вычисляем скалярные произведения соседних векторов
                double scal = vectors[i] * vectors[(i + 1) % N];
                allNegative &= (scal <= 0);
                allPositive &= (scal >= 0);
            }

            // Если все скаляры неположительные или все неотрицательные,
            // то фигура выпуклая
            if (allNegative || allPositive)
                return true;

            // иначе фигура вогнутая
            return false;
        }

        // Вычисляет периметр
        public double Perimeter()
        {
            double P = 0;
            for (int i = 0; i < N; ++i)
            {
                P += Vertices[i].Dist(Vertices[(i + 1) % N]);
            }
            return P;
        }
    }
}

