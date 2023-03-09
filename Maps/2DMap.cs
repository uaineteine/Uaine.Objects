using Uaine.Objects.Primitives.Shapes;

namespace Uaine.Objects.Maps
{
    public class Map2D<T> : IntRectangle
    {
        public T[,] cells;
        public int Size { get => (int)Measure(); }
        public Map2D(int width, int height, T init) : base(width, height)
        {
            cells = new T[width, height];
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    cells[i, j] = init;
                }
            }
        }
        public Map2D(T[,] cellmap, int w, int h) : base(w, h)
        {
            cells = cellmap;
        }
        public T[,] Subsec(int xi, int xf, int yi, int yf)
        {
            int w = xf - xi;
            int h = yf - yi;
            return SubsecBySize(xi, w, yi, h);
        }
        public T[,] SubsecBySize(int xi, int w, int yi, int h)
        {
            T[,] sub = new T[w, h];
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    sub[i, j] = cells[i + xi, j + yi];
                }
            }
            return sub;
        }
    }
}
