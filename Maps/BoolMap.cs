using Uaine.Objects.Primitives.Shapes;

namespace Uaine.Objects.Maps
{
    public class BoolMap : Map2D<bool>
    {
        public BoolMap(int width, int height, bool init) : base(width, height, init)
        {
        }
        public BoolMap(bool[,] cellmap, int w, int h) : base(cellmap, w, h)
        {
        }

        public IntMap ConvertToIntMap()
        {
            IntMap newmap = new IntMap(Width, Height, 0);
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    if (cells[i, j] == false)
                        newmap.cells[i, j] = 0;
                    else
                        newmap.cells[i, j] = 1;
                }
            }
            return newmap;
        }
    }
}
