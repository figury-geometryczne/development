using Punkty;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kwadraty
{
    class Kwadrat : Punkt
    {
        public Kwadrat(int xUkl, int yUkl, Color kol, Form form) : base(xUkl, yUkl, kol, form)
        {

        }
        protected override void Rysuj(Graphics g)
        {
            using (Pen pen = new Pen(kolor))
            {
                g.DrawLine(pen, x - 100, y - 100, x + 100, y + 100);
            }

        }
    }
}
