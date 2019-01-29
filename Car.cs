using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race
{
    class Car
    {
        int x=5;
        int y=221;
        int v = 10;
        int width = 100;
        int height = 70;
        public bool win = false;
        public bool inmove = false;
        public void draw(Graphics g, Brush b)
        {
            g.FillRectangle(b, x, y, width, height);
        }
        public void MoveUp()
        {
           if(y>100) y = y - 103;
        }
        public bool Win()
        {
            if (x >= 675) { win = true; return true; }
            else return false;
        }
        public void MoveDown()
        {
            if(y<250)y = y + 103;
        }
        public void Move()
        {
            if(inmove)x += v;
        }
        public bool Lose(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            if (x + width > x1 && x < x1 + width && y == y1) return true;
            if (x + width > x2 && x < x2 + width && y == y2) return true;
            if (x + width > x3 && x < x3 + width && y == y3) return true;
            if (x + width > x4 && x < x4 + width && y == y4) return true;
            else return false;
        }
    }
}
