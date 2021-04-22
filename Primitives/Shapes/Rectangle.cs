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
    public class IntRectangle : Shape
    {
        public int Width;
        public int Height;

        public IntRectangle(int width, int height)
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
