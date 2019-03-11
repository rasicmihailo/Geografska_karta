namespace GeografskaKartaNovo
{
    partial class MFormDodajAzurirajTackastiObjekat
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
            this.cmxTip = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOpstina = new System.Windows.Forms.TextBox();
            this.txtBrojStanovnika = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxTipNaselja = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxTipTurizma = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateOsnivanje = new System.Windows.Forms.DateTimePicker();
            this.dateStatus = new System.Windows.Forms.DateTimePicker();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.listViewLinijski = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label14 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnDodajNovuZnamenitost = new System.Windows.Forms.Button();
            this.listViewZnamenitosti = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label15 = new System.Windows.Forms.Label();
            this.txtNovaZnamenitost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmxTip
            // 
            this.cmxTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmxTip.FormattingEnabled = true;
            this.cmxTip.Items.AddRange(new object[] {
            "Tackasti",
            "Naseljeno",
            "Turisticko"});
            this.cmxTip.Location = new System.Drawing.Point(106, 82);
            this.cmxTip.Margin = new System.Windows.Forms.Padding(2);
            this.cmxTip.Name = "cmxTip";
            this.cmxTip.Size = new System.Drawing.Size(139, 21);
            this.cmxTip.TabIndex = 14;
            this.cmxTip.SelectedIndexChanged += new System.EventHandler(this.cmxTip_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tip objekta:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(106, 10);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(2);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(139, 20);
            this.txtNaziv.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Naziv:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 161);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Opstina:";
            // 
            // txtOpstina
            // 
            this.txtOpstina.Location = new System.Drawing.Point(106, 153);
            this.txtOpstina.Margin = new System.Windows.Forms.Padding(2);
            this.txtOpstina.Name = "txtOpstina";
            this.txtOpstina.Size = new System.Drawing.Size(139, 20);
            this.txtOpstina.TabIndex = 18;
            // 
            // txtBrojStanovnika
            // 
            this.txtBrojStanovnika.Location = new System.Drawing.Point(106, 118);
            this.txtBrojStanovnika.Margin = new System.Windows.Forms.Padding(2);
            this.txtBrojStanovnika.Name = "txtBrojStanovnika";
            this.txtBrojStanovnika.Size = new System.Drawing.Size(139, 20);
            this.txtBrojStanovnika.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 122);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Broj stanovnika:";
            // 
            // comboBoxTipNaselja
            // 
            this.comboBoxTipNaselja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipNaselja.FormattingEnabled = true;
            this.comboBoxTipNaselja.Items.AddRange(new object[] {
            "1000-10000",
            "10000-100000",
            "100000-500000",
            "500000-1000000",
            "1000000-10000000"});
            this.comboBoxTipNaselja.Location = new System.Drawing.Point(106, 196);
            this.comboBoxTipNaselja.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTipNaselja.Name = "comboBoxTipNaselja";
            this.comboBoxTipNaselja.Size = new System.Drawing.Size(139, 21);
            this.comboBoxTipNaselja.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 196);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Tip naselja:";
            // 
            // comboBoxTipTurizma
            // 
            this.comboBoxTipTurizma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipTurizma.FormattingEnabled = true;
            this.comboBoxTipTurizma.Items.AddRange(new object[] {
            "banjski",
            "zimski",
            "letnji"});
            this.comboBoxTipTurizma.Location = new System.Drawing.Point(106, 239);
            this.comboBoxTipTurizma.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTipTurizma.Name = "comboBoxTipTurizma";
            this.comboBoxTipTurizma.Size = new System.Drawing.Size(139, 21);
            this.comboBoxTipTurizma.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 239);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Tip turizma:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 284);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Datum osnivanja:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 319);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Status turizma:";
            // 
            // dateOsnivanje
            // 
            this.dateOsnivanje.Location = new System.Drawing.Point(106, 284);
            this.dateOsnivanje.Margin = new System.Windows.Forms.Padding(2);
            this.dateOsnivanje.Name = "dateOsnivanje";
            this.dateOsnivanje.Size = new System.Drawing.Size(139, 20);
            this.dateOsnivanje.TabIndex = 26;
            // 
            // dateStatus
            // 
            this.dateStatus.Location = new System.Drawing.Point(106, 319);
            this.dateStatus.Margin = new System.Windows.Forms.Padding(2);
            this.dateStatus.Name = "dateStatus";
            this.dateStatus.Size = new System.Drawing.Size(138, 20);
            this.dateStatus.TabIndex = 27;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(205, 44);
            this.txtY.Margin = new System.Windows.Forms.Padding(2);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(40, 20);
            this.txtY.TabIndex = 31;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(128, 44);
            this.txtX.Margin = new System.Windows.Forms.Padding(2);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(37, 20);
            this.txtX.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(184, 44);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Y:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(108, 44);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "X:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 46);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Koordinate:";
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(305, 625);
            this.btnOtkazi.Margin = new System.Windows.Forms.Padding(2);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(75, 45);
            this.btnOtkazi.TabIndex = 36;
            this.btnOtkazi.Text = "Otkazi";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // listViewLinijski
            // 
            this.listViewLinijski.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewLinijski.FullRowSelect = true;
            this.listViewLinijski.Location = new System.Drawing.Point(293, 35);
            this.listViewLinijski.Margin = new System.Windows.Forms.Padding(2);
            this.listViewLinijski.Name = "listViewLinijski";
            this.listViewLinijski.Size = new System.Drawing.Size(231, 240);
            this.listViewLinijski.TabIndex = 34;
            this.listViewLinijski.UseCompatibleStateImageBehavior = false;
            this.listViewLinijski.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "NAZIV";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(302, 10);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "Lista linijskih objekata:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(205, 625);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(79, 45);
            this.btnOK.TabIndex = 43;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnDodajNovuZnamenitost
            // 
            this.btnDodajNovuZnamenitost.Location = new System.Drawing.Point(305, 460);
            this.btnDodajNovuZnamenitost.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajNovuZnamenitost.Name = "btnDodajNovuZnamenitost";
            this.btnDodajNovuZnamenitost.Size = new System.Drawing.Size(70, 44);
            this.btnDodajNovuZnamenitost.TabIndex = 42;
            this.btnDodajNovuZnamenitost.Text = "Dodaj novu znamenitost";
            this.btnDodajNovuZnamenitost.UseVisualStyleBackColor = true;
            this.btnDodajNovuZnamenitost.Click += new System.EventHandler(this.btnDodajNovuZnamenitost_Click);
            // 
            // listViewZnamenitosti
            // 
            this.listViewZnamenitosti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4});
            this.listViewZnamenitosti.FullRowSelect = true;
            this.listViewZnamenitosti.Location = new System.Drawing.Point(13, 396);
            this.listViewZnamenitosti.Margin = new System.Windows.Forms.Padding(2);
            this.listViewZnamenitosti.Name = "listViewZnamenitosti";
            this.listViewZnamenitosti.Size = new System.Drawing.Size(231, 108);
            this.listViewZnamenitosti.TabIndex = 41;
            this.listViewZnamenitosti.UseCompatibleStateImageBehavior = false;
            this.listViewZnamenitosti.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "NAZIV";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 369);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(181, 13);
            this.label15.TabIndex = 40;
            this.label15.Text = "Lista znamenitosti tackastog objekta:";
            // 
            // txtNovaZnamenitost
            // 
            this.txtNovaZnamenitost.Location = new System.Drawing.Point(305, 424);
            this.txtNovaZnamenitost.Name = "txtNovaZnamenitost";
            this.txtNovaZnamenitost.Size = new System.Drawing.Size(122, 20);
            this.txtNovaZnamenitost.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Naziv nove znamenitosti:";
            // 
            // MFormDodajAzurirajTackastiObjekat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 681);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNovaZnamenitost);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnDodajNovuZnamenitost);
            this.Controls.Add(this.listViewZnamenitosti);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.listViewLinijski);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateStatus);
            this.Controls.Add(this.dateOsnivanje);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxTipTurizma);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxTipNaselja);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtOpstina);
            this.Controls.Add(this.txtBrojStanovnika);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmxTip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MFormDodajAzurirajTackastiObjekat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj ili azuriraj tackasti objekat";
            this.Load += new System.EventHandler(this.MFormDodajAzurirajTackastiObjekat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmxTip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOpstina;
        private System.Windows.Forms.TextBox txtBrojStanovnika;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxTipNaselja;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxTipTurizma;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateOsnivanje;
        private System.Windows.Forms.DateTimePicker dateStatus;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.ListView listViewLinijski;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnDodajNovuZnamenitost;
        private System.Windows.Forms.ListView listViewZnamenitosti;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtNovaZnamenitost;
        private System.Windows.Forms.Label label2;
    }
}