using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeografskaKartaNovo.Entiteti;

namespace GeografskaKartaNovo
{
    public partial class MFormDodajAzurirajGeografskiObjekat : Form
    {
        public GeografskiObjekatBasic geog;

        public MFormDodajAzurirajGeografskiObjekat()
        {
            InitializeComponent();
            geog = new GeografskiObjekatBasic();
            this.popuniListu();
            this.listViewUzvisenjaObjekta.Enabled = false;
        }

        public MFormDodajAzurirajGeografskiObjekat(GeografskiObjekatBasic g)
        {
            this.geog = g;
            InitializeComponent();

            txtNaziv.Text = geog.Naziv;
            this.popuniListu();
        }

        private void btnDodajPostojece_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.OK;
            this.listViewUzvisenjaObjekta.Enabled = true;

        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.Close();
            this.listViewUzvisenjaObjekta.Enabled = true;
        }

        public void popuniListu()
        {
            try
            {
                listViewUzvisenjaObjekta.Items.Clear();

                foreach (Uzvisenje u in geog.Lista_Basic_Uzvisenja)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                    u.Id.ToString(),
                    u.Naziv,
                    u.Nadmorska_visina.ToString()
                    });

                    listViewUzvisenjaObjekta.Items.Add(item);
                }
                listViewUzvisenjaObjekta.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtNaziv_TextChanged(object sender, EventArgs e)
        {
            geog.Naziv = txtNaziv.Text;
        }
    }
}
