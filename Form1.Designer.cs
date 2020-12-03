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
            this.pokazSiatke = new System.Windows.Forms.Button();
            this.ukryjSiatke = new System.Windows.Forms.Button();
            this.rysKwadrat = new System.Windows.Forms.Button();
            this.rysProstokat = new System.Windows.Forms.Button();
            this.rysTrojkat = new System.Windows.Forms.Button();
            this.rysOkrag = new System.Windows.Forms.Button();
            this.wyczysc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pokazSiatke
            // 
            this.pokazSiatke.Location = new System.Drawing.Point(10, 16);
            this.pokazSiatke.Name = "pokazSiatke";
            this.pokazSiatke.Size = new System.Drawing.Size(117, 26);
            this.pokazSiatke.TabIndex = 0;
            this.pokazSiatke.Text = "Pokaż siatkę";
            this.pokazSiatke.UseVisualStyleBackColor = true;
            this.pokazSiatke.Click += new System.EventHandler(this.pokazSiatke_Click);
            // 
            // ukryjSiatke
            // 
            this.ukryjSiatke.Location = new System.Drawing.Point(142, 16);
            this.ukryjSiatke.Name = "ukryjSiatke";
            this.ukryjSiatke.Size = new System.Drawing.Size(72, 25);
            this.ukryjSiatke.TabIndex = 1;
            this.ukryjSiatke.Text = "Ukryj";
            this.ukryjSiatke.UseVisualStyleBackColor = true;
            this.ukryjSiatke.Click += new System.EventHandler(this.ukryjSiatke_Click);
            // 
            // rysKwadrat
            // 
            this.rysKwadrat.Location = new System.Drawing.Point(10, 78);
            this.rysKwadrat.Name = "rysKwadrat";
            this.rysKwadrat.Size = new System.Drawing.Size(117, 26);
            this.rysKwadrat.TabIndex = 2;
            this.rysKwadrat.Text = "Kwadrat";
            this.rysKwadrat.UseVisualStyleBackColor = true;
            this.rysKwadrat.Click += new System.EventHandler(this.rysKwadrat_Click);
            // 
            // rysProstokat
            // 
            this.rysProstokat.Location = new System.Drawing.Point(10, 110);
            this.rysProstokat.Name = "rysProstokat";
            this.rysProstokat.Size = new System.Drawing.Size(117, 26);
            this.rysProstokat.TabIndex = 3;
            this.rysProstokat.Text = "Prostokąt";
            this.rysProstokat.UseVisualStyleBackColor = true;
            this.rysProstokat.Click += new System.EventHandler(this.rysProstokat_Click);
            // 
            // rysTrojkat
            // 
            this.rysTrojkat.Location = new System.Drawing.Point(10, 142);
            this.rysTrojkat.Name = "rysTrojkat";
            this.rysTrojkat.Size = new System.Drawing.Size(117, 26);
            this.rysTrojkat.TabIndex = 4;
            this.rysTrojkat.Text = "Trójkąt";
            this.rysTrojkat.UseVisualStyleBackColor = true;
            this.rysTrojkat.Click += new System.EventHandler(this.rysTrojkat_Click);
            // 
            // rysOkrag
            // 
            this.rysOkrag.Location = new System.Drawing.Point(10, 174);
            this.rysOkrag.Name = "rysOkrag";
            this.rysOkrag.Size = new System.Drawing.Size(117, 26);
            this.rysOkrag.TabIndex = 5;
            this.rysOkrag.Text = "Okrąg";
            this.rysOkrag.UseVisualStyleBackColor = true;
            this.rysOkrag.Click += new System.EventHandler(this.rysOkrag_Click);
            // 
            // wyczysc
            // 
            this.wyczysc.Location = new System.Drawing.Point(142, 78);
            this.wyczysc.Name = "wyczysc";
            this.wyczysc.Size = new System.Drawing.Size(72, 25);
            this.wyczysc.TabIndex = 6;
            this.wyczysc.Text = "Wyczyść";
            this.wyczysc.UseVisualStyleBackColor = true;
            this.wyczysc.Click += new System.EventHandler(this.wyczysc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.Controls.Add(this.wyczysc);
            this.Controls.Add(this.rysOkrag);
            this.Controls.Add(this.rysTrojkat);
            this.Controls.Add(this.rysProstokat);
            this.Controls.Add(this.rysKwadrat);
            this.Controls.Add(this.ukryjSiatke);
            this.Controls.Add(this.pokazSiatke);
            this.Name = "Form1";
            this.Text = "Figury geometryczne";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pokazSiatke;
        private System.Windows.Forms.Button ukryjSiatke;
        private System.Windows.Forms.Button rysKwadrat;
        private System.Windows.Forms.Button rysProstokat;
        private System.Windows.Forms.Button rysTrojkat;
        private System.Windows.Forms.Button rysOkrag;
        private System.Windows.Forms.Button wyczysc;
    }
}

