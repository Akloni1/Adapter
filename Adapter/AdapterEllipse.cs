using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Adapter
{
    public class AdapterEllipse: IShape
    {
        Ellipse.Ellipse ellipse;
        public AdapterEllipse(Ellipse.Ellipse ellipse)
        {
            this.ellipse = ellipse;
        }


        public void Draw()
        {
            ellipse.Calculate();
            ellipse.Apply();
        }

        public float Perimeter()
        {
            return (float)((2 * 3.14) * (Math.Sqrt((Math.Pow(2 * ellipse.MajorSemiaxis, 2) + Math.Pow(2 * ellipse.SmallHalfAxis, 2)) / 8)));
        }

        public float Square()
        {
            return (float)3.14 * ellipse.MajorSemiaxis * ellipse.SmallHalfAxis;
        }
    }
}
