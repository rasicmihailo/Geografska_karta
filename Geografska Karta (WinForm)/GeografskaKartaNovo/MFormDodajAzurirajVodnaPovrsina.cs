using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeografskaKartaNovo
{
    public partial class MFormDodajAzurirajVodnaPovrsina : Form
    {

        #region atributi

        public VodnaPovrsinaBasic Vodna { get; set; }

        /*
        za Tip:
        0 - forma pozvana preko "dodaj novi tacksati"
        1 - forma pozvana preko "azuriraj"
        2 - forma pozvana preko "prikazi"
        */
        public int Tip { get; set; }

        #endregion
        
        #region konstruktor

        public MFormDodajAzurirajVodnaPovrsina()
        {
            InitializeComponent();
            Vodna = new VodnaPovrsinaBasic();
        }

        #endregion

        #region metode

        private void RetrieveInfo(VodnaPovrsinaBasic vodna)
        {

            txtNaziv.Text = vodna.Naziv;

            if (vodna.Tip_Vode.Equals("bara"))
            {
                cbxTipVode.SelectedIndex = 0;
            }
            else if (vodna.Tip_Vode.Equals("jezero"))
            {
                cbxTipVode.SelectedIndex = 1;
            }
            else if (vodna.Tip_Vode.Equals("more"))
            {
                cbxTipVode.SelectedIndex = 2;
            }
            else if (vodna.Tip_Vode.Equals("okean"))
            {
                cbxTipVode.SelectedIndex = 3;
            }
            
        }

        #endregion

        #region event handlers

        private void MFormDodajAzurirajVodnaPovrsina_Load(object sender, EventArgs e)
        {
            if (Tip == 0)//dodaj
            {

            }
            else if (Tip == 1)//azuriraj
            {
                RetrieveInfo(Vodna);
            }
            else if (Tip == 2)//prikazi
            {
                RetrieveInfo(Vodna);

                txtNaziv.Enabled = false;
                cbxTipVode.Enabled = false;
            }
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Tip == 0)//dodaj
            {
                DTOManager.AddVodnaPovrsinaBasic(new VodnaPovrsinaBasic(
                        0, txtNaziv.Text, cbxTipVode.Text));
                
            }
            else if (Tip == 1)//azuriraj
            {
               
                DTOManager.UpdateVodnaPovrsinaBasic(new VodnaPovrsinaBasic(
                        Vodna.Id, txtNaziv.Text, cbxTipVode.Text));
                
            }
            else if (Tip == 2)//prikazi
            {
            }

            this.Close();
            DialogResult = DialogResult.OK;
        }

        #endregion

    }
}
