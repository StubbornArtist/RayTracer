using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracer
{
    public class Sphere : IShape
    {
        public Vector3 Diffuse { get; set; }

        public double Phong { get; set; }

        public bool Reflective { get; set; }

        public Vector3 Specular { get; set; }

        public Double Radius { get; set; }

        public Vector3 Center { get; set; }
		
		Newtonsoft.Json.JsonConstructor]
        public Sphere(Double r, Vector3 c)
        {
            Radius = r;
            Center = c;

        }

        public List<Vector3> Intersects(Ray r)
        {
            List<Vector3> ts = new List<Vector3>();

            Vector3 l = Vector3.Subtract(r.Start, Center);

            Double a = Vector3.Dot(r.Direction, r.Direction);
            Double b = Vector3.Dot(l, r.Direction);
            Double c = Vector3.Dot(l, l) - (Radius * Radius);

            Double equ = (b * b) - (4 * a * c);

            if(equ == 0)
            {
                Double scalar = -b / (2 * a);
                ts.Add(Vector3.Add(Vector3.Multiply(r.Direction, scalar), r.Direction));
            }
            else if(equ > 0)
            {
                Double scalar1 = (-b + Math.Sqrt(equ)) / (2 * a);
                Double scalar2 = (-b - Math.Sqrt(equ)) / (2 * a);
                ts.Add(Vector3.Add(Vector3.Multiply(r.Direction, scalar1), r.Start));
                ts.Add(Vector3.Add(Vector3.Multiply(r.Direction, scalar2), r.Start));
            }

            return ts;
        }

        public Vector3 NormAt(Vector3 pos)
        {
           return Vector3.Subtract(pos, Center);
        }
    }
}
