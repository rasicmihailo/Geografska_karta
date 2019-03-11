namespace GeografskaKartaNovo
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
            this.btnDodajGeog = new System.Windows.Forms.Button();
            this.btnDodajTackasti = new System.Windows.Forms.Button();
            this.btnDodajLinijski = new System.Windows.Forms.Button();
            this.btnDodajPovrsinski = new System.Windows.Forms.Button();
            this.btnDodajUzvisenje = new System.Windows.Forms.Button();
            this.btnVodnaPovrsina = new System.Windows.Forms.Button();
            this.btnDodajZnamenitosti = new System.Windows.Forms.Button();
            this.btnDodajVrhove = new System.Windows.Forms.Button();
            this.btnDodajKoordinate = new System.Windows.Forms.Button();
            this.Lin_Tac_SADRZITAC = new System.Windows.Forms.Button();
            this.Povrs_Lin_SADRZILIN = new System.Windows.Forms.Button();
            this.Uzvisenje_Geog_SADRZIGEOG = new System.Windows.Forms.Button();
            this.btnPrikazGeog = new System.Windows.Forms.Button();
            this.btnTac_Znamen = new System.Windows.Forms.Button();
            this.btnLinTacKoord = new System.Windows.Forms.Button();
            this.btnUzvGeogVrh = new System.Windows.Forms.Button();
            this.btnUzvLin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDodajGeog
            // 
            this.btnDodajGeog.Location = new System.Drawing.Point(12, 12);
            this.btnDodajGeog.Name = "btnDodajGeog";
            this.btnDodajGeog.Size = new System.Drawing.Size(288, 53);
            this.btnDodajGeog.TabIndex = 0;
            this.btnDodajGeog.Text = "Dodaj novi geografski objekat";
            this.btnDodajGeog.UseVisualStyleBackColor = true;
            this.btnDodajGeog.Click += new System.EventHandler(this.btnDodajGeog_Click);
            // 
            // btnDodajTackasti
            // 
            this.btnDodajTackasti.Location = new System.Drawing.Point(12, 71);
            this.btnDodajTackasti.Name = "btnDodajTackasti";
            this.btnDodajTackasti.Size = new System.Drawing.Size(288, 49);
            this.btnDodajTackasti.TabIndex = 1;
            this.btnDodajTackasti.Text = "Dodaj novi tackasti objekat";
            this.btnDodajTackasti.UseVisualStyleBackColor = true;
            this.btnDodajTackasti.Click += new System.EventHandler(this.btnDodajTackasti_Click);
            // 
            // btnDodajLinijski
            // 
            this.btnDodajLinijski.Location = new System.Drawing.Point(12, 126);
            this.btnDodajLinijski.Name = "btnDodajLinijski";
            this.btnDodajLinijski.Size = new System.Drawing.Size(288, 42);
            this.btnDodajLinijski.TabIndex = 2;
            this.btnDodajLinijski.Text = "Dodaj novi linijski objekat";
            this.btnDodajLinijski.UseVisualStyleBackColor = true;
            this.btnDodajLinijski.Click += new System.EventHandler(this.btnDodajLinijski_Click);
            // 
            // btnDodajPovrsinski
            // 
            this.btnDodajPovrsinski.Location = new System.Drawing.Point(12, 174);
            this.btnDodajPovrsinski.Name = "btnDodajPovrsinski";
            this.btnDodajPovrsinski.Size = new System.Drawing.Size(288, 50);
            this.btnDodajPovrsinski.TabIndex = 3;
            this.btnDodajPovrsinski.Text = "Dodaj novi povrsinski";
            this.btnDodajPovrsinski.UseVisualStyleBackColor = true;
            this.btnDodajPovrsinski.Click += new System.EventHandler(this.btnDodajPovrsinski_Click);
            // 
            // btnDodajUzvisenje
            // 
            this.btnDodajUzvisenje.Location = new System.Drawing.Point(12, 230);
            this.btnDodajUzvisenje.Name = "btnDodajUzvisenje";
            this.btnDodajUzvisenje.Size = new System.Drawing.Size(288, 43);
            this.btnDodajUzvisenje.TabIndex = 4;
            this.btnDodajUzvisenje.Text = "Dodaj novo uzvisenje";
            this.btnDodajUzvisenje.UseVisualStyleBackColor = true;
            this.btnDodajUzvisenje.Click += new System.EventHandler(this.btnDodajUzvisenje_Click);
            // 
            // btnVodnaPovrsina
            // 
            this.btnVodnaPovrsina.Location = new System.Drawing.Point(12, 279);
            this.btnVodnaPovrsina.Name = "btnVodnaPovrsina";
            this.btnVodnaPovrsina.Size = new System.Drawing.Size(288, 44);
            this.btnVodnaPovrsina.TabIndex = 5;
            this.btnVodnaPovrsina.Text = "Dodaj novu vodnu povrsinu";
            this.btnVodnaPovrsina.UseVisualStyleBackColor = true;
            this.btnVodnaPovrsina.Click += new System.EventHandler(this.btnVodnaPovrsina_Click);
            // 
            // btnDodajZnamenitosti
            // 
            this.btnDodajZnamenitosti.Location = new System.Drawing.Point(12, 329);
            this.btnDodajZnamenitosti.Name = "btnDodajZnamenitosti";
            this.btnDodajZnamenitosti.Size = new System.Drawing.Size(288, 62);
            this.btnDodajZnamenitosti.TabIndex = 6;
            this.btnDodajZnamenitosti.Text = "Dodaj nove znamenitosti => 1:N veza";
            this.btnDodajZnamenitosti.UseVisualStyleBackColor = true;
            this.btnDodajZnamenitosti.Click += new System.EventHandler(this.btnDodajZnamenitosti_Click);
            // 
            // btnDodajVrhove
            // 
            this.btnDodajVrhove.Location = new System.Drawing.Point(12, 397);
            this.btnDodajVrhove.Name = "btnDodajVrhove";
            this.btnDodajVrhove.Size = new System.Drawing.Size(288, 50);
            this.btnDodajVrhove.TabIndex = 7;
            this.btnDodajVrhove.Text = "Dodaj nove vrhove => 1:N veza";
            this.btnDodajVrhove.UseVisualStyleBackColor = true;
            this.btnDodajVrhove.Click += new System.EventHandler(this.btnDodajVrhove_Click);
            // 
            // btnDodajKoordinate
            // 
            this.btnDodajKoordinate.Location = new System.Drawing.Point(12, 453);
            this.btnDodajKoordinate.Name = "btnDodajKoordinate";
            this.btnDodajKoordinate.Size = new System.Drawing.Size(288, 55);
            this.btnDodajKoordinate.TabIndex = 8;
            this.btnDodajKoordinate.Text = "Dodaj nove koordinate => 1:N veza";
            this.btnDodajKoordinate.UseVisualStyleBackColor = true;
            this.btnDodajKoordinate.Click += new System.EventHandler(this.btnDodajKoordinate_Click);
            // 
            // Lin_Tac_SADRZITAC
            // 
            this.Lin_Tac_SADRZITAC.Location = new System.Drawing.Point(12, 514);
            this.Lin_Tac_SADRZITAC.Name = "Lin_Tac_SADRZITAC";
            this.Lin_Tac_SADRZITAC.Size = new System.Drawing.Size(287, 62);
            this.Lin_Tac_SADRZITAC.TabIndex = 9;
            this.Lin_Tac_SADRZITAC.Text = "Linijski/Tackasti => N:M veza";
            this.Lin_Tac_SADRZITAC.UseVisualStyleBackColor = true;
            this.Lin_Tac_SADRZITAC.Click += new System.EventHandler(this.Lin_Tac_SADRZITAC_Click);
            // 
            // Povrs_Lin_SADRZILIN
            // 
            this.Povrs_Lin_SADRZILIN.Location = new System.Drawing.Point(350, 12);
            this.Povrs_Lin_SADRZILIN.Name = "Povrs_Lin_SADRZILIN";
            this.Povrs_Lin_SADRZILIN.Size = new System.Drawing.Size(279, 55);
            this.Povrs_Lin_SADRZILIN.TabIndex = 10;
            this.Povrs_Lin_SADRZILIN.Text = "Povrsinski/Linijski => N:M veza";
            this.Povrs_Lin_SADRZILIN.UseVisualStyleBackColor = true;
            this.Povrs_Lin_SADRZILIN.Click += new System.EventHandler(this.Povrs_Lin_SADRZILIN_Click);
            // 
            // Uzvisenje_Geog_SADRZIGEOG
            // 
            this.Uzvisenje_Geog_SADRZIGEOG.Location = new System.Drawing.Point(350, 73);
            this.Uzvisenje_Geog_SADRZIGEOG.Name = "Uzvisenje_Geog_SADRZIGEOG";
            this.Uzvisenje_Geog_SADRZIGEOG.Size = new System.Drawing.Size(279, 63);
            this.Uzvisenje_Geog_SADRZIGEOG.TabIndex = 11;
            this.Uzvisenje_Geog_SADRZIGEOG.Text = "Geografski/Uzvisenje => N:M veza";
            this.Uzvisenje_Geog_SADRZIGEOG.UseVisualStyleBackColor = true;
            this.Uzvisenje_Geog_SADRZIGEOG.Click += new System.EventHandler(this.Uzvisenje_Geog_SADRZIGEOG_Click);
            // 
            // btnPrikazGeog
            // 
            this.btnPrikazGeog.Location = new System.Drawing.Point(350, 142);
            this.btnPrikazGeog.Name = "btnPrikazGeog";
            this.btnPrikazGeog.Size = new System.Drawing.Size(279, 82);
            this.btnPrikazGeog.TabIndex = 12;
            this.btnPrikazGeog.Text = "Prikaz geografskog objekta";
            this.btnPrikazGeog.UseVisualStyleBackColor = true;
            this.btnPrikazGeog.Click += new System.EventHandler(this.btnPrikazGeog_Click);
            // 
            // btnTac_Znamen
            // 
            this.btnTac_Znamen.Location = new System.Drawing.Point(350, 230);
            this.btnTac_Znamen.Name = "btnTac_Znamen";
            this.btnTac_Znamen.Size = new System.Drawing.Size(279, 93);
            this.btnTac_Znamen.TabIndex = 13;
            this.btnTac_Znamen.Text = "Prikaz tackastih objekata sa njegovim znamenitostima";
            this.btnTac_Znamen.UseVisualStyleBackColor = true;
            this.btnTac_Znamen.Click += new System.EventHandler(this.btnTac_Znamen_Click);
            // 
            // btnLinTacKoord
            // 
            this.btnLinTacKoord.Location = new System.Drawing.Point(350, 329);
            this.btnLinTacKoord.Name = "btnLinTacKoord";
            this.btnLinTacKoord.Size = new System.Drawing.Size(279, 96);
            this.btnLinTacKoord.TabIndex = 14;
            this.btnLinTacKoord.Text = "Prikaz linijskih objekata sa koordinatama i sa tackastim objektima na njemu";
            this.btnLinTacKoord.UseVisualStyleBackColor = true;
            this.btnLinTacKoord.Click += new System.EventHandler(this.btnLinTacKoord_Click);
            // 
            // btnUzvGeogVrh
            // 
            this.btnUzvGeogVrh.Location = new System.Drawing.Point(350, 431);
            this.btnUzvGeogVrh.Name = "btnUzvGeogVrh";
            this.btnUzvGeogVrh.Size = new System.Drawing.Size(279, 79);
            this.btnUzvGeogVrh.TabIndex = 15;
            this.btnUzvGeogVrh.Text = "Prikaz uzvisenja sa vrhovima i sa geografskim objektima na njemu";
            this.btnUzvGeogVrh.UseVisualStyleBackColor = true;
            this.btnUzvGeogVrh.Click += new System.EventHandler(this.btnUzvGeogVrh_Click);
            // 
            // btnUzvLin
            // 
            this.btnUzvLin.Location = new System.Drawing.Point(350, 516);
            this.btnUzvLin.Name = "btnUzvLin";
            this.btnUzvLin.Size = new System.Drawing.Size(279, 60);
            this.btnUzvLin.TabIndex = 16;
            this.btnUzvLin.Text = "Prikaz uzvisenja sa linijskim objektima";
            this.btnUzvLin.UseVisualStyleBackColor = true;
            this.btnUzvLin.Click += new System.EventHandler(this.btnUzvLin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 588);
            this.Controls.Add(this.btnUzvLin);
            this.Controls.Add(this.btnUzvGeogVrh);
            this.Controls.Add(this.btnLinTacKoord);
            this.Controls.Add(this.btnTac_Znamen);
            this.Controls.Add(this.btnPrikazGeog);
            this.Controls.Add(this.Uzvisenje_Geog_SADRZIGEOG);
            this.Controls.Add(this.Povrs_Lin_SADRZILIN);
            this.Controls.Add(this.Lin_Tac_SADRZITAC);
            this.Controls.Add(this.btnDodajKoordinate);
            this.Controls.Add(this.btnDodajVrhove);
            this.Controls.Add(this.btnDodajZnamenitosti);
            this.Controls.Add(this.btnVodnaPovrsina);
            this.Controls.Add(this.btnDodajUzvisenje);
            this.Controls.Add(this.btnDodajPovrsinski);
            this.Controls.Add(this.btnDodajLinijski);
            this.Controls.Add(this.btnDodajTackasti);
            this.Controls.Add(this.btnDodajGeog);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDodajGeog;
        private System.Windows.Forms.Button btnDodajTackasti;
        private System.Windows.Forms.Button btnDodajLinijski;
        private System.Windows.Forms.Button btnDodajPovrsinski;
        private System.Windows.Forms.Button btnDodajUzvisenje;
        private System.Windows.Forms.Button btnVodnaPovrsina;
        private System.Windows.Forms.Button btnDodajZnamenitosti;
        private System.Windows.Forms.Button btnDodajVrhove;
        private System.Windows.Forms.Button btnDodajKoordinate;
        private System.Windows.Forms.Button Lin_Tac_SADRZITAC;
        private System.Windows.Forms.Button Povrs_Lin_SADRZILIN;
        private System.Windows.Forms.Button Uzvisenje_Geog_SADRZIGEOG;
        private System.Windows.Forms.Button btnPrikazGeog;
        private System.Windows.Forms.Button btnTac_Znamen;
        private System.Windows.Forms.Button btnLinTacKoord;
        private System.Windows.Forms.Button btnUzvGeogVrh;
        private System.Windows.Forms.Button btnUzvLin;
    }
}

