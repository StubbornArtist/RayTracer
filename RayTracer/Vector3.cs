using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracer
{
    public class Vector3
    {
        public Double X{ get; set; }

        public Double Y { get; set; }

        public Double Z { get; set; }


        public Vector3(Double x, Double y, Double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Vector3(Vector3 vec)
        {
            X = vec.X;
            Y = vec.Y;
            Z = vec.Z;
        }

        public Vector3(float val) : this(val, val, val){}

        public void Add(Vector3 vec)
        {
            X += vec.X;
            Y += vec.Y;
            Z += vec.Z;
        }

        public void Subtract(Vector3 vec)
        {
            X -= vec.X;
            Y -= vec.Y;
            Z -= vec.Z;
        }

        public void Multiply(Double val)
        {
            X *= val;
            Y *= val;
            Z *= val;
        }

        public Double Length()
        {
            return Math.Sqrt((X * X) + (Y * Y) + (Z * Z));
        }

        public static Double Dot(Vector3 vec1, Vector3 vec2)
        {
            return (vec1.X * vec2.X) + (vec1.Y * vec2.Y) + (vec1.Z * vec2.Z); 
        }

        public static Vector3 Cross(Vector3 u, Vector3 v)
        {
            Double newX = u.Y * v.Z - u.Z * v.Y;
            Double newY = u.Z * v.X - u.X * v.Z;
            Double newZ = u.X * v.Y - u.Y * v.X;

            return new Vector3(newX, newY, newZ);
        }

        public static Vector3 Add(Vector3 vec1, Vector3 vec2)
        {
            return new Vector3(vec1.X + vec2.X, vec1.Y + vec2.Y, vec1.Z + vec2.Z);  
        }

        public static Vector3 Subtract(Vector3 vec1, Vector3 vec2)
        {
            return new Vector3(vec1.X - vec2.X, vec1.Y - vec2.Y, vec1.Z - vec2.Z);
        }

        public static Vector3 Multiply(Vector3 vec, Double val)
        {
            return new Vector3(vec.X * val, vec.Y * val, vec.Z * val);
        }


    }
}
