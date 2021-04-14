using System;
using System.Collections.Generic;
using System.Text;

namespace Uaine.Objects.Primitives.Shapes
{
    public class Circle : Shape
    {
        public float radius;

        public Circle(float r)
        {
            radius = r;
        }

        public override float Measure()
        {
            return (float)(radius * radius * Math.PI);
        }
    }
}
