using Punkty;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uklady
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
}
