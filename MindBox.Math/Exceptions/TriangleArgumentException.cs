using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox.Geometry.Exceptions
{
    public class TriangleArgumentException : Exception
    {
        public TriangleArgumentException() 
            : base("The sides must not be less than zero or equal") { }
    }
}
