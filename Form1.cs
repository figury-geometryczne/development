using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Punkty;
using Uklady;
using Figury;

namespace figuryGeometryczne
{
    public partial class y1 : Form
    {
        public y1()
        {
            InitializeComponent();
        }
        private Punkt[] figura = new Punkt[10];
        private Punkt siatka;
        public int kol = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            var srodek = new Punkt((ClientSize.Width + 200)/ 2, ClientSize.Height / 2, Color.Red, this);      // okresla srodek form1
            for (int i=0; i<10; i++ )
            {
                figura[i] = srodek;
            }
            siatka = srodek;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                figura[i].Pokaż(e.Graphics);
            }
            siatka.Pokaż(e.Graphics);
        }
        private void pokazSiatke_Click(object sender, EventArgs e)
        {
            siatka = new Uklad(siatka.X, siatka.Y, Color.Black, this);
            Invalidate();
        }

        private void ukryjSiatke_Click(object sender, EventArgs e)
        {
            siatka = new Punkt(siatka.X, siatka.Y, Color.White, this);
            Invalidate();
        }

        private void rysKwadrat_Click(object sender, EventArgs e)
        {

            figura[kol] = new Kwadrat(figura[kol].X, figura[kol].Y, Color.Green, this);
            kol++;
            Invalidate();
        }

        private void wyczysc_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < kol; i++)
            {
                figura[i] = new Kwadrat(figura[i].X, figura[i].Y, Color.White, this);
                Invalidate();
            }
            kol = 0;
        }

        private void rysTrojkat_Click(object sender, EventArgs e)
        {
            figura[kol] = new Trojkat(figura[kol].X, figura[kol].Y, Color.Green, this);
            kol++;
            Invalidate();
        }

        private void rysProstokat_Click(object sender, EventArgs e)
        {
            figura[kol] = new Prostokat(figura[kol].X, figura[kol].Y, Color.Green, this);
            kol++;
            Invalidate();
        }

        private void rysOkrag_Click(object sender, EventArgs e)
        {
            figura[kol] = new Okrag(figura[kol].X, figura[kol].Y, 100, Color.Green, this);
            kol++;
            Invalidate();
        }

        private void rysujWspol_Click(object sender, EventArgs e)
        {
            int temp = 0;

                if (String.IsNullOrEmpty(rys_x1.Text) || String.IsNullOrEmpty(rys_y1.Text))
            {
                temp = 1;
            }

                
                if (String.IsNullOrEmpty(rys_x2.Text) || String.IsNullOrEmpty(rys_y2.Text))
                {
                if (temp == 0)
                {
                    temp = 2;
                }
                else
                {
                    MessageBox.Show("Potrzeba co najmniej trzech wartosci");
                }
                }

            if (String.IsNullOrEmpty(rys_x3.Text) || String.IsNullOrEmpty(rys_y3.Text))
            {
                if (temp == 0)
                {
                    temp = 3;
                }
                else
                {
                    MessageBox.Show("Potrzeba co najmniej trzech wartosci");
                }
            }

            if (String.IsNullOrEmpty(rys_x4.Text) || String.IsNullOrEmpty(rys_y4.Text))
            {
                if (temp == 0)
                {
                    temp = 4;
                }
                else
                {
                    MessageBox.Show("Potrzeba co najmniej trzech wartosci");
                }
            }

            int rysx1, rysx2, rysx3, rysx4, rysy1, rysy2, rysy3, rysy4;


            if (temp == 0)
            {
                rysx1 = int.Parse(rys_x1.Text);
                rysy1 = int.Parse(rys_y1.Text);
                rysx4 = int.Parse(rys_x4.Text);
                rysy4 = int.Parse(rys_y4.Text);
                rysx2 = int.Parse(rys_x2.Text);
                rysy2 = int.Parse(rys_y2.Text);
                rysx3 = int.Parse(rys_x3.Text);
                rysy3 = int.Parse(rys_y3.Text);
                figura[kol] = new RysunekKw(figura[kol].X, figura[kol].Y, rysx1, rysy1, rysx2, rysy2, rysx3, rysy3, rysx4, rysy4, Color.Purple, this);
                kol++;
                Invalidate();
            }

            if (temp==1)
            {
                rysx4 = int.Parse(rys_x4.Text);
                rysy4 = int.Parse(rys_y4.Text);
                rysx2 = int.Parse(rys_x2.Text);
                rysy2 = int.Parse(rys_y2.Text);
                rysx3 = int.Parse(rys_x3.Text);
                rysy3 = int.Parse(rys_y3.Text);
                figura[kol] = new Rysunek(figura[kol].X, figura[kol].Y, rysx2, rysy2, rysx3, rysy3, rysx4, rysy4, Color.Purple, this);
                kol++;
                Invalidate();
            }

            if (temp == 2)
            {
                rysx1 = int.Parse(rys_x1.Text);
                rysy1 = int.Parse(rys_y1.Text);
                rysx4 = int.Parse(rys_x4.Text);
                rysy4 = int.Parse(rys_y4.Text);
                rysx3 = int.Parse(rys_x3.Text);
                rysy3 = int.Parse(rys_y3.Text);
                figura[kol] = new Rysunek(figura[kol].X, figura[kol].Y, rysx1, rysy1, rysx3, rysy3, rysx4, rysy4, Color.Purple, this);
                kol++;
                Invalidate();
            }

            if (temp == 3)
            {
                rysx1 = int.Parse(rys_x1.Text);
                rysy1 = int.Parse(rys_y1.Text);
                rysx2 = int.Parse(rys_x2.Text);
                rysy2 = int.Parse(rys_y2.Text);
                rysx4 = int.Parse(rys_x4.Text);
                rysy4 = int.Parse(rys_y4.Text);
                figura[kol] = new Rysunek(figura[kol].X, figura[kol].Y, rysx1, rysy1, rysx2, rysy2, rysx4, rysy4, Color.Purple, this);
                kol++;
                Invalidate();
            }
            
            if (temp == 4)
            {
                rysx1 = int.Parse(rys_x1.Text);
                rysy1 = int.Parse(rys_y1.Text);
                rysx2 = int.Parse(rys_x2.Text);
                rysy2 = int.Parse(rys_y2.Text);
                rysx3 = int.Parse(rys_x3.Text);
                rysy3 = int.Parse(rys_y3.Text);
                figura[kol] = new Rysunek(figura[kol].X, figura[kol].Y, rysx1, rysy1, rysx2, rysy2, rysx3, rysy3, Color.Purple, this);
                kol++;
                Invalidate();
            }
        }

        private void rysOkrWspl_Click(object sender, EventArgs e)
        {
            int rysr = int.Parse(rys_r.Text);
            int rysx1 = int.Parse(rys_x1.Text);
            int rysy1 = int.Parse(rys_y1.Text);
            figura[kol] = new RysujOkr(figura[kol].X, figura[kol].Y, rysx1, rysy1, rysr, Color.Green, this);
            kol++;
            Invalidate();
        }

    }
}
