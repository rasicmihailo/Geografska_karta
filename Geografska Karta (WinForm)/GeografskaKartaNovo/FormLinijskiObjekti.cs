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
    public partial class FormLinijskiObjekti : Form
    {
        public FormLinijskiObjekti()
        {
            InitializeComponent();
        }

        private void btnDodajNovi_Click(object sender, EventArgs e)
        {
            MFormDodajAzurirajLinijskiObjekat f = new MFormDodajAzurirajLinijskiObjekat();
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DTOManager.dodajLinijskiObjekat(f.lin);
                popuniListu();
            }
        }
        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            if (listViewGeografski.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate odabrati objekat.", "Obavestenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int odId = Int32.Parse(listViewGeografski.SelectedItems[0].SubItems[0].Text);
            LinijskiObjekatBasic g = DTOManager.vratiLinijskiObjekat(odId);


            MFormDodajAzurirajLinijskiObjekat f = new MFormDodajAzurirajLinijskiObjekat(g);
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DTOManager.azurirajLinijskiObjekat(f.lin);
                popuniListu();
            }
        }
        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            if (listViewGeografski.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate odabrati objekat.", "Obavestenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int odId = Int32.Parse(listViewGeografski.SelectedItems[0].SubItems[0].Text);
            LinijskiObjekatBasic g = DTOManager.vratiLinijskiObjekat(odId);


            MFormDodajAzurirajLinijskiObjekat f = new MFormDodajAzurirajLinijskiObjekat(g);
            f.btnDodajKoor.Enabled = false;
            f.btnDodajPostojeci.Enabled = false;
            f.btnDodajTac.Enabled = false;
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                f.btnDodajKoor.Enabled = true;
                f.btnDodajPostojeci.Enabled = true;
                f.btnDodajTac.Enabled = true;
            }
        }
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            int odId = Int32.Parse(listViewGeografski.SelectedItems[0].SubItems[0].Text);
            LinijskiObjekatBasic g = DTOManager.vratiLinijskiObjekat(odId);

            if (DialogResult.Yes == MessageBox.Show("Da li ste sigurni da zelite da obrisete?", "Pitanje",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                DTOManager.obrisiLinijski(g);
                popuniListu();

                MessageBox.Show("Operacija brisanja uspesno izvrsena!", "Obavestenje",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void FormLinijskiObjekti_Load(object sender, EventArgs e)
        {
            this.popuniListu();
        }
        public void popuniListu()
        {
            listViewGeografski.Items.Clear();
            List<LinijskiObjekatBasic> lista = DTOManager.vratiSveLinijskeObjekte();
            foreach (LinijskiObjekatBasic g in lista)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    g.Id.ToString(),
                    g.Naziv,
                    g.Duzina,
                    g.Tip_Objekta,
                    g.Opis_Objekta
                });

                listViewGeografski.Items.Add(item);
            }
            listViewGeografski.Refresh();
        }
    }
}
