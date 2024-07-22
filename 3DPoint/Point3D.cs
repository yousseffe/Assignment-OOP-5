using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OOP_5._3DPoint
{
    internal class Point3D : IComparable,ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3D(int x , int y , int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public Point3D() : this(0, 0, 0){ }

        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Point3D point)
            {
                return X == point.X && Y == point.Y && Z == point.Z;
            }
            return false;
        }
        public static bool operator ==(Point3D a, Point3D b)
        {
            return a.Equals(b);
        }
        public static bool operator !=(Point3D a, Point3D b)
        {
            return !a.Equals(b);
        }
        public int CompareTo(object? obj)
        {
            Point3D point = (Point3D)obj;
            int result = this.X.CompareTo(point.X);
            if (result == 0)
            {
                result = this.Y.CompareTo(point.Y);
            }
            if (result == 0)
            {
                result = this.Z.CompareTo(point.Z);
            }
            return result;
        }

        public object Clone()
        {
            return new Point3D(X, Y, Z);
        }
    }
}
