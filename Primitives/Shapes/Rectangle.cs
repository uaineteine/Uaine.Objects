using System;
using System.Collections.Generic;
using System.Text;

namespace Uaine.Objects.Primitives.Shapes
{
    public class Rectangle : Shape
    {
        public float Width;
        public float Height;

        public Rectangle(float width, float height)
        {
            Width = width;
            Height = height;
        }

        public override float Measure()
        {
            return Width * Height;
        }
    }
}
