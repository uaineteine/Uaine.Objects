namespace Uaine.Objects.Primitives.Shapes
{
    public class Cube : RectangularPrism
    {
        public Cube(float w) : base(w, w, w)
        {
        }
    }
    public class IntCube : IntRectangularPrism
    {
        public IntCube(int w) : base(w, w, w)
        {
        }
    }
}
