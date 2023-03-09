using Uaine.Objects.Primitives.Shapes;

namespace Uaine.Objects.Maps
{
    public class FloatMap : Map2D<float>
    {
        public FloatMap(int width, int height, float init) : base(width, height, init)
        {
        }
        public FloatMap(float[,] cellmap, int w, int h) : base(cellmap, w, h)
        {
        }
    }
}
