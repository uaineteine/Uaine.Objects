using Uaine.Objects.Primitives.Shapes;

namespace Uaine.Objects.Maps
{
    public class BoolMap : IntRectangle
    {
        public bool[,] cells;
        public int Size { get => (int)Measure(); }
        public BoolMap(int width, int height, bool init) : base(width, height)
        {
            cells = new bool[width, height];
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    cells[i, j] = init;
                }
            }
        }
        public BoolMap(bool[,] cellmap, int w, int h) : base(w, h)
        {
            cells = cellmap;
        }

        public bool[,] Subsec(int xi, int xf, int yi, int yf)
        {
            int w = xf - xi;
            int h = yf - yi;
            return SubsecBySize(xi, w, yi, h);
        }
        public bool[,] SubsecBySize(int xi, int w, int yi, int h)
        {
            bool[,] sub = new bool[w, h];
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    sub[i, j] = cells[i + xi, j + yi];
                }
            }
            return sub;
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
