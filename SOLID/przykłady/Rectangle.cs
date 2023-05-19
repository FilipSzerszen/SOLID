using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class Rectangle
    {
        protected int _width;
        protected int _height;

        public virtual void SetHeight(int value) { _height = value; }
        public virtual void SetWidth(int value) { _width = value; }

    }
}
