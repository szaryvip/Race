using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race
{
    class Line
    {
        int x;
        int y;
        int length=800;
        int width=3;
        public Line(int xx,int yy)
        {
            x = xx;
            y = yy;
        }
        public Line(int xx, int yy, int len, int wid)
        {
            x = xx;
            y = yy;
            length = len;
            width = wid;
        }
        public void draw(Graphics g, Brush b)
        {
            g.FillRectangle(b, x, y, length, width);
            g.FillRectangle(b, x, y + 103, length, width);
            g.FillRectangle(b, x, y + 203, length, width);
        }
    }
}
