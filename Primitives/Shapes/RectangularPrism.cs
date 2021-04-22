namespace Uaine.Objects.Primitives.Shapes
{
    public class RectangularPrism : Rectangle
    {
        public float Depth;
        public RectangularPrism(float width, float height, float depth) : base(width, height)
        {
            Depth = depth;
        }

        public override float Measure()
        {
            return base.Measure() * Depth;
        }
    }
    public class IntRectangularPrism : IntRectangle
    {
        public int Depth;
        public IntRectangularPrism(int width, int height, int depth) : base(width, height)
        {
            Depth = depth;
        }

        public override float Measure()
        {
            return base.Measure() * Depth;
        }
    }
}
