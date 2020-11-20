using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punkty
{
    class Punkt
    {
        protected int x, y;     //Współrzędne punktu
        protected Color kolor;  //Kolor
        protected bool wid;     //true - widoczny, false - nie
        protected Form okno;    // Formularz (okno)

        public Punkt(int xPob, int yPob, Color kol, Form form)
        {
            x = xPob;
            y = yPob;
            kolor = kol;
            wid = true;
            okno = form;
        }
        protected virtual void Rysuj(Graphics g)
        {
            using (Pen pen = new Pen(kolor))
                g.DrawLine(pen, x, y, x, y);
        }

        public void Pokaż(Graphics g)
        {
            wid = true;
            Rysuj(g);
        }

        public void Pokaż()
        {
            using (Graphics g = okno.CreateGraphics())
                Pokaż(g);
        }

        public void Ukryj(Graphics g)
        {
            Color kol = kolor;
            kolor = okno.BackColor;
            wid = true;
            Rysuj(g);
            kolor = kol;
        }

        public void Ukryj()
        {
            using (Graphics g = okno.CreateGraphics())
                Ukryj(g);
        }
        public int X            // Współrzędna x (właściwość)
        {
            get
            {
                return x;
            }
        }

        public int Y            // Współrzędna y (właściwość)
        {
            get
            {
                return y;
            }
        }

        public Color Kolor      // Kolor punktu (właściwość)
        {
            get
            {
                return kolor;
            }

        }

        public bool Widoczny    // Widoczność punktu (własciwość)
        {
            get
            {
                return wid;
            }
            set
            {
                if (value) Pokaż(); else Ukryj();
            }
        }
    }
}
