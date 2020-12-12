namespace figuryGeometryczne
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.siatkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pokazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ukryjToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rysujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kwadratToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trojkatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prostokatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.koloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siatkaToolStripMenuItem,
            this.rysujToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // siatkaToolStripMenuItem
            // 
            this.siatkaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pokazToolStripMenuItem,
            this.ukryjToolStripMenuItem});
            this.siatkaToolStripMenuItem.Name = "siatkaToolStripMenuItem";
            this.siatkaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.siatkaToolStripMenuItem.Text = "Siatka";
            // 
            // pokazToolStripMenuItem
            // 
            this.pokazToolStripMenuItem.Name = "pokazToolStripMenuItem";
            this.pokazToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pokazToolStripMenuItem.Text = "Pokaż";
            this.pokazToolStripMenuItem.Click += new System.EventHandler(this.pokazToolStripMenuItem_Click);
            // 
            // ukryjToolStripMenuItem
            // 
            this.ukryjToolStripMenuItem.Name = "ukryjToolStripMenuItem";
            this.ukryjToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ukryjToolStripMenuItem.Text = "Ukryj";
            this.ukryjToolStripMenuItem.Click += new System.EventHandler(this.ukryjToolStripMenuItem_Click);
            // 
            // rysujToolStripMenuItem
            // 
            this.rysujToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kwadratToolStripMenuItem,
            this.trojkatToolStripMenuItem,
            this.prostokatToolStripMenuItem,
            this.koloToolStripMenuItem});
            this.rysujToolStripMenuItem.Name = "rysujToolStripMenuItem";
            this.rysujToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.rysujToolStripMenuItem.Text = "Rysuj";
            // 
            // kwadratToolStripMenuItem
            // 
            this.kwadratToolStripMenuItem.Name = "kwadratToolStripMenuItem";
            this.kwadratToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kwadratToolStripMenuItem.Text = "Kwadrat";
            this.kwadratToolStripMenuItem.Click += new System.EventHandler(this.kwadratToolStripMenuItem_Click);
            // 
            // trojkatToolStripMenuItem
            // 
            this.trojkatToolStripMenuItem.Name = "trojkatToolStripMenuItem";
            this.trojkatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.trojkatToolStripMenuItem.Text = "Trójkąt";
            // 
            // prostokatToolStripMenuItem
            // 
            this.prostokatToolStripMenuItem.Name = "prostokatToolStripMenuItem";
            this.prostokatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.prostokatToolStripMenuItem.Text = "Prostokąt";
            // 
            // koloToolStripMenuItem
            // 
            this.koloToolStripMenuItem.Name = "koloToolStripMenuItem";
            this.koloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.koloToolStripMenuItem.Text = "Koło";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 861);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Figury geometryczne";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem siatkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pokazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ukryjToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rysujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kwadratToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trojkatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prostokatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem koloToolStripMenuItem;
    }
}

