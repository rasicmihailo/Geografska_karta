namespace GeografskaKartaNovo
{
    partial class MFormDodajAzurirajLinijskiObjekat
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
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtDuzina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmxTip = new System.Windows.Forms.ComboBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.listViewKoordinate = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.btnDodajKoordinate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.listViewTackasti = new System.Windows.Forms.ListView();
            this.label9 = new System.Windows.Forms.Label();
            this.listViewPovrsinki = new System.Windows.Forms.ListView();
            this.btnDodajPostojeciTackasti = new System.Windows.Forms.Button();
            this.btnDodajNoviTackasti = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.listViewSvihTackastihObjekata = new System.Windows.Forms.ListView();
            this.label10 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(139, 15);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(184, 22);
            this.txtNaziv.TabIndex = 1;
            this.txtNaziv.TextChanged += new System.EventHandler(this.txtNaziv_TextChanged);
            // 
            // txtDuzina
            // 
            this.txtDuzina.Location = new System.Drawing.Point(139, 62);
            this.txtDuzina.Name = "txtDuzina";
            this.txtDuzina.Size = new System.Drawing.Size(184, 22);
            this.txtDuzina.TabIndex = 2;
            this.txtDuzina.TextChanged += new System.EventHandler(this.txtDuzina_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Duzina:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tip objekta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Opis objekta:";
            // 
            // cmxTip
            // 
            this.cmxTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmxTip.FormattingEnabled = true;
            this.cmxTip.Items.AddRange(new object[] {
            "Reka",
            "Granica",
            "Put"});
            this.cmxTip.Location = new System.Drawing.Point(139, 110);
            this.cmxTip.Name = "cmxTip";
            this.cmxTip.Size = new System.Drawing.Size(184, 24);
            this.cmxTip.TabIndex = 6;
            this.cmxTip.SelectedIndexChanged += new System.EventHandler(this.cmxTip_SelectedIndexChanged);
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(139, 153);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(184, 22);
            this.txtOpis.TabIndex = 7;
            this.txtOpis.TextChanged += new System.EventHandler(this.txtOpis_TextChanged);
            // 
            // listViewKoordinate
            // 
            this.listViewKoordinate.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10});
            this.listViewKoordinate.FullRowSelect = true;
            this.listViewKoordinate.Location = new System.Drawing.Point(16, 222);
            this.listViewKoordinate.Name = "listViewKoordinate";
            this.listViewKoordinate.Size = new System.Drawing.Size(307, 116);
            this.listViewKoordinate.TabIndex = 8;
            this.listViewKoordinate.UseCompatibleStateImageBehavior = false;
            this.listViewKoordinate.View = System.Windows.Forms.View.Details;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Lista koordinata:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "X:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(112, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Y:";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(37, 360);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(48, 22);
            this.txtX.TabIndex = 12;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(139, 360);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(52, 22);
            this.txtY.TabIndex = 13;
            // 
            // btnDodajKoordinate
            // 
            this.btnDodajKoordinate.Location = new System.Drawing.Point(230, 360);
            this.btnDodajKoordinate.Name = "btnDodajKoordinate";
            this.btnDodajKoordinate.Size = new System.Drawing.Size(93, 47);
            this.btnDodajKoordinate.TabIndex = 14;
            this.btnDodajKoordinate.Text = "Dodaj koordinatu";
            this.btnDodajKoordinate.UseVisualStyleBackColor = true;
            this.btnDodajKoordinate.Click += new System.EventHandler(this.btnDodajKoordinate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 408);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(287, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Lista tackastih objekata na linijskom objektu:";
            // 
            // listViewTackasti
            // 
            this.listViewTackasti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listViewTackasti.FullRowSelect = true;
            this.listViewTackasti.Location = new System.Drawing.Point(12, 428);
            this.listViewTackasti.Name = "listViewTackasti";
            this.listViewTackasti.Size = new System.Drawing.Size(307, 132);
            this.listViewTackasti.TabIndex = 16;
            this.listViewTackasti.UseCompatibleStateImageBehavior = false;
            this.listViewTackasti.View = System.Windows.Forms.View.Details;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(369, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Lista povrsinskih objekata:";
            // 
            // listViewPovrsinki
            // 
            this.listViewPovrsinki.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewPovrsinki.Location = new System.Drawing.Point(372, 43);
            this.listViewPovrsinki.Name = "listViewPovrsinki";
            this.listViewPovrsinki.Size = new System.Drawing.Size(307, 295);
            this.listViewPovrsinki.TabIndex = 18;
            this.listViewPovrsinki.UseCompatibleStateImageBehavior = false;
            this.listViewPovrsinki.View = System.Windows.Forms.View.Details;
            // 
            // btnDodajPostojeciTackasti
            // 
            this.btnDodajPostojeciTackasti.Location = new System.Drawing.Point(580, 583);
            this.btnDodajPostojeciTackasti.Name = "btnDodajPostojeciTackasti";
            this.btnDodajPostojeciTackasti.Size = new System.Drawing.Size(99, 63);
            this.btnDodajPostojeciTackasti.TabIndex = 19;
            this.btnDodajPostojeciTackasti.Text = "Dodaj postojeci objekat";
            this.btnDodajPostojeciTackasti.UseVisualStyleBackColor = true;
            this.btnDodajPostojeciTackasti.Click += new System.EventHandler(this.btnDodajPostojeciTackasti_Click);
            // 
            // btnDodajNoviTackasti
            // 
            this.btnDodajNoviTackasti.Location = new System.Drawing.Point(11, 583);
            this.btnDodajNoviTackasti.Name = "btnDodajNoviTackasti";
            this.btnDodajNoviTackasti.Size = new System.Drawing.Size(93, 54);
            this.btnDodajNoviTackasti.TabIndex = 20;
            this.btnDodajNoviTackasti.Text = "Dodaj novi tackasti";
            this.btnDodajNoviTackasti.UseVisualStyleBackColor = true;
            this.btnDodajNoviTackasti.Click += new System.EventHandler(this.btnDodajNoviTackasti_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(211, 634);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(105, 55);
            this.btnOK.TabIndex = 21;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(349, 634);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(100, 55);
            this.btnOtkazi.TabIndex = 22;
            this.btnOtkazi.Text = "Otkazi";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // listViewSvihTackastihObjekata
            // 
            this.listViewSvihTackastihObjekata.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewSvihTackastihObjekata.FullRowSelect = true;
            this.listViewSvihTackastihObjekata.Location = new System.Drawing.Point(349, 428);
            this.listViewSvihTackastihObjekata.Name = "listViewSvihTackastihObjekata";
            this.listViewSvihTackastihObjekata.Size = new System.Drawing.Size(330, 132);
            this.listViewSvihTackastihObjekata.TabIndex = 23;
            this.listViewSvihTackastihObjekata.UseCompatibleStateImageBehavior = false;
            this.listViewSvihTackastihObjekata.View = System.Windows.Forms.View.Details;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(346, 408);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(189, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "Lista svih tackastih objekata:";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Naziv";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ID";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Naziv";
            this.columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Opstina";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ID";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Naziv";
            this.columnHeader7.Width = 70;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Opstina";
            this.columnHeader8.Width = 80;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "X";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Y";
            // 
            // MFormDodajAzurirajLinijskiObjekat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 697);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.listViewSvihTackastihObjekata);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnDodajNoviTackasti);
            this.Controls.Add(this.btnDodajPostojeciTackasti);
            this.Controls.Add(this.listViewPovrsinki);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listViewTackasti);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnDodajKoordinate);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listViewKoordinate);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.cmxTip);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDuzina);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(718, 744);
            this.MinimumSize = new System.Drawing.Size(718, 744);
            this.Name = "MFormDodajAzurirajLinijskiObjekat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj ili azuriraj linijski element";
            this.Load += new System.EventHandler(this.MFormDodajAzurirajLinijskiObjekat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtDuzina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmxTip;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.ListView listViewKoordinate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Button btnDodajKoordinate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView listViewTackasti;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView listViewPovrsinki;
        private System.Windows.Forms.Button btnDodajPostojeciTackasti;
        private System.Windows.Forms.Button btnDodajNoviTackasti;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.ListView listViewSvihTackastihObjekata;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}