using System;
using System.Collections.Generic;
using System.Text;
using Uaine.Objects.Primitives.Shapes;

namespace Uaine.Objects.Maps
{
    public class BoolMap : IntRectangle
    {
        public bool[,] cells;
        public BoolMap(int width, int height, bool init) : base(width, height)
        {
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

        /*public bool[,] Subsec(int xi, int xf, int yi, int yf)
        {

        }*/
    }
}
