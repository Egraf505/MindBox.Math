using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox.Geometry.Exceptions
{
    internal class TriangleArgumentException : Exception
    {
        public TriangleArgumentException() 
            : base("The triangle is rectangular") { }
    }
}
