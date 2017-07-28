using System;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace RayTracer
{
    public class SceneReader
    {
        public SceneReader() { }

        public List<IShape> ReadJSONScene(string scenePath)
        {
            List<IShape> shapes = new List<IShape>();
            string sceneText = "";
            try
            {
               sceneText =  File.ReadAllText(scenePath);
            }
           catch(IOException e)
           {
                Console.WriteLine(String.Format("Failed to load file. Failed with error:{0}", e.Message));
                throw e;
           }

            JToken sceneToken = JToken.Parse(sceneText);
            JArray shapeTokens = sceneToken.ToObject<JArray>();

            foreach(JToken shape in shapeTokens)
            {
                string type = shape.SelectToken("type").ToString();
                JToken def = shape.SelectToken("def");
                switch (type)
                {
                    case "sphere":
                        shapes.Add(def.ToObject<Sphere>());
                        break;
                    case "triangle":
                        shapes.Add(def.ToObject<Triangle>());
                        break;
                    case "plane":
                        shapes.Add(def.ToObject<Plane>());
                        break;
                    default:
                        throw new InvalidSceneFormatException("Invalid file format");
                }
            }
            return shapes;
        }
    }
}
