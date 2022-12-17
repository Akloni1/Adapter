using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class GraphicEditor
    {
        public void Draw(IShape shape)
        {
            shape.Draw();
        }
        public void Square(IShape shape)
        {
            shape.Square();
        }
        public void Perimeter(IShape shape)
        {
            shape.Perimeter();
        }
    }
}
