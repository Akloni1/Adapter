using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal interface IShape
    {
        float Square();
        float Perimeter();
        void Draw();
    }
}
