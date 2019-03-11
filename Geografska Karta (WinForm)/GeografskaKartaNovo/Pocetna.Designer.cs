namespace GeografskaKartaNovo
{
    partial class Pocetna
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
            this.btnGeografski = new System.Windows.Forms.Button();
            this.btnLinijski = new System.Windows.Forms.Button();
            this.btnTackasti = new System.Windows.Forms.Button();
            this.btnPovrsinski = new System.Windows.Forms.Button();
            this.btnVodnaPovrsina = new System.Windows.Forms.Button();
            this.btnUzvisenje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGeografski
            // 
            this.btnGeografski.Location = new System.Drawing.Point(12, 12);
            this.btnGeografski.Name = "btnGeografski";
            this.btnGeografski.Size = new System.Drawing.Size(197, 76);
            this.btnGeografski.TabIndex = 0;
            this.btnGeografski.Text = "Geografski Objekat";
            this.btnGeografski.UseVisualStyleBackColor = true;
            this.btnGeografski.Click += new System.EventHandler(this.btnGeografski_Click);
            // 
            // btnLinijski
            // 
            this.btnLinijski.Location = new System.Drawing.Point(12, 131);
            this.btnLinijski.Name = "btnLinijski";
            this.btnLinijski.Size = new System.Drawing.Size(197, 80);
            this.btnLinijski.TabIndex = 1;
            this.btnLinijski.Text = "Linijski Objekat";
            this.btnLinijski.UseVisualStyleBackColor = true;
            this.btnLinijski.Click += new System.EventHandler(this.btnLinijski_Click);
            // 
            // btnTackasti
            // 
            this.btnTackasti.Location = new System.Drawing.Point(274, 12);
            this.btnTackasti.Name = "btnTackasti";
            this.btnTackasti.Size = new System.Drawing.Size(202, 76);
            this.btnTackasti.TabIndex = 2;
            this.btnTackasti.Text = "Tackasti Objekat";
            this.btnTackasti.UseVisualStyleBackColor = true;
            this.btnTackasti.Click += new System.EventHandler(this.btnTackasti_Click);
            // 
            // btnPovrsinski
            // 
            this.btnPovrsinski.Location = new System.Drawing.Point(274, 131);
            this.btnPovrsinski.Name = "btnPovrsinski";
            this.btnPovrsinski.Size = new System.Drawing.Size(202, 80);
            this.btnPovrsinski.TabIndex = 3;
            this.btnPovrsinski.Text = "Povrsinski Objekat";
            this.btnPovrsinski.UseVisualStyleBackColor = true;
            this.btnPovrsinski.Click += new System.EventHandler(this.btnPovrsinski_Click);
            // 
            // btnVodnaPovrsina
            // 
            this.btnVodnaPovrsina.Location = new System.Drawing.Point(274, 248);
            this.btnVodnaPovrsina.MaximumSize = new System.Drawing.Size(202, 80);
            this.btnVodnaPovrsina.MinimumSize = new System.Drawing.Size(202, 80);
            this.btnVodnaPovrsina.Name = "btnVodnaPovrsina";
            this.btnVodnaPovrsina.Size = new System.Drawing.Size(202, 80);
            this.btnVodnaPovrsina.TabIndex = 5;
            this.btnVodnaPovrsina.Text = "Vodna povrsina";
            this.btnVodnaPovrsina.UseVisualStyleBackColor = true;
            this.btnVodnaPovrsina.Click += new System.EventHandler(this.btnVodnaPovrsina_Click);
            // 
            // btnUzvisenje
            // 
            this.btnUzvisenje.Location = new System.Drawing.Point(12, 248);
            this.btnUzvisenje.Name = "btnUzvisenje";
            this.btnUzvisenje.Size = new System.Drawing.Size(197, 80);
            this.btnUzvisenje.TabIndex = 4;
            this.btnUzvisenje.Text = "Uzvisenje";
            this.btnUzvisenje.UseVisualStyleBackColor = true;
            this.btnUzvisenje.Click += new System.EventHandler(this.btnUzvisenje_Click);
            // 
            // Pocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 340);
            this.Controls.Add(this.btnVodnaPovrsina);
            this.Controls.Add(this.btnUzvisenje);
            this.Controls.Add(this.btnPovrsinski);
            this.Controls.Add(this.btnTackasti);
            this.Controls.Add(this.btnLinijski);
            this.Controls.Add(this.btnGeografski);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(504, 387);
            this.MinimumSize = new System.Drawing.Size(504, 387);
            this.Name = "Pocetna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pocetna";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGeografski;
        private System.Windows.Forms.Button btnLinijski;
        private System.Windows.Forms.Button btnTackasti;
        private System.Windows.Forms.Button btnPovrsinski;
        private System.Windows.Forms.Button btnVodnaPovrsina;
        private System.Windows.Forms.Button btnUzvisenje;
    }
}