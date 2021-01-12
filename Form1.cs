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
using Figury;
using System.Data.SqlClient;
using System.IO;

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

        // tworzenie miejsca na rysowanie
        private void Form1_Load(object sender, EventArgs e)
        {
            var srodek = new Punkt((ClientSize.Width + 200) / 2, ClientSize.Height / 2, Color.Red, this);      // okresla srodek form1
            for (int i = 0; i < 10; i++)
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

        // SIATKA
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

        //FIGURY PODSTAWOWE
        private void rysKwadrat_Click(object sender, EventArgs e)
        {

            figura[kol] = new Kwadrat(figura[kol].X, figura[kol].Y, Color.Green, this);
            Invalidate();
        }

        private void rysTrojkat_Click(object sender, EventArgs e)
        {
            figura[kol] = new Trojkat(figura[kol].X, figura[kol].Y, Color.Green, this);
            Invalidate();
        }

        private void rysProstokat_Click(object sender, EventArgs e)
        {
            figura[kol] = new Prostokat(figura[kol].X, figura[kol].Y, Color.Green, this);
            Invalidate();
        }

        private void rysOkrag_Click(object sender, EventArgs e)
        {
            figura[kol] = new Okrag(figura[kol].X, figura[kol].Y, 100, Color.Green, this);
            Invalidate();
        }

        private void wyczysc_Click(object sender, EventArgs e)
        {
            figura[kol] = new Kwadrat(figura[kol].X, figura[kol].Y, Color.White, this);
            Invalidate();
        }

        // RYSOWANIE Z WSPÓŁRZĘDNYCH
        private void rysujWspol_Click(object sender, EventArgs e)
        {
            int rysx1, rysx2, rysx3, rysx4, rysy1, rysy2, rysy3, rysy4, rysr;
            if (String.IsNullOrEmpty(rys_x1.Text) && String.IsNullOrEmpty(rys_y1.Text) && String.IsNullOrEmpty(rys_x2.Text) && String.IsNullOrEmpty(rys_y2.Text) && String.IsNullOrEmpty(rys_x3.Text) && String.IsNullOrEmpty(rys_y3.Text) && String.IsNullOrEmpty(rys_x4.Text) && String.IsNullOrEmpty(rys_y4.Text))
            {
                MessageBox.Show("Brak poprawnych wartości. Wprowadź wartości lub sprawdź plik pomocy.");
            }
            else if ((String.IsNullOrEmpty(rys_x2.Text) && String.IsNullOrEmpty(rys_y2.Text)) && (String.IsNullOrEmpty(rys_x3.Text) && String.IsNullOrEmpty(rys_y3.Text)) && (String.IsNullOrEmpty(rys_x4.Text) && String.IsNullOrEmpty(rys_y4.Text)))
            {
                if (String.IsNullOrEmpty(rys_x1.Text) || String.IsNullOrEmpty(rys_y1.Text) || String.IsNullOrEmpty(rys_r.Text))
                {
                    MessageBox.Show("Brak poprawnych wartości. Wprowadź wartości lub sprawdź plik pomocy.");
                }
                else
                {
                    rysr = int.Parse(rys_r.Text);
                    rysx1 = int.Parse(rys_x1.Text);
                    rysy1 = int.Parse(rys_y1.Text);
                    figura[kol] = new RysujOkr(figura[kol].X, figura[kol].Y, rysx1, rysy1, rysr, Color.Green, this);
                    Invalidate();
                }
            }
            else if ((String.IsNullOrEmpty(rys_x1.Text) || String.IsNullOrEmpty(rys_y1.Text)) && String.IsNullOrEmpty(rys_r.Text))
            {
                rysx4 = int.Parse(rys_x4.Text);
                rysy4 = int.Parse(rys_y4.Text);
                rysx2 = int.Parse(rys_x2.Text);
                rysy2 = int.Parse(rys_y2.Text);
                rysx3 = int.Parse(rys_x3.Text);
                rysy3 = int.Parse(rys_y3.Text);
                figura[kol] = new Rysunek(figura[kol].X, figura[kol].Y, rysx2, rysy2, rysx3, rysy3, rysx4, rysy4, Color.Purple, this);
                Invalidate();
            }
            else if ((String.IsNullOrEmpty(rys_x2.Text) || String.IsNullOrEmpty(rys_y2.Text)) && String.IsNullOrEmpty(rys_r.Text))
            {
                rysx1 = int.Parse(rys_x1.Text);
                rysy1 = int.Parse(rys_y1.Text);
                rysx4 = int.Parse(rys_x4.Text);
                rysy4 = int.Parse(rys_y4.Text);
                rysx3 = int.Parse(rys_x3.Text);
                rysy3 = int.Parse(rys_y3.Text);
                figura[kol] = new Rysunek(figura[kol].X, figura[kol].Y, rysx1, rysy1, rysx3, rysy3, rysx4, rysy4, Color.Purple, this);
                Invalidate();
            }
            else if ((String.IsNullOrEmpty(rys_x3.Text) || String.IsNullOrEmpty(rys_y3.Text)) && String.IsNullOrEmpty(rys_r.Text))
            {
                rysx1 = int.Parse(rys_x1.Text);
                rysy1 = int.Parse(rys_y1.Text);
                rysx2 = int.Parse(rys_x2.Text);
                rysy2 = int.Parse(rys_y2.Text);
                rysx4 = int.Parse(rys_x4.Text);
                rysy4 = int.Parse(rys_y4.Text);
                figura[kol] = new Rysunek(figura[kol].X, figura[kol].Y, rysx1, rysy1, rysx2, rysy2, rysx4, rysy4, Color.Purple, this);
                Invalidate();
            }
            else if ((String.IsNullOrEmpty(rys_x4.Text) || String.IsNullOrEmpty(rys_y4.Text)) && String.IsNullOrEmpty(rys_r.Text))
            {
                rysx1 = int.Parse(rys_x1.Text);
                rysy1 = int.Parse(rys_y1.Text);
                rysx2 = int.Parse(rys_x2.Text);
                rysy2 = int.Parse(rys_y2.Text);
                rysx3 = int.Parse(rys_x3.Text);
                rysy3 = int.Parse(rys_y3.Text);
                double a, b, c, h;
                h = (rysy2 - rysy1);
                a = Math.Sqrt((rysx2 - rysx1) * (rysx2 - rysx1) + (rysy2 - rysy1) * (rysy2 - rysy1));
                b = Math.Sqrt((rysx3 - rysx1) * (rysx3 - rysx1) + (rysy3 - rysy1) * (rysy3 - rysy1));
                c = Math.Sqrt((rysx2 - rysx3) * (rysx2 - rysx3) + (rysy2 - rysy3) * (rysy2 - rysy3));
                writeResult((c * h) / 2);
                writeResult2(a + b + c);
                figura[kol] = new Rysunek(figura[kol].X, figura[kol].Y, rysx1, rysy1, rysx2, rysy2, rysx3, rysy3, Color.Purple, this);
                Invalidate();
            }
            else if (String.IsNullOrEmpty(rys_r.Text))
            {
                rysx1 = int.Parse(rys_x1.Text);
                rysy1 = int.Parse(rys_y1.Text);
                rysx4 = int.Parse(rys_x4.Text);
                rysy4 = int.Parse(rys_y4.Text);
                rysx2 = int.Parse(rys_x2.Text);
                rysy2 = int.Parse(rys_y2.Text);
                rysx3 = int.Parse(rys_x3.Text);
                rysy3 = int.Parse(rys_y3.Text);
                int a, b;
                if (rysx1 == rysx2 && rysx3 == rysx4)
                {
                    if (rysx1 < rysx3)
                    {
                        b = rysx3 - rysx1;
                    }
                    else
                    {
                        b = rysx1 - rysx3;
                    }
                }
                else if (rysx1 == rysx3 && rysx2 == rysx4)
                {
                    if (rysx1 < rysx2)
                    {
                        b = rysx2 - rysx1;
                    }
                    else
                    {
                        b = rysx1 - rysx2;
                    }
                }
                else
                {
                    b = 0;
                }
                if (rysy1 == rysy2 && rysy3 == rysy4)
                {
                    if (rysy1 < rysy3)
                    {
                        a = rysy3 - rysy1;
                    }
                    else
                    {
                        a = rysy1 - rysy3;
                    }
                }
                else if (rysy1 == rysy3 && rysy2 == rysy4)
                {
                    if (rysy1 < rysy2)
                    {
                        a = rysy2 - rysy1;
                    }
                    else
                    {
                        a = rysy1 - rysy2;
                    }
                }
                else { a = 0; }
                if (a == 0 || b == 0)
                {
                    writeResult(0);
                    writeResult2(0);
                }
                else
                {
                    writeResult(a * b);
                    writeResult2((2 * a) + (2 * b));
                }
                figura[kol] = new RysunekKw(figura[kol].X, figura[kol].Y, rysx1, rysy1, rysx2, rysy2, rysx3, rysy3, rysx4, rysy4, Color.Purple, this);
                Invalidate();
            }
            else
            {
                MessageBox.Show("Brak poprawnych wartości. Wprowadź wartości lub sprawdź plik pomocy.");
            }
        }

        // WYŚWIETLANIE POLA I OBWODU
        private void writeResult(double v)
        {
            polePow.Text = v.ToString();
        }
        private void writeResult2(double v)
        {
            obwod.Text = v.ToString();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            if (textbox.Text == "") textbox.Text = "0";
        }

        private void obwod_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            if (textbox.Text == "") textbox.Text = "0";
        }

        // WYBÓR FIGURY
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            kol = int.Parse(comboBox1.Text) - 1;
        }

        // PRZESUWANIE FIGUR
        private void onLeft_Click(object sender, EventArgs e)
        {
            int temp;
            if (String.IsNullOrEmpty(rys_x1.Text) && String.IsNullOrEmpty(rys_x2.Text) && String.IsNullOrEmpty(rys_x3.Text) && String.IsNullOrEmpty(rys_x4.Text))
                MessageBox.Show("Żaden x nie jest podany.");
            else
            {
                if (String.IsNullOrEmpty(rys_x1.Text)){}
                else
                {
                    temp = int.Parse(rys_x1.Text) - 1;
                    rys_x1.Text = temp.ToString();
                }
                if (String.IsNullOrEmpty(rys_x2.Text)) { }
                else
                {
                    temp = int.Parse(rys_x2.Text) - 1;
                    rys_x2.Text = temp.ToString();
                }
                if (String.IsNullOrEmpty(rys_x3.Text)) { }
                else
                {
                    temp = int.Parse(rys_x3.Text) - 1;
                    rys_x3.Text = temp.ToString();
                }
                if (String.IsNullOrEmpty(rys_x4.Text)) { }
                else
                {
                    temp = int.Parse(rys_x4.Text) - 1;
                    rys_x4.Text = temp.ToString();
                }
                rysujWspol_Click(sender, e);
            }
        }

        private void onRight_Click(object sender, EventArgs e)
        {
            int temp;
            if (String.IsNullOrEmpty(rys_x1.Text) && String.IsNullOrEmpty(rys_x2.Text) && String.IsNullOrEmpty(rys_x3.Text) && String.IsNullOrEmpty(rys_x4.Text))
                MessageBox.Show("Żaden x nie jest podany.");
            else
            {
                if (String.IsNullOrEmpty(rys_x1.Text)) { }
                else
                {
                    temp = int.Parse(rys_x1.Text) + 1;
                    rys_x1.Text = temp.ToString();
                }
                if (String.IsNullOrEmpty(rys_x2.Text)) { }
                else
                {
                    temp = int.Parse(rys_x2.Text) + 1;
                    rys_x2.Text = temp.ToString();
                }
                if (String.IsNullOrEmpty(rys_x3.Text)) { }
                else
                {
                    temp = int.Parse(rys_x3.Text) + 1;
                    rys_x3.Text = temp.ToString();
                }
                if (String.IsNullOrEmpty(rys_x4.Text)) { }
                else
                {
                    temp = int.Parse(rys_x4.Text) + 1;
                    rys_x4.Text = temp.ToString();
                }
                rysujWspol_Click(sender, e);
            }
        }

        private void onUp_Click(object sender, EventArgs e)
        {
            int temp;
            if (String.IsNullOrEmpty(rys_y1.Text) && String.IsNullOrEmpty(rys_y2.Text) && String.IsNullOrEmpty(rys_y3.Text) && String.IsNullOrEmpty(rys_y4.Text))
                MessageBox.Show("Żaden y nie jest podany.");
            else
            {
                if (String.IsNullOrEmpty(rys_y1.Text)) { }
                else
                {
                    temp = int.Parse(rys_y1.Text) + 1;
                    rys_y1.Text = temp.ToString();
                }
                if (String.IsNullOrEmpty(rys_y2.Text)) { }
                else
                {
                    temp = int.Parse(rys_y2.Text) + 1;
                    rys_y2.Text = temp.ToString();
                }
                if (String.IsNullOrEmpty(rys_y3.Text)) { }
                else
                {
                    temp = int.Parse(rys_y3.Text) + 1;
                    rys_y3.Text = temp.ToString();
                }
                if (String.IsNullOrEmpty(rys_y4.Text)) { }
                else
                {
                    temp = int.Parse(rys_y4.Text) + 1;
                    rys_y4.Text = temp.ToString();
                }
                rysujWspol_Click(sender, e);
            }
        }

        private void onDown_Click(object sender, EventArgs e)
        {
            int temp;
            if (String.IsNullOrEmpty(rys_y1.Text) && String.IsNullOrEmpty(rys_y2.Text) && String.IsNullOrEmpty(rys_y3.Text) && String.IsNullOrEmpty(rys_y4.Text))
                MessageBox.Show("Żaden y nie jest podany.");
            else
            {
                if (String.IsNullOrEmpty(rys_y1.Text)) { }
                else
                {
                    temp = int.Parse(rys_y1.Text) - 1;
                    rys_y1.Text = temp.ToString();
                }
                if (String.IsNullOrEmpty(rys_y2.Text)) { }
                else
                {
                    temp = int.Parse(rys_y2.Text) - 1;
                    rys_y2.Text = temp.ToString();
                }
                if (String.IsNullOrEmpty(rys_y3.Text)) { }
                else
                {
                    temp = int.Parse(rys_y3.Text) - 1;
                    rys_y3.Text = temp.ToString();
                }
                if (String.IsNullOrEmpty(rys_y4.Text)) { }
                else
                {
                    temp = int.Parse(rys_y4.Text) - 1;
                    rys_y4.Text = temp.ToString();
                }
                rysujWspol_Click(sender, e);
            }
        }

        private void wczytaj_Click(object sender, EventArgs e)
        {
            string path = "wspolrzedne.txt";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    rys_x1.Text = sr.ReadLine();
                    rys_y1.Text = sr.ReadLine();
                    rys_x2.Text = sr.ReadLine();
                    rys_y2.Text = sr.ReadLine();
                    rys_x3.Text = sr.ReadLine();
                    rys_y3.Text = sr.ReadLine();
                    rys_x4.Text = sr.ReadLine();
                    rys_y4.Text = sr.ReadLine();



                }
            }
            catch (Exception f)
            {
                MessageBox.Show("The process failed: {0}", f.ToString());
            }
        }

        private void pomoc_Click(object sender, EventArgs e)
        {
            string path = "pomoc.txt";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string readText = File.ReadAllText(path);
                    MessageBox.Show(readText);
                }
            }
            catch (Exception f)
            {
                MessageBox.Show("The process failed: {0}", f.ToString());
            }
        }

        private void info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program zaliczeniowy v 1.0" + Environment.NewLine + Environment.NewLine + "Autorzy:" + Environment.NewLine + "Bartłomiej Kuźba" + Environment.NewLine + "Bartłomiej Matuszewski" + Environment.NewLine + "Bohdan Deineka");
        }
    }
}
