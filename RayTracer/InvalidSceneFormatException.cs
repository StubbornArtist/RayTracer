using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracer
{
    public class InvalidSceneFormatException : Exception
    {
        public InvalidSceneFormatException(string message): base(message) { }

    }
}
