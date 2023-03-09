namespace Uaine.Objects.Maps
{
    public class IntMap : Map2D<int>
    {
        public IntMap(int width, int height, int init) : base(width, height, init)
        {
        }
        public IntMap(int[,] cellmap, int w, int h) : base(cellmap, w, h)
        {
        }
    }
}
