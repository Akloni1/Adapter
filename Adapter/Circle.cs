using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Circle : IShape 
    {
        public float Radius { get; set; }

       

        public Circle(float radius)
        {
            Radius = radius;
        }

        public float Square()
        {
            return (float)Math.Pow(3.14 * Radius, 2);
        }

        public float Perimeter()
        {
            return 2 * 3.14f * Radius;
        }

        public void Draw()
        {
            Console.WriteLine($"Нарисовался круг");
        }
    }
}
