using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class Square :Rectangle
    {
        public override void SetHeight(int value)
        {
            _height = value;
            _width = value;
        }

        public override void SetWidth(int value)
        {
            _height = value;
            _width = value;
        }
    }
}
