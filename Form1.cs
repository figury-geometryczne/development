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

        private Punkt figura;
        private Punkt siatka;

        private void Form1_Load(object sender, EventArgs e)
        {
            var srodek = new Punkt(ClientSize.Width / 2, (ClientSize.Height + menuStrip1.Height) / 2, Color.Red, this);      // okresla srodek form1
            figura = srodek;
            siatka = srodek;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            figura.Pokaż(e.Graphics);
            siatka.Pokaż(e.Graphics);
        }
        private void pokazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            siatka = new Uklad(siatka.X, siatka.Y, Color.Black, this);
            Invalidate();
        }

        private void ukryjToolStripMenuItem_Click(object sender, EventArgs e)
        {
            siatka = new Punkt(siatka.X, siatka.Y, Color.White, this);
            Invalidate();
        }

        private void kwadratToolStripMenuItem_Click(object sender, EventArgs e)
        {

            figura = new Kwadrat(figura.X, figura.Y, Color.Blue, this);
            Invalidate();
        }

        private void ukryjToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            figura = new Kwadrat(figura.X, figura.Y, Color.White, this);
            Invalidate();
        }

        private void trojkatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            figura = new Trojkat(figura.X, figura.Y, Color.Blue, this);
            Invalidate();
        }

        private void prostokatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            figura = new Prostokat(figura.X, figura.Y, Color.Blue, this);
            Invalidate();
        }

        private void koloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            figura = new Okrag(figura.X, figura.Y, 100, Color.Blue, this);
            Invalidate();
        }
    }
}
