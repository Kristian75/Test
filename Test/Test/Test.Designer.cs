namespace Test
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDodajOsobu = new System.Windows.Forms.Button();
            this.btnPrikaziOsobe = new System.Windows.Forms.Button();
            this.btnFiltriraj = new System.Windows.Forms.Button();
            this.btnObradiPodatke = new System.Windows.Forms.Button();
            this.btnSortirajPoImenu = new System.Windows.Forms.Button();
            this.btnSpremiUCSV = new System.Windows.Forms.Button();
            this.btnUcitajIzCSV = new System.Windows.Forms.Button();
            this.cmbUloga = new System.Windows.Forms.ComboBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.dgvOsobe = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFiltrirajUloga = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIspis = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOsobe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajOsobu
            // 
            this.btnDodajOsobu.Location = new System.Drawing.Point(78, 307);
            this.btnDodajOsobu.Name = "btnDodajOsobu";
            this.btnDodajOsobu.Size = new System.Drawing.Size(124, 57);
            this.btnDodajOsobu.TabIndex = 0;
            this.btnDodajOsobu.Text = "Dodaj Osobu";
            this.btnDodajOsobu.UseVisualStyleBackColor = true;
            // 
            // btnPrikaziOsobe
            // 
            this.btnPrikaziOsobe.Location = new System.Drawing.Point(208, 307);
            this.btnPrikaziOsobe.Name = "btnPrikaziOsobe";
            this.btnPrikaziOsobe.Size = new System.Drawing.Size(124, 57);
            this.btnPrikaziOsobe.TabIndex = 1;
            this.btnPrikaziOsobe.Text = "Prikazi Osobe";
            this.btnPrikaziOsobe.UseVisualStyleBackColor = true;
            // 
            // btnFiltriraj
            // 
            this.btnFiltriraj.Location = new System.Drawing.Point(338, 307);
            this.btnFiltriraj.Name = "btnFiltriraj";
            this.btnFiltriraj.Size = new System.Drawing.Size(124, 57);
            this.btnFiltriraj.TabIndex = 2;
            this.btnFiltriraj.Text = "Filtriraj";
            this.btnFiltriraj.UseVisualStyleBackColor = true;
            // 
            // btnObradiPodatke
            // 
            this.btnObradiPodatke.Location = new System.Drawing.Point(283, 370);
            this.btnObradiPodatke.Name = "btnObradiPodatke";
            this.btnObradiPodatke.Size = new System.Drawing.Size(124, 57);
            this.btnObradiPodatke.TabIndex = 3;
            this.btnObradiPodatke.Text = "Obradi Podatke";
            this.btnObradiPodatke.UseVisualStyleBackColor = true;
            // 
            // btnSortirajPoImenu
            // 
            this.btnSortirajPoImenu.Location = new System.Drawing.Point(413, 370);
            this.btnSortirajPoImenu.Name = "btnSortirajPoImenu";
            this.btnSortirajPoImenu.Size = new System.Drawing.Size(124, 57);
            this.btnSortirajPoImenu.TabIndex = 4;
            this.btnSortirajPoImenu.Text = "Sortiraj po imenu";
            this.btnSortirajPoImenu.UseVisualStyleBackColor = true;
            // 
            // btnSpremiUCSV
            // 
            this.btnSpremiUCSV.Location = new System.Drawing.Point(468, 307);
            this.btnSpremiUCSV.Name = "btnSpremiUCSV";
            this.btnSpremiUCSV.Size = new System.Drawing.Size(122, 57);
            this.btnSpremiUCSV.TabIndex = 5;
            this.btnSpremiUCSV.Text = "Spremi u CSV";
            this.btnSpremiUCSV.UseVisualStyleBackColor = true;
            // 
            // btnUcitajIzCSV
            // 
            this.btnUcitajIzCSV.Location = new System.Drawing.Point(596, 307);
            this.btnUcitajIzCSV.Name = "btnUcitajIzCSV";
            this.btnUcitajIzCSV.Size = new System.Drawing.Size(124, 57);
            this.btnUcitajIzCSV.TabIndex = 6;
            this.btnUcitajIzCSV.Text = "Ucitaj  iz CSV";
            this.btnUcitajIzCSV.UseVisualStyleBackColor = true;
            this.btnUcitajIzCSV.Click += new System.EventHandler(this.btnUcitajIzCSV_Click);
            // 
            // cmbUloga
            // 
            this.cmbUloga.FormattingEnabled = true;
            this.cmbUloga.Location = new System.Drawing.Point(137, 179);
            this.cmbUloga.Name = "cmbUloga";
            this.cmbUloga.Size = new System.Drawing.Size(250, 28);
            this.cmbUloga.TabIndex = 7;
            // 
            // txtIme
            // 
            this.txtIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtIme.Location = new System.Drawing.Point(137, 118);
            this.txtIme.Multiline = true;
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(250, 38);
            this.txtIme.TabIndex = 9;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPrezime.Location = new System.Drawing.Point(137, 69);
            this.txtPrezime.Multiline = true;
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(250, 39);
            this.txtPrezime.TabIndex = 10;
            // 
            // dgvOsobe
            // 
            this.dgvOsobe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOsobe.Location = new System.Drawing.Point(448, 159);
            this.dgvOsobe.Name = "dgvOsobe";
            this.dgvOsobe.RowHeadersWidth = 62;
            this.dgvOsobe.RowTemplate.Height = 28;
            this.dgvOsobe.Size = new System.Drawing.Size(272, 106);
            this.dgvOsobe.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(81, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(42, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Prezime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(62, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Uloga:";
            // 
            // cmbFiltrirajUloga
            // 
            this.cmbFiltrirajUloga.FormattingEnabled = true;
            this.cmbFiltrirajUloga.Location = new System.Drawing.Point(137, 224);
            this.cmbFiltrirajUloga.Name = "cmbFiltrirajUloga";
            this.cmbFiltrirajUloga.Size = new System.Drawing.Size(250, 28);
            this.cmbFiltrirajUloga.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(4, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Filtriraj uloge:";
            // 
            // txtIspis
            // 
            this.txtIspis.Location = new System.Drawing.Point(448, 44);
            this.txtIspis.Multiline = true;
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.Size = new System.Drawing.Size(272, 109);
            this.txtIspis.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIspis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbFiltrirajUloga);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvOsobe);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.cmbUloga);
            this.Controls.Add(this.btnUcitajIzCSV);
            this.Controls.Add(this.btnSpremiUCSV);
            this.Controls.Add(this.btnSortirajPoImenu);
            this.Controls.Add(this.btnObradiPodatke);
            this.Controls.Add(this.btnFiltriraj);
            this.Controls.Add(this.btnPrikaziOsobe);
            this.Controls.Add(this.btnDodajOsobu);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOsobe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajOsobu;
        private System.Windows.Forms.Button btnPrikaziOsobe;
        private System.Windows.Forms.Button btnFiltriraj;
        private System.Windows.Forms.Button btnObradiPodatke;
        private System.Windows.Forms.Button btnSortirajPoImenu;
        private System.Windows.Forms.Button btnSpremiUCSV;
        private System.Windows.Forms.Button btnUcitajIzCSV;
        private System.Windows.Forms.ComboBox cmbUloga;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.DataGridView dgvOsobe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFiltrirajUloga;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIspis;
    }
}

