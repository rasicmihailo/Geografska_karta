namespace GeografskaKartaNovo
{
    partial class MFormDodajAzurirajUzvisenje
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
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.listViewSvihGeografskihObjekata = new System.Windows.Forms.ListView();
            this.btnDodajNoviGeog = new System.Windows.Forms.Button();
            this.btnDodajPostojeciGeografski = new System.Windows.Forms.Button();
            this.listViewGeografski = new System.Windows.Forms.ListView();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVisina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listViewListaSvihVrhova = new System.Windows.Forms.ListView();
            this.btnDodajNoviVrh = new System.Windows.Forms.Button();
            this.btnDodajPostojeciVrh = new System.Windows.Forms.Button();
            this.listViewListaVrhova = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.txtVisinaNovogVrha = new System.Windows.Forms.TextBox();
            this.txtNazivVrha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(140, 28);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(184, 22);
            this.txtNaziv.TabIndex = 3;
            this.txtNaziv.TextChanged += new System.EventHandler(this.txtNaziv_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Naziv:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(364, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(207, 17);
            this.label10.TabIndex = 30;
            this.label10.Text = "Lista svih geografskih objekata:";
            // 
            // listViewSvihGeografskihObjekata
            // 
            this.listViewSvihGeografskihObjekata.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewSvihGeografskihObjekata.FullRowSelect = true;
            this.listViewSvihGeografskihObjekata.Location = new System.Drawing.Point(367, 147);
            this.listViewSvihGeografskihObjekata.Name = "listViewSvihGeografskihObjekata";
            this.listViewSvihGeografskihObjekata.Size = new System.Drawing.Size(330, 132);
            this.listViewSvihGeografskihObjekata.TabIndex = 29;
            this.listViewSvihGeografskihObjekata.UseCompatibleStateImageBehavior = false;
            this.listViewSvihGeografskihObjekata.View = System.Windows.Forms.View.Details;
            // 
            // btnDodajNoviGeog
            // 
            this.btnDodajNoviGeog.Location = new System.Drawing.Point(730, 224);
            this.btnDodajNoviGeog.Name = "btnDodajNoviGeog";
            this.btnDodajNoviGeog.Size = new System.Drawing.Size(154, 55);
            this.btnDodajNoviGeog.TabIndex = 28;
            this.btnDodajNoviGeog.Text = "Dodaj novi geografski objekat";
            this.btnDodajNoviGeog.UseVisualStyleBackColor = true;
            this.btnDodajNoviGeog.Click += new System.EventHandler(this.btnDodajNoviGeog_Click);
            // 
            // btnDodajPostojeciGeografski
            // 
            this.btnDodajPostojeciGeografski.Location = new System.Drawing.Point(731, 147);
            this.btnDodajPostojeciGeografski.Name = "btnDodajPostojeciGeografski";
            this.btnDodajPostojeciGeografski.Size = new System.Drawing.Size(153, 63);
            this.btnDodajPostojeciGeografski.TabIndex = 27;
            this.btnDodajPostojeciGeografski.Text = "Dodaj postojeci objekat";
            this.btnDodajPostojeciGeografski.UseVisualStyleBackColor = true;
            this.btnDodajPostojeciGeografski.Click += new System.EventHandler(this.btnDodajPostojeciGeografski_Click);
            // 
            // listViewGeografski
            // 
            this.listViewGeografski.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.listViewGeografski.FullRowSelect = true;
            this.listViewGeografski.Location = new System.Drawing.Point(3, 147);
            this.listViewGeografski.Name = "listViewGeografski";
            this.listViewGeografski.Size = new System.Drawing.Size(327, 132);
            this.listViewGeografski.TabIndex = 26;
            this.listViewGeografski.UseCompatibleStateImageBehavior = false;
            this.listViewGeografski.View = System.Windows.Forms.View.Details;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "Lista geografskih objekata:";
            // 
            // txtVisina
            // 
            this.txtVisina.Location = new System.Drawing.Point(140, 75);
            this.txtVisina.Name = "txtVisina";
            this.txtVisina.Size = new System.Drawing.Size(184, 22);
            this.txtVisina.TabIndex = 32;
            this.txtVisina.TextChanged += new System.EventHandler(this.txtVisina_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nadmorska visina:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 44;
            this.label5.Text = "Lista svih vrhova:";
            // 
            // listViewListaSvihVrhova
            // 
            this.listViewListaSvihVrhova.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listViewListaSvihVrhova.FullRowSelect = true;
            this.listViewListaSvihVrhova.Location = new System.Drawing.Point(367, 334);
            this.listViewListaSvihVrhova.Name = "listViewListaSvihVrhova";
            this.listViewListaSvihVrhova.Size = new System.Drawing.Size(330, 132);
            this.listViewListaSvihVrhova.TabIndex = 43;
            this.listViewListaSvihVrhova.UseCompatibleStateImageBehavior = false;
            this.listViewListaSvihVrhova.View = System.Windows.Forms.View.Details;
            // 
            // btnDodajNoviVrh
            // 
            this.btnDodajNoviVrh.Location = new System.Drawing.Point(730, 411);
            this.btnDodajNoviVrh.Name = "btnDodajNoviVrh";
            this.btnDodajNoviVrh.Size = new System.Drawing.Size(154, 55);
            this.btnDodajNoviVrh.TabIndex = 42;
            this.btnDodajNoviVrh.Text = "Dodaj novi vrh";
            this.btnDodajNoviVrh.UseVisualStyleBackColor = true;
            this.btnDodajNoviVrh.Click += new System.EventHandler(this.btnDodajNoviVrh_Click);
            // 
            // btnDodajPostojeciVrh
            // 
            this.btnDodajPostojeciVrh.Location = new System.Drawing.Point(731, 334);
            this.btnDodajPostojeciVrh.Name = "btnDodajPostojeciVrh";
            this.btnDodajPostojeciVrh.Size = new System.Drawing.Size(153, 63);
            this.btnDodajPostojeciVrh.TabIndex = 41;
            this.btnDodajPostojeciVrh.Text = "Dodaj postojeci objekat";
            this.btnDodajPostojeciVrh.UseVisualStyleBackColor = true;
            this.btnDodajPostojeciVrh.Click += new System.EventHandler(this.btnDodajPostojeciVrh_Click);
            // 
            // listViewListaVrhova
            // 
            this.listViewListaVrhova.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listViewListaVrhova.FullRowSelect = true;
            this.listViewListaVrhova.Location = new System.Drawing.Point(3, 334);
            this.listViewListaVrhova.Name = "listViewListaVrhova";
            this.listViewListaVrhova.Size = new System.Drawing.Size(327, 132);
            this.listViewListaVrhova.TabIndex = 40;
            this.listViewListaVrhova.UseCompatibleStateImageBehavior = false;
            this.listViewListaVrhova.View = System.Windows.Forms.View.Details;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 39;
            this.label6.Text = "Lista vrhova:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(216, 488);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(108, 47);
            this.btnOK.TabIndex = 45;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(367, 488);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(105, 47);
            this.btnOtkazi.TabIndex = 46;
            this.btnOtkazi.Text = "Otkazi";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // txtVisinaNovogVrha
            // 
            this.txtVisinaNovogVrha.Location = new System.Drawing.Point(750, 527);
            this.txtVisinaNovogVrha.Name = "txtVisinaNovogVrha";
            this.txtVisinaNovogVrha.Size = new System.Drawing.Size(134, 22);
            this.txtVisinaNovogVrha.TabIndex = 54;
            // 
            // txtNazivVrha
            // 
            this.txtNazivVrha.Location = new System.Drawing.Point(750, 488);
            this.txtNazivVrha.Name = "txtNazivVrha";
            this.txtNazivVrha.Size = new System.Drawing.Size(134, 22);
            this.txtNazivVrha.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(668, 515);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 34);
            this.label4.TabIndex = 52;
            this.label4.Text = "Nadmorska\r\nvisina:\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(668, 488);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 51;
            this.label3.Text = "Naziv:";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Naziv";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ID";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Naziv";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ID";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Naziv";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Nadmorska visina";
            this.columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "ID";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Naziv";
            this.columnHeader9.Width = 80;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Nadmorska visina";
            this.columnHeader10.Width = 150;
            // 
            // MFormDodajAzurirajUzvisenje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 573);
            this.Controls.Add(this.txtVisinaNovogVrha);
            this.Controls.Add(this.txtNazivVrha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listViewListaSvihVrhova);
            this.Controls.Add(this.btnDodajNoviVrh);
            this.Controls.Add(this.btnDodajPostojeciVrh);
            this.Controls.Add(this.listViewListaVrhova);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtVisina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.listViewSvihGeografskihObjekata);
            this.Controls.Add(this.btnDodajNoviGeog);
            this.Controls.Add(this.btnDodajPostojeciGeografski);
            this.Controls.Add(this.listViewGeografski);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(921, 620);
            this.MinimumSize = new System.Drawing.Size(921, 620);
            this.Name = "MFormDodajAzurirajUzvisenje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj ili azuriraj uzvisenje";
            this.Load += new System.EventHandler(this.MFormDodajAzurirajUzvisenje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView listViewSvihGeografskihObjekata;
        private System.Windows.Forms.Button btnDodajNoviGeog;
        private System.Windows.Forms.Button btnDodajPostojeciGeografski;
        private System.Windows.Forms.ListView listViewGeografski;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtVisina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listViewListaSvihVrhova;
        private System.Windows.Forms.Button btnDodajNoviVrh;
        private System.Windows.Forms.Button btnDodajPostojeciVrh;
        private System.Windows.Forms.ListView listViewListaVrhova;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.TextBox txtVisinaNovogVrha;
        private System.Windows.Forms.TextBox txtNazivVrha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}