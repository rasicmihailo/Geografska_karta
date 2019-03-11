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
    public partial class FormGeografskiObjekti : Form
    {
        public FormGeografskiObjekti()
        {
            InitializeComponent();
        }

        private void btnDodajNovi_Click(object sender, EventArgs e)
        {
            MFormDodajAzurirajGeografskiObjekat f = new MFormDodajAzurirajGeografskiObjekat();
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DTOManager.dodajGeog(f.geog);
                PopuniListView();
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
            GeografskiObjekatBasic g = DTOManager.vratiGeografskiObjekat(odId);


            MFormDodajAzurirajGeografskiObjekat f = new MFormDodajAzurirajGeografskiObjekat(g);
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DTOManager.azurirajGeogObj(f.geog);
                PopuniListView();
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
            GeografskiObjekatBasic g = DTOManager.vratiGeografskiObjekat(odId);


            MFormDodajAzurirajGeografskiObjekat f = new MFormDodajAzurirajGeografskiObjekat(g);
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // DTOManager.azurirajGeogObj(f.geog);
                // PopuniListView();
            }

        }
        public void PopuniListView()
        {
            listViewGeografski.Items.Clear();
            List<GeografskiObjekatBasic> lista = DTOManager.VratiGeografskeObjekte();
            foreach (GeografskiObjekatBasic g in lista)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    g.Id.ToString(),
                    g.Naziv,
                });

                listViewGeografski.Items.Add(item);
            }
            listViewGeografski.Refresh();

        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (listViewGeografski.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate odabrati objekat.", "Obavestenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int odId = Int32.Parse(listViewGeografski.SelectedItems[0].SubItems[0].Text);
            GeografskiObjekatBasic g = DTOManager.vratiGeografskiObjekat(odId);

            if (DialogResult.Yes == MessageBox.Show("Da li ste sigurni da zelite da obrisete?", "Pitanje",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                DTOManager.obrisiGeografskiObjekat(g);
                PopuniListView();

                MessageBox.Show("Operacija brisanja uspesno izvrsena!", "Obavestenje",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormGeografskiObjekti_Load(object sender, EventArgs e)
        {
            this.PopuniListView();
        }
    }
}
