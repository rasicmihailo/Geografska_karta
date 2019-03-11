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
    public partial class FormUzvisenje : Form
    {
        public FormUzvisenje()
        {
            InitializeComponent();
        }


        private void btnDodajNovi_Click(object sender, EventArgs e)
        {
            MFormDodajAzurirajUzvisenje f = new MFormDodajAzurirajUzvisenje();
            if (f.ShowDialog() == DialogResult.OK)
            {
                DTOManager.dodajNovoUzvisenje(f.uzvisenje);
                this.popuniListu();
            }
        }
        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            if (listViewUzvisenja.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate odabrati objekat.", "Obavestenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int odId = Int32.Parse(listViewUzvisenja.SelectedItems[0].SubItems[0].Text);
            UzvisenjeBasic u = DTOManager.vratiUzvisenje(odId);

            MFormDodajAzurirajUzvisenje f = new MFormDodajAzurirajUzvisenje(u);
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DTOManager.azurirajUzvisenje(f.uzvisenje);
                popuniListu();
            }
        }
        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            if (listViewUzvisenja.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate odabrati objekat.", "Obavestenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int odId = Int32.Parse(listViewUzvisenja.SelectedItems[0].SubItems[0].Text);
            UzvisenjeBasic u = DTOManager.vratiUzvisenje(odId);

            MFormDodajAzurirajUzvisenje f = new MFormDodajAzurirajUzvisenje(u);
            f.btnDodajGeog.Enabled = false;
            f.btnDodajPostojeciGeog.Enabled = false;
            f.btnDodajPostojeciV.Enabled = false;
            f.btnDodajVrh.Enabled = false;
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                f.btnDodajGeog.Enabled = true;
                f.btnDodajPostojeciGeog.Enabled = true;
                f.btnDodajPostojeciV.Enabled = true;
                f.btnDodajVrh.Enabled = true;
            }
        }
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (listViewUzvisenja.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate odabrati objekat.", "Obavestenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int odId = Int32.Parse(listViewUzvisenja.SelectedItems[0].SubItems[0].Text);
            UzvisenjeBasic g = DTOManager.vratiUzvisenje(odId);

            if (DialogResult.Yes == MessageBox.Show("Da li ste sigurni da zelite da obrisete?", "Pitanje",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                DTOManager.obrisiUzvisenje(g);
                popuniListu();

                MessageBox.Show("Operacija brisanja uspesno izvrsena!", "Obavestenje",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void popuniListu()
        {
            listViewUzvisenja.Items.Clear();

            List<UzvisenjeBasic> lista = DTOManager.vratiSvaUzvisenja();

            foreach (UzvisenjeBasic u in lista)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    u.id.ToString(),
                    u.naziv,
                    u.Nadmorska_visina.ToString(),
                });
                listViewUzvisenja.Items.Add(item);
            }
            listViewUzvisenja.Refresh();
        }
        private void FormUzvisenje_Load(object sender, EventArgs e)
        {
            this.popuniListu();
        }
    }
}
