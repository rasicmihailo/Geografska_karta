namespace GeografskaKartaNovo
{
    partial class MFormDodajAzurirajVodnaPovrsina
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.cbxTipVode = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Tip vode:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(112, 20);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(2);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(139, 20);
            this.txtNaziv.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Naziv:";
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(171, 129);
            this.btnOtkazi.Margin = new System.Windows.Forms.Padding(2);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(79, 38);
            this.btnOtkazi.TabIndex = 48;
            this.btnOtkazi.Text = "Otkazi";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(18, 129);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(81, 38);
            this.btnOK.TabIndex = 47;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cbxTipVode
            // 
            this.cbxTipVode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipVode.FormattingEnabled = true;
            this.cbxTipVode.Items.AddRange(new object[] {
            "bara",
            "jezero",
            "more",
            "okean"});
            this.cbxTipVode.Location = new System.Drawing.Point(112, 58);
            this.cbxTipVode.Margin = new System.Windows.Forms.Padding(2);
            this.cbxTipVode.Name = "cbxTipVode";
            this.cbxTipVode.Size = new System.Drawing.Size(138, 21);
            this.cbxTipVode.TabIndex = 55;
            // 
            // MFormDodajAzurirajVodnaPovrsina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 195);
            this.Controls.Add(this.cbxTipVode);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MFormDodajAzurirajVodnaPovrsina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj ili azuriraj vodnu povrsinu";
            this.Load += new System.EventHandler(this.MFormDodajAzurirajVodnaPovrsina_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cbxTipVode;
    }
}