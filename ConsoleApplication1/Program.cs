using System.Collections.Generic;
using RayTracer;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IShape> shapes;
            SceneReader reader = new SceneReader();
            shapes = reader.ReadJSONScene("testScene.json");
        }
    }
}
