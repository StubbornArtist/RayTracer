using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracer
{
    public class Scene
    {
        private List<IShape> shapes;

        public Vector3 Camera { get; set; }

        public Double AngleOfView { get; set; }

        public Vector3 LightPos { get; set; }

        public Vector3 AmbientLightColor { get; set; }

        public Vector3 AmbientLightIntensity { get; set; }

        public Scene(Vector3 camera, Vector3 light, Double aof, Vector3 aC, Vector3 aI)
        {
            shapes = new List<IShape>();
            Camera = camera;
            LightPos = light;
            AngleOfView = aof;
            AmbientLightColor = aC;
            AmbientLightIntensity = aI;
        }


    }
}
