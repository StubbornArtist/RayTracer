using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracer
{
    public interface IShape
    {
        Vector3 Diffuse { get; set; }
        Vector3 Specular { get; set; }
        Double Phong { get; set; }
        bool Reflective { get; set; }

        List<Vector3> Intersects(Ray r);
        Vector3 NormAt(Vector3 pos);
    }
}
