namespace GeografskaKartaNovo
{
    partial class FormTackastiObjekti
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
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnDodajNovi = new System.Windows.Forms.Button();
            this.listViewGeografski = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(318, 397);
            this.btnPrikazi.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(99, 38);
            this.btnPrikazi.TabIndex = 9;
            this.btnPrikazi.Text = "Prikazi informacije";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(224, 397);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(2);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(79, 38);
            this.btnObrisi.TabIndex = 8;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Location = new System.Drawing.Point(118, 397);
            this.btnAzuriraj.Margin = new System.Windows.Forms.Padding(2);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(91, 38);
            this.btnAzuriraj.TabIndex = 7;
            this.btnAzuriraj.Text = "Azuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // btnDodajNovi
            // 
            this.btnDodajNovi.Location = new System.Drawing.Point(9, 397);
            this.btnDodajNovi.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajNovi.Name = "btnDodajNovi";
            this.btnDodajNovi.Size = new System.Drawing.Size(96, 38);
            this.btnDodajNovi.TabIndex = 6;
            this.btnDodajNovi.Text = "Dodaj novi";
            this.btnDodajNovi.UseVisualStyleBackColor = true;
            this.btnDodajNovi.Click += new System.EventHandler(this.btnDodajNovi_Click);
            // 
            // listViewGeografski
            // 
            this.listViewGeografski.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader13,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listViewGeografski.FullRowSelect = true;
            this.listViewGeografski.Location = new System.Drawing.Point(9, 10);
            this.listViewGeografski.Margin = new System.Windows.Forms.Padding(2);
            this.listViewGeografski.Name = "listViewGeografski";
            this.listViewGeografski.Size = new System.Drawing.Size(705, 373);
            this.listViewGeografski.TabIndex = 5;
            this.listViewGeografski.UseCompatibleStateImageBehavior = false;
            this.listViewGeografski.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "NAZIV";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "X_KOORD";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Y_KOORD";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "DATUM_OSNIVANJA";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "F_NASELJENO";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "F_TURISTICKO";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "BROJ_STANOVNIKA";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "TIP_NASELJA";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "OPSTINA";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "DATUM_STATUS";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "TIP_TURIZMA";
            // 
            // FormTackastiObjekti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 454);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnDodajNovi);
            this.Controls.Add(this.listViewGeografski);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(453, 493);
            this.Name = "FormTackastiObjekti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prikaz svih tackastih objekata";
            this.Load += new System.EventHandler(this.FormTackastiObjekti_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnDodajNovi;
        private System.Windows.Forms.ListView listViewGeografski;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}