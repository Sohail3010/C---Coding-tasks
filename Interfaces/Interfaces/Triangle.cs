using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Triangle : TShape
    {
        public double height { get; set; }
        public double width { get; set; }

        public double Area()
        {
            return height * width;
        }
    }
}
