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
using Kwadraty;

namespace figuryGeometryczne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Punkt p;

        private void Form1_Load(object sender, EventArgs e)
        {
            p = new Punkt(ClientSize.Width / 2, (ClientSize.Height + menuStrip1.Height) / 2, Color.Red, this);      // okresla srodek form1
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            p.Pokaż(e.Graphics);        
        }
        private void pokazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p = new Uklad(p.X, p.Y, Color.LightGray, this);
            Invalidate();
        }

        private void ukryjToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p = new Punkt(p.X, p.Y, Color.White, this);
            Invalidate();
        }

        private void kwadratToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            p = new Kwadrat(p.X, p.Y, Color.Black, this);
            Invalidate();
        }
    }
}
