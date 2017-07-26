using System;
using System.Collections.Generic;


namespace RayTracer
{
    public class Plane : IShape
    {
        public Vector3 Diffuse { get; set; }

        public double Phong { get; set; }

        public bool Reflective { get; set; }

        public Vector3 Specular { get; set; }

        public Vector3 Point { get; set; }

        public Vector3 Normal { get; set; }

        public Plane(Vector3 p, Vector3 n)
        {
            Point = p;
            Normal = n;
        }

        public List<Vector3> Intersects(Ray r)
        {
            List<Vector3> ts = new List<Vector3>();

            Double top = Vector3.Dot(Vector3.Subtract(Point, r.Start), Normal);
            Double bot = Vector3.Dot(r.Direction, Normal);

            if(Math.Abs(bot) > Double.Epsilon)
            {
                Double t = top / bot;
                if(Math.Abs(t) > Double.Epsilon)
                {
                    ts.Add(Vector3.Add(Vector3.Multiply(r.Direction, t), r.Start));
                }
            }

            return ts;
        }

        public Vector3 NormAt(Vector3 pos)
        {
            throw new NotImplementedException();
        }
    }
}
