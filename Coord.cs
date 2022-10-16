using System;
namespace Point3D
{
    // Класс Координата
    public class Coord
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        // Конструктор по умолчанию 
        public Coord()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }

        // Конструктор
        public Coord(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return string.Format("({0}, {1}, {2})", X, Y, Z);
        }
    }
}

