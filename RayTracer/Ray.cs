using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracer
{
    public class Ray
    {

        public Vector3 Direction { get; set; }

        public Vector3 Start { get; set; }

        public Ray(Vector3 dir, Vector3 start)
        {
            Start = start;
            Direction = dir;
        }

    }
}
