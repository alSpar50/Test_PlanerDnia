namespace Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNazwaZadania = new System.Windows.Forms.TextBox();
            this.btnDodajZadanie = new System.Windows.Forms.Button();
            this.listBoxZadania = new System.Windows.Forms.ListBox();
            this.cmbWaznosc = new System.Windows.Forms.ComboBox();
            this.btnUsunZadanie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Twoja lista zadań";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNazwaZadania
            // 
            this.txtNazwaZadania.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNazwaZadania.Location = new System.Drawing.Point(104, 78);
            this.txtNazwaZadania.Name = "txtNazwaZadania";
            this.txtNazwaZadania.Size = new System.Drawing.Size(387, 20);
            this.txtNazwaZadania.TabIndex = 1;
            this.txtNazwaZadania.Text = "Wpisz swoje zadanie";
            this.txtNazwaZadania.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnDodajZadanie
            // 
            this.btnDodajZadanie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDodajZadanie.Location = new System.Drawing.Point(104, 311);
            this.btnDodajZadanie.Name = "btnDodajZadanie";
            this.btnDodajZadanie.Size = new System.Drawing.Size(387, 28);
            this.btnDodajZadanie.TabIndex = 2;
            this.btnDodajZadanie.Text = "Dodaj zadanie";
            this.btnDodajZadanie.UseVisualStyleBackColor = true;
            this.btnDodajZadanie.Click += new System.EventHandler(this.btnDodajZadanie_Click);
            // 
            // listBoxZadania
            // 
            this.listBoxZadania.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxZadania.FormattingEnabled = true;
            this.listBoxZadania.Location = new System.Drawing.Point(104, 131);
            this.listBoxZadania.Name = "listBoxZadania";
            this.listBoxZadania.Size = new System.Drawing.Size(387, 160);
            this.listBoxZadania.TabIndex = 3;
            this.listBoxZadania.Tag = "";
            this.listBoxZadania.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // cmbWaznosc
            // 
            this.cmbWaznosc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbWaznosc.FormattingEnabled = true;
            this.cmbWaznosc.Location = new System.Drawing.Point(544, 131);
            this.cmbWaznosc.Name = "cmbWaznosc";
            this.cmbWaznosc.Size = new System.Drawing.Size(368, 21);
            this.cmbWaznosc.TabIndex = 4;
            this.cmbWaznosc.SelectedIndexChanged += new System.EventHandler(this.cmbWaznosc_SelectedIndexChanged);
            // 
            // btnUsunZadanie
            // 
            this.btnUsunZadanie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUsunZadanie.Location = new System.Drawing.Point(103, 359);
            this.btnUsunZadanie.Name = "btnUsunZadanie";
            this.btnUsunZadanie.Size = new System.Drawing.Size(388, 23);
            this.btnUsunZadanie.TabIndex = 5;
            this.btnUsunZadanie.Text = "Usuń zadanie";
            this.btnUsunZadanie.UseVisualStyleBackColor = true;
            this.btnUsunZadanie.Click += new System.EventHandler(this.btnUsunZadanie_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 418);
            this.Controls.Add(this.btnUsunZadanie);
            this.Controls.Add(this.cmbWaznosc);
            this.Controls.Add(this.listBoxZadania);
            this.Controls.Add(this.btnDodajZadanie);
            this.Controls.Add(this.txtNazwaZadania);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Zarządzaj dniem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNazwaZadania;
        private System.Windows.Forms.Button btnDodajZadanie;
        private System.Windows.Forms.ListBox listBoxZadania;
        private System.Windows.Forms.ComboBox cmbWaznosc;
        private System.Windows.Forms.Button btnUsunZadanie;
    }
}

