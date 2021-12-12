using Uaine.Objects.Primitives.Shapes;

namespace Uaine.Objects.Maps
{
    public class FloatMap : IntRectangle
    {
        public float[,] cells;
        public int Size { get => (int)Measure(); }
        public FloatMap(int width, int height, int init) : base(width, height)
        {
            cells = new float[width, height];
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    cells[i, j] = init;
                }
            }
        }
        public FloatMap(float[,] cellmap, int w, int h) : base(w, h)
        {
            cells = cellmap;
        }

        public float[,] Subsec(int xi, int xf, int yi, int yf)
        {
            int w = xf - xi;
            int h = yf - yi;
            return SubsecBySize(xi, w, yi, h);
        }
        public float[,] SubsecBySize(int xi, int w, int yi, int h)
        {
            float[,] sub = new float[w, h];
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
