namespace Kalkulator
{
    partial class MainPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPanel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Wyjscie = new System.Windows.Forms.PictureBox();
            this.Wynik = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Pierwiastek = new System.Windows.Forms.PictureBox();
            this.Procenty = new System.Windows.Forms.PictureBox();
            this.Potegowanie = new System.Windows.Forms.PictureBox();
            this.Kasowanie = new System.Windows.Forms.PictureBox();
            this.Przecinek = new System.Windows.Forms.PictureBox();
            this.Zero = new System.Windows.Forms.PictureBox();
            this.Osiem = new System.Windows.Forms.PictureBox();
            this.Mnozenie = new System.Windows.Forms.PictureBox();
            this.Dziewiec = new System.Windows.Forms.PictureBox();
            this.Dzielenie = new System.Windows.Forms.PictureBox();
            this.Siedem = new System.Windows.Forms.PictureBox();
            this.Piec = new System.Windows.Forms.PictureBox();
            this.Szesc = new System.Windows.Forms.PictureBox();
            this.Odejmowanie = new System.Windows.Forms.PictureBox();
            this.Cztery = new System.Windows.Forms.PictureBox();
            this.Dwa = new System.Windows.Forms.PictureBox();
            this.Trzy = new System.Windows.Forms.PictureBox();
            this.Dodawanie = new System.Windows.Forms.PictureBox();
            this.Jeden = new System.Windows.Forms.PictureBox();
            this.Rownosc = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Wyjscie)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pierwiastek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Procenty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Potegowanie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kasowanie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Przecinek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Osiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mnozenie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dziewiec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dzielenie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Siedem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Piec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Szesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Odejmowanie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cztery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dwa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trzy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dodawanie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jeden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rownosc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightPink;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.Wyjscie);
            this.panel1.Controls.Add(this.Wynik);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 201);
            this.panel1.TabIndex = 0;
            // 
            // Wyjscie
            // 
            this.Wyjscie.BackColor = System.Drawing.Color.Transparent;
            this.Wyjscie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Wyjscie.Image = ((System.Drawing.Image)(resources.GetObject("Wyjscie.Image")));
            this.Wyjscie.Location = new System.Drawing.Point(404, 12);
            this.Wyjscie.Name = "Wyjscie";
            this.Wyjscie.Size = new System.Drawing.Size(47, 45);
            this.Wyjscie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Wyjscie.TabIndex = 18;
            this.Wyjscie.TabStop = false;
            this.Wyjscie.Click += new System.EventHandler(this.Wyjscie_Click);
            // 
            // Wynik
            // 
            this.Wynik.BackColor = System.Drawing.Color.Transparent;
            this.Wynik.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Wynik.Enabled = false;
            this.Wynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.Wynik.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Wynik.Location = new System.Drawing.Point(0, 60);
            this.Wynik.Name = "Wynik";
            this.Wynik.Size = new System.Drawing.Size(463, 141);
            this.Wynik.TabIndex = 0;
            this.Wynik.Text = "0";
            this.Wynik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Wynik.Click += new System.EventHandler(this.Wynik_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.Pierwiastek);
            this.panel2.Controls.Add(this.Procenty);
            this.panel2.Controls.Add(this.Potegowanie);
            this.panel2.Controls.Add(this.Kasowanie);
            this.panel2.Controls.Add(this.Przecinek);
            this.panel2.Controls.Add(this.Zero);
            this.panel2.Controls.Add(this.Osiem);
            this.panel2.Controls.Add(this.Mnozenie);
            this.panel2.Controls.Add(this.Dziewiec);
            this.panel2.Controls.Add(this.Dzielenie);
            this.panel2.Controls.Add(this.Siedem);
            this.panel2.Controls.Add(this.Piec);
            this.panel2.Controls.Add(this.Szesc);
            this.panel2.Controls.Add(this.Odejmowanie);
            this.panel2.Controls.Add(this.Cztery);
            this.panel2.Controls.Add(this.Dwa);
            this.panel2.Controls.Add(this.Trzy);
            this.panel2.Controls.Add(this.Dodawanie);
            this.panel2.Controls.Add(this.Jeden);
            this.panel2.Controls.Add(this.Rownosc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 201);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(463, 449);
            this.panel2.TabIndex = 1;
            // 
            // Pierwiastek
            // 
            this.Pierwiastek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pierwiastek.Image = ((System.Drawing.Image)(resources.GetObject("Pierwiastek.Image")));
            this.Pierwiastek.Location = new System.Drawing.Point(252, 29);
            this.Pierwiastek.Name = "Pierwiastek";
            this.Pierwiastek.Size = new System.Drawing.Size(73, 69);
            this.Pierwiastek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pierwiastek.TabIndex = 24;
            this.Pierwiastek.TabStop = false;
            this.Pierwiastek.Click += new System.EventHandler(this.Pierwiastek_Click);
            // 
            // Procenty
            // 
            this.Procenty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Procenty.Image = ((System.Drawing.Image)(resources.GetObject("Procenty.Image")));
            this.Procenty.Location = new System.Drawing.Point(252, 368);
            this.Procenty.Name = "Procenty";
            this.Procenty.Size = new System.Drawing.Size(73, 69);
            this.Procenty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Procenty.TabIndex = 23;
            this.Procenty.TabStop = false;
            this.Procenty.Click += new System.EventHandler(this.Procenty_Click);
            // 
            // Potegowanie
            // 
            this.Potegowanie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Potegowanie.Image = ((System.Drawing.Image)(resources.GetObject("Potegowanie.Image")));
            this.Potegowanie.Location = new System.Drawing.Point(141, 29);
            this.Potegowanie.Name = "Potegowanie";
            this.Potegowanie.Size = new System.Drawing.Size(74, 69);
            this.Potegowanie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Potegowanie.TabIndex = 22;
            this.Potegowanie.TabStop = false;
            this.Potegowanie.Click += new System.EventHandler(this.Potegowanie_Click);
            // 
            // Kasowanie
            // 
            this.Kasowanie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Kasowanie.Image = ((System.Drawing.Image)(resources.GetObject("Kasowanie.Image")));
            this.Kasowanie.Location = new System.Drawing.Point(37, 29);
            this.Kasowanie.Name = "Kasowanie";
            this.Kasowanie.Size = new System.Drawing.Size(74, 69);
            this.Kasowanie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Kasowanie.TabIndex = 21;
            this.Kasowanie.TabStop = false;
            this.Kasowanie.Click += new System.EventHandler(this.Kasowanie_Click);
            // 
            // Przecinek
            // 
            this.Przecinek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Przecinek.Image = ((System.Drawing.Image)(resources.GetObject("Przecinek.Image")));
            this.Przecinek.Location = new System.Drawing.Point(37, 368);
            this.Przecinek.Name = "Przecinek";
            this.Przecinek.Size = new System.Drawing.Size(74, 69);
            this.Przecinek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Przecinek.TabIndex = 20;
            this.Przecinek.TabStop = false;
            this.Przecinek.Click += new System.EventHandler(this.Przecinek_Click);
            // 
            // Zero
            // 
            this.Zero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Zero.Image = ((System.Drawing.Image)(resources.GetObject("Zero.Image")));
            this.Zero.Location = new System.Drawing.Point(141, 368);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(74, 69);
            this.Zero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Zero.TabIndex = 19;
            this.Zero.TabStop = false;
            this.Zero.Click += new System.EventHandler(this.Zero_Click);
            // 
            // Osiem
            // 
            this.Osiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Osiem.Image = ((System.Drawing.Image)(resources.GetObject("Osiem.Image")));
            this.Osiem.Location = new System.Drawing.Point(141, 287);
            this.Osiem.Name = "Osiem";
            this.Osiem.Size = new System.Drawing.Size(73, 69);
            this.Osiem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Osiem.TabIndex = 18;
            this.Osiem.TabStop = false;
            this.Osiem.Click += new System.EventHandler(this.Osiem_Click);
            // 
            // Mnozenie
            // 
            this.Mnozenie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Mnozenie.Image = ((System.Drawing.Image)(resources.GetObject("Mnozenie.Image")));
            this.Mnozenie.Location = new System.Drawing.Point(352, 117);
            this.Mnozenie.Name = "Mnozenie";
            this.Mnozenie.Size = new System.Drawing.Size(73, 69);
            this.Mnozenie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Mnozenie.TabIndex = 17;
            this.Mnozenie.TabStop = false;
            this.Mnozenie.Click += new System.EventHandler(this.Mnozenie_Click);
            // 
            // Dziewiec
            // 
            this.Dziewiec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dziewiec.Image = ((System.Drawing.Image)(resources.GetObject("Dziewiec.Image")));
            this.Dziewiec.Location = new System.Drawing.Point(252, 287);
            this.Dziewiec.Name = "Dziewiec";
            this.Dziewiec.Size = new System.Drawing.Size(73, 69);
            this.Dziewiec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dziewiec.TabIndex = 15;
            this.Dziewiec.TabStop = false;
            this.Dziewiec.Click += new System.EventHandler(this.Dziewiec_Click);
            // 
            // Dzielenie
            // 
            this.Dzielenie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dzielenie.Image = ((System.Drawing.Image)(resources.GetObject("Dzielenie.Image")));
            this.Dzielenie.Location = new System.Drawing.Point(352, 29);
            this.Dzielenie.Name = "Dzielenie";
            this.Dzielenie.Size = new System.Drawing.Size(73, 69);
            this.Dzielenie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dzielenie.TabIndex = 14;
            this.Dzielenie.TabStop = false;
            this.Dzielenie.Click += new System.EventHandler(this.Dzielenie_Click);
            // 
            // Siedem
            // 
            this.Siedem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Siedem.Image = ((System.Drawing.Image)(resources.GetObject("Siedem.Image")));
            this.Siedem.Location = new System.Drawing.Point(37, 287);
            this.Siedem.Name = "Siedem";
            this.Siedem.Size = new System.Drawing.Size(74, 69);
            this.Siedem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Siedem.TabIndex = 13;
            this.Siedem.TabStop = false;
            this.Siedem.Click += new System.EventHandler(this.Siedem_Click);
            // 
            // Piec
            // 
            this.Piec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Piec.Image = ((System.Drawing.Image)(resources.GetObject("Piec.Image")));
            this.Piec.Location = new System.Drawing.Point(141, 201);
            this.Piec.Name = "Piec";
            this.Piec.Size = new System.Drawing.Size(74, 69);
            this.Piec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Piec.TabIndex = 12;
            this.Piec.TabStop = false;
            this.Piec.Click += new System.EventHandler(this.Piec_Click);
            // 
            // Szesc
            // 
            this.Szesc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Szesc.Image = ((System.Drawing.Image)(resources.GetObject("Szesc.Image")));
            this.Szesc.Location = new System.Drawing.Point(252, 201);
            this.Szesc.Name = "Szesc";
            this.Szesc.Size = new System.Drawing.Size(73, 69);
            this.Szesc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Szesc.TabIndex = 11;
            this.Szesc.TabStop = false;
            this.Szesc.Click += new System.EventHandler(this.Szesc_Click);
            // 
            // Odejmowanie
            // 
            this.Odejmowanie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Odejmowanie.Image = ((System.Drawing.Image)(resources.GetObject("Odejmowanie.Image")));
            this.Odejmowanie.Location = new System.Drawing.Point(352, 201);
            this.Odejmowanie.Name = "Odejmowanie";
            this.Odejmowanie.Size = new System.Drawing.Size(73, 69);
            this.Odejmowanie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Odejmowanie.TabIndex = 10;
            this.Odejmowanie.TabStop = false;
            this.Odejmowanie.Click += new System.EventHandler(this.Odejmowanie_Click);
            // 
            // Cztery
            // 
            this.Cztery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cztery.Image = ((System.Drawing.Image)(resources.GetObject("Cztery.Image")));
            this.Cztery.Location = new System.Drawing.Point(37, 201);
            this.Cztery.Name = "Cztery";
            this.Cztery.Size = new System.Drawing.Size(74, 69);
            this.Cztery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cztery.TabIndex = 9;
            this.Cztery.TabStop = false;
            this.Cztery.Click += new System.EventHandler(this.Cztery_Click);
            // 
            // Dwa
            // 
            this.Dwa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dwa.Image = ((System.Drawing.Image)(resources.GetObject("Dwa.Image")));
            this.Dwa.Location = new System.Drawing.Point(141, 117);
            this.Dwa.Name = "Dwa";
            this.Dwa.Size = new System.Drawing.Size(74, 69);
            this.Dwa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dwa.TabIndex = 8;
            this.Dwa.TabStop = false;
            this.Dwa.Click += new System.EventHandler(this.Dwa_Click);
            // 
            // Trzy
            // 
            this.Trzy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Trzy.Image = ((System.Drawing.Image)(resources.GetObject("Trzy.Image")));
            this.Trzy.Location = new System.Drawing.Point(252, 117);
            this.Trzy.Name = "Trzy";
            this.Trzy.Size = new System.Drawing.Size(73, 69);
            this.Trzy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Trzy.TabIndex = 7;
            this.Trzy.TabStop = false;
            this.Trzy.Click += new System.EventHandler(this.Trzy_Click);
            // 
            // Dodawanie
            // 
            this.Dodawanie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dodawanie.Image = ((System.Drawing.Image)(resources.GetObject("Dodawanie.Image")));
            this.Dodawanie.Location = new System.Drawing.Point(352, 287);
            this.Dodawanie.Name = "Dodawanie";
            this.Dodawanie.Size = new System.Drawing.Size(73, 69);
            this.Dodawanie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dodawanie.TabIndex = 6;
            this.Dodawanie.TabStop = false;
            this.Dodawanie.Click += new System.EventHandler(this.Dodawanie_Click);
            // 
            // Jeden
            // 
            this.Jeden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Jeden.Image = ((System.Drawing.Image)(resources.GetObject("Jeden.Image")));
            this.Jeden.Location = new System.Drawing.Point(37, 117);
            this.Jeden.Name = "Jeden";
            this.Jeden.Size = new System.Drawing.Size(74, 69);
            this.Jeden.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Jeden.TabIndex = 5;
            this.Jeden.TabStop = false;
            this.Jeden.Click += new System.EventHandler(this.Jeden_Click);
            // 
            // Rownosc
            // 
            this.Rownosc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rownosc.Image = ((System.Drawing.Image)(resources.GetObject("Rownosc.Image")));
            this.Rownosc.Location = new System.Drawing.Point(352, 368);
            this.Rownosc.Name = "Rownosc";
            this.Rownosc.Size = new System.Drawing.Size(73, 69);
            this.Rownosc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Rownosc.TabIndex = 3;
            this.Rownosc.TabStop = false;
            this.Rownosc.Click += new System.EventHandler(this.Rownosc_Click);
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(463, 650);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Wyjscie)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pierwiastek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Procenty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Potegowanie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kasowanie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Przecinek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Osiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mnozenie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dziewiec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dzielenie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Siedem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Piec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Szesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Odejmowanie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cztery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dwa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trzy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dodawanie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jeden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rownosc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Wynik;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox Rownosc;
        private System.Windows.Forms.PictureBox Dziewiec;
        private System.Windows.Forms.PictureBox Dzielenie;
        private System.Windows.Forms.PictureBox Siedem;
        private System.Windows.Forms.PictureBox Piec;
        private System.Windows.Forms.PictureBox Szesc;
        private System.Windows.Forms.PictureBox Odejmowanie;
        private System.Windows.Forms.PictureBox Cztery;
        private System.Windows.Forms.PictureBox Dwa;
        private System.Windows.Forms.PictureBox Trzy;
        private System.Windows.Forms.PictureBox Dodawanie;
        private System.Windows.Forms.PictureBox Jeden;
        private System.Windows.Forms.PictureBox Mnozenie;
        private System.Windows.Forms.PictureBox Osiem;
        private System.Windows.Forms.PictureBox Wyjscie;
        private System.Windows.Forms.PictureBox Zero;
        private System.Windows.Forms.PictureBox Kasowanie;
        private System.Windows.Forms.PictureBox Przecinek;
        private System.Windows.Forms.PictureBox Potegowanie;
        private System.Windows.Forms.PictureBox Procenty;
        private System.Windows.Forms.PictureBox Pierwiastek;
    }
}

