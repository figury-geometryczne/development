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

}
