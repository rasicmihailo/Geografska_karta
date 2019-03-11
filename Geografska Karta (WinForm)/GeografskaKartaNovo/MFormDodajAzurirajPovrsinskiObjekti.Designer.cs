namespace GeografskaKartaNovo
{
    partial class MFormDodajAzurirajPovrsinskiObjekti
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
            this.label1 = new System.Windows.Forms.Label();
            this.listViewLinijskihObjekata = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewSviLinijskiObjekti = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDodajNoviLinijski = new System.Windows.Forms.Button();
            this.btnDodajPostojeci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Lista linijskih objekata:";
            // 
            // listViewLinijskihObjekata
            // 
            this.listViewLinijskihObjekata.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listViewLinijskihObjekata.FullRowSelect = true;
            this.listViewLinijskihObjekata.Location = new System.Drawing.Point(12, 82);
            this.listViewLinijskihObjekata.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewLinijskihObjekata.Name = "listViewLinijskihObjekata";
            this.listViewLinijskihObjekata.Size = new System.Drawing.Size(384, 203);
            this.listViewLinijskihObjekata.TabIndex = 10;
            this.listViewLinijskihObjekata.UseCompatibleStateImageBehavior = false;
            this.listViewLinijskihObjekata.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "NAZIV";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "DUZINA";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "TIP";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "OPIS";
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(441, 394);
            this.btnOtkazi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(107, 54);
            this.btnOtkazi.TabIndex = 9;
            this.btnOtkazi.Text = "Otkazi";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(291, 400);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(107, 48);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(115, 14);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(255, 22);
            this.txtNaziv.TabIndex = 7;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(12, 14);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(97, 17);
            this.lblNaziv.TabIndex = 6;
            this.lblNaziv.Text = "Naziv objekta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Lista svih linijskih objekata:";
            // 
            // listViewSviLinijskiObjekti
            // 
            this.listViewSviLinijskiObjekti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listViewSviLinijskiObjekti.FullRowSelect = true;
            this.listViewSviLinijskiObjekti.Location = new System.Drawing.Point(439, 82);
            this.listViewSviLinijskiObjekti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewSviLinijskiObjekti.Name = "listViewSviLinijskiObjekti";
            this.listViewSviLinijskiObjekti.Size = new System.Drawing.Size(393, 203);
            this.listViewSviLinijskiObjekti.TabIndex = 12;
            this.listViewSviLinijskiObjekti.UseCompatibleStateImageBehavior = false;
            this.listViewSviLinijskiObjekti.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ID";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "NAZIV";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "DUZINA";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "TIP";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "OPIS";
            // 
            // btnDodajNoviLinijski
            // 
            this.btnDodajNoviLinijski.Location = new System.Drawing.Point(15, 303);
            this.btnDodajNoviLinijski.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodajNoviLinijski.Name = "btnDodajNoviLinijski";
            this.btnDodajNoviLinijski.Size = new System.Drawing.Size(107, 42);
            this.btnDodajNoviLinijski.TabIndex = 14;
            this.btnDodajNoviLinijski.Text = "Dodaj novi linijski objekat";
            this.btnDodajNoviLinijski.UseVisualStyleBackColor = true;
            this.btnDodajNoviLinijski.Click += new System.EventHandler(this.btnDodajNoviLinijski_Click);
            // 
            // btnDodajPostojeci
            // 
            this.btnDodajPostojeci.Location = new System.Drawing.Point(435, 302);
            this.btnDodajPostojeci.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodajPostojeci.Name = "btnDodajPostojeci";
            this.btnDodajPostojeci.Size = new System.Drawing.Size(113, 43);
            this.btnDodajPostojeci.TabIndex = 15;
            this.btnDodajPostojeci.Text = "Dodaj postojeci objekat";
            this.btnDodajPostojeci.UseVisualStyleBackColor = true;
            this.btnDodajPostojeci.Click += new System.EventHandler(this.btnDodajPostojeci_Click);
            // 
            // MFormDodajAzurirajPovrsinskiObjekti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 479);
            this.Controls.Add(this.btnDodajPostojeci);
            this.Controls.Add(this.btnDodajNoviLinijski);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewSviLinijskiObjekti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewLinijskihObjekata);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblNaziv);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MFormDodajAzurirajPovrsinskiObjekti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj ili azuriraj povrsinski objekat";
            this.Load += new System.EventHandler(this.MFormDodajAzurirajPovrsinskiObjekti_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewLinijskihObjekata;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewSviLinijskiObjekti;
        private System.Windows.Forms.Button btnDodajNoviLinijski;
        private System.Windows.Forms.Button btnDodajPostojeci;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
    }
}