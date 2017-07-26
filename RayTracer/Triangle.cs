using System;
using System.Collections.Generic;
using System.Linq;


namespace RayTracer
{
    public class Triangle : IShape
    {
        public Vector3 Diffuse { get; set; }

        public double Phong { get; set; }

        public bool Reflective { get; set; }

        public Vector3 Specular { get; set; }

        public Vector3 PointOne { get; set; }

        public Vector3 PointTwo { get; set; }

        public Vector3 PointThree { get; set; }

        public List<Vector3> Intersects(Ray r)
        {
            Vector3 norm = Vector3.Cross(Vector3.Subtract(PointTwo, PointOne), Vector3.Subtract(PointThree, PointOne));
            Plane p = new Plane(PointThree, norm);

            List<Vector3> ts = p.Intersects(r);
            if(ts.Count > 0)
            {
                Vector3 t1 = ts.ElementAt(0);
                Double a = Vector3.Dot(norm, Vector3.Cross(Vector3.Subtract(PointTwo, PointOne), Vector3.Subtract(t1, PointOne)));
                Double b = Vector3.Dot(norm, Vector3.Cross(Vector3.Subtract(PointThree, PointTwo), Vector3.Subtract(t1, PointTwo)));
                Double c = Vector3.Dot(norm, Vector3.Cross(Vector3.Subtract(PointOne, PointThree), Vector3.Subtract(t1, PointThree)));

                if(a > 0 && b > 0 && c > 0)
                {
                    return ts;
                }
            }
            return new List<Vector3>();
        }

        public Vector3 NormAt(Vector3 pos)
        {
            throw new NotImplementedException();
        }
    }
}
