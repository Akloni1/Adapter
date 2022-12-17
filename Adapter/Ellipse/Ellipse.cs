using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Ellipse
{
    public class Ellipse
    {
        private string drawEllipse { get; set; }
        public float MajorSemiaxis { get; set; }
        public float SmallHalfAxis { get; set; }

        public Ellipse(float MajorSemiaxis, float SmallHalfAxis)
        {
            this.MajorSemiaxis = MajorSemiaxis;
            this.SmallHalfAxis = SmallHalfAxis;
            drawEllipse = "";
        }

        public void Calculate()
        {
            drawEllipse = "Элипс нарисован";
        }
        public void Apply()
        {
            Console.WriteLine(drawEllipse);
        }
    }
}
