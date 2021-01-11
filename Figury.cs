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

    class Uklad : Punkt
    {
        public Uklad(int xUkl, int yUkl, Color kol, Form form) : base(xUkl, yUkl, kol, form)
        {

        }

        protected override void Rysuj(Graphics g)
        {
            System.Drawing.Drawing2D.AdjustableArrowCap arrowcap = new System.Drawing.Drawing2D.AdjustableArrowCap(7, 7, false); //tworzy strzalke na koncu linii
            using (Pen pen = new Pen(kolor))        //rysowanie kratki ukladu
            {
                for (int i = -400; i <= 400; i = i + 50)
                {
                    if (i != 0)
                    {
                        g.DrawLine(pen, x - 400, y - i, x + 400, y - i);
                        g.DrawLine(pen, x - i, y - 400, x - i, y + 400);
                    }
                }
            }

            kolor = Color.Black;
            using (Pen pen = new Pen(kolor, 3))     //rysowanie osi układu
            {
                pen.CustomEndCap = arrowcap;
                g.DrawLine(pen, x - 400, y, x + 400, y);
                g.DrawLine(pen, x, y + 400, x, y - 400);
            }

        }
    }
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

    class RysunekKw : Punkt
    {
        protected int xx1, xx2, xx3, xx4, yy1, yy2, yy3, yy4;
        public RysunekKw(int xUkl, int yUkl, int x1Fig, int y1Fig, int x2Fig, int y2Fig, int x3Fig, int y3Fig, int x4Fig, int y4Fig, Color kol, Form form) : base(xUkl, yUkl, kol, form)
        {
            xx1 = x1Fig;
            xx2 = x2Fig;
            xx3 = x3Fig;
            xx4 = x4Fig;
            yy1 = y1Fig * (-1);
            yy2 = y2Fig * (-1);
            yy3 = y3Fig * (-1);
            yy4 = y4Fig * (-1);
        }
        protected override void Rysuj(Graphics g)
        {
            using (Pen pen = new Pen(kolor, 3))
            {
                g.DrawLine(pen, x + xx1 * 10, y + yy1 * 10, x + xx2 * 10, y + yy2 * 10);
                g.DrawLine(pen, x + xx1 * 10, y + yy1 * 10, x + xx3 * 10, y + yy3 * 10);
                g.DrawLine(pen, x + xx4 * 10, y + yy4 * 10, x + xx2 * 10, y + yy2 * 10);
                g.DrawLine(pen, x + xx4 * 10, y + yy4 * 10, x + xx3 * 10, y + yy3 * 10);
            }

        }
    }
}

class RysujOkr : Punkt
{
    protected int r, xx1, yy1;
    public RysujOkr(int xSr, int ySr, int x1Fig, int y1Fig, int rOkr, Color kol, Form form) : base(xSr, ySr, kol, form)
    {
        xx1 = x1Fig*10;
        yy1 = y1Fig*(-1)*10;
        r = (rOkr > 0) ? rOkr : 1;
        r = r * 10;
    }
    protected override void Rysuj(Graphics g)
    {
        using (Pen pen = new Pen(kolor, 3))
        {
            g.DrawEllipse(pen, (x+xx1) - r, (y+yy1) - r, 2 * r, 2 * r);
        }

    }
    public int R            // Promień okręgu (właściwość)
    {
        get { return r; }
    }
}