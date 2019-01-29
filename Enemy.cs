using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race
{
    class Enemy
    {//without move now(dont use v and Move() and Win())
        public int x ;  //x from 105 to 670
        public int y ;  //y can equal 15,118,221,324
        int v = 10;
        int width = 100;
        int height = 70;
        public Enemy(int xx,int yy)
        {
            x = xx;
            y = yy;
        }
        public void draw(Graphics g, Brush b)
        {
            g.FillRectangle(b, x, y, width, height);
        }
        
        public bool Win()
        {
            if (x >= 675) return true;
            else return false;
        }
        public void Move()
        {
            x += v;
        }
    }
}
