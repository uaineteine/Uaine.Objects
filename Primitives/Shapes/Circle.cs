using System;

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

        public float Circumference()
        {
            return (float)(2 * Math.PI * radius);
        }
    }
}
