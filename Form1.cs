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
    public partial class Form1 : Form
    {
        public Form1()
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

    }
}
