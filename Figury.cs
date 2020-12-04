using Punkty;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figury

{
    class Kwadrat : Punkt
    {
        public Kwadrat(int xUkl, int yUkl, Color kol, Form form) : base(xUkl, yUkl, kol, form)
        {

        }
        protected override void Rysuj(Graphics g)
        {
            using (Pen pen = new Pen(kolor, 3))
            {
                g.DrawLine(pen, x - 100, y - 100, x + 100, y - 100);
                g.DrawLine(pen, x - 100, y + 100, x + 100, y + 100);
                g.DrawLine(pen, x - 100, y - 100, x - 100, y + 100);
                g.DrawLine(pen, x + 100, y - 100, x + 100, y + 100);
            }

        }
    }

    class Trojkat : Punkt
    {
        public Trojkat(int xUkl, int yUkl, Color kol, Form form) : base(xUkl, yUkl, kol, form)
        {

        }
        protected override void Rysuj(Graphics g)
        {
            using (Pen pen = new Pen(kolor, 3))
            {
                g.DrawLine(pen, x, y - 100, x + 100, y+50);
                g.DrawLine(pen, x - 100, y + 50, x , y - 100);
                g.DrawLine(pen, x - 100, y + 50 , x + 100, y + 50);
            }

        }
    }

    class Prostokat : Punkt
    {
        public Prostokat(int xUkl, int yUkl, Color kol, Form form) : base(xUkl, yUkl, kol, form)
        {

        }
        protected override void Rysuj(Graphics g)
        {
            using (Pen pen = new Pen(kolor, 3))
            {
                g.DrawLine(pen, x - 200, y - 100, x + 200, y - 100);
                g.DrawLine(pen, x - 200, y + 100, x + 200, y + 100);
                g.DrawLine(pen, x - 200, y - 100, x - 200, y + 100);
                g.DrawLine(pen, x + 200, y - 100, x + 200, y + 100);
            }

        }
    }

    class Okrag : Punkt
    {
        protected int r;
        public Okrag(int xSr, int ySr, int rOkr, Color kol, Form form) : base(xSr, ySr, kol, form)
        {
            r = (rOkr > 0) ? rOkr : 1;
        }
        protected override void Rysuj(Graphics g)
        {
            using (Pen pen = new Pen(kolor, 3))
            {
                g.DrawEllipse(pen, x - r, y - r, 2 * r, 2 * r);
            }

        }
        public int R            // Promień okręgu (właściwość)
        {
            get { return r; }
        }
    }

    class Rysunek : Punkt
    {
        protected int xx1, xx2, xx3, yy1,yy2,yy3;
        public Rysunek(int xUkl, int yUkl, int x1Fig, int y1Fig, int x2Fig, int y2Fig, int x3Fig, int y3Fig, Color kol, Form form) : base(xUkl, yUkl, kol, form)
        {
            xx1 = x1Fig;
            xx2 = x2Fig;
            xx3 = x3Fig;
            yy1 = y1Fig*(-1);
            yy2 = y2Fig*(-1);
            yy3 = y3Fig*(-1);
        }
        protected override void Rysuj(Graphics g)
        {
            using (Pen pen = new Pen(kolor, 3))
            {
                g.DrawLine(pen, x + xx1 * 10, y + yy1 * 10, x + xx2 * 10, y + yy2 * 10);
                g.DrawLine(pen, x + xx1 * 10, y + yy1 * 10, x + xx3 * 10, y + yy3 * 10);
                g.DrawLine(pen, x + xx3 * 10, y + yy3 * 10, x + xx2 * 10, y + yy2 * 10);
            }

        }
    }
}
