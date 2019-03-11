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
    public partial class MFormDodajAzurirajUzvisenje : Form
    {
        public UzvisenjeBasic uzvisenje;
        public Button btnDodajGeog;
        public Button btnDodajPostojeciGeog;
        public Button btnDodajVrh;
        public Button btnDodajPostojeciV;

        public MFormDodajAzurirajUzvisenje()
        {
            InitializeComponent();
            uzvisenje = new UzvisenjeBasic();
            this.popuniSveGeogVrh();
        }
        public MFormDodajAzurirajUzvisenje(UzvisenjeBasic uz)
        {
            InitializeComponent();
            this.uzvisenje = uz;
            txtNaziv.Text = uzvisenje.naziv;
            txtVisina.Text = uzvisenje.Nadmorska_visina.ToString();
            this.btnDodajGeog = btnDodajNoviGeog;
            this.btnDodajVrh = btnDodajNoviVrh;
            this.btnDodajPostojeciGeog = btnDodajPostojeciGeografski;
            this.btnDodajPostojeciV = btnDodajPostojeciVrh;
            this.napuniListe();
        }



        public bool validacija()
        {
            if (String.IsNullOrEmpty(txtNaziv.Text) && String.IsNullOrEmpty(txtVisina.Text))
            {
                MessageBox.Show("Morate uneti sva polja!", "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNaziv.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtNaziv.Text))
            {
                MessageBox.Show("Morate uneti naziv uzvisenja!", "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNaziv.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtVisina.Text))
            {
                MessageBox.Show("Morate uneti nadmorsku visinu!", "Upozorenje",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVisina.Focus();
                return false;
            }
            return true;
        }
        private void napuniListe()
        {
            listViewGeografski.Items.Clear();
            foreach (GeografskiObjekat g in uzvisenje.Lista_Geografskih_objekata)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    g.Id.ToString(),
                    g.Naziv,
                });
                listViewGeografski.Items.Add(item);
            }
            listViewGeografski.Refresh();

            listViewSvihGeografskihObjekata.Items.Clear();
            foreach (GeografskiObjekat g in uzvisenje.listaSvihGeografskih)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    g.Id.ToString(),
                    g.Naziv,
                });
                listViewSvihGeografskihObjekata.Items.Add(item);
            }
            listViewSvihGeografskihObjekata.Refresh();

            listViewListaVrhova.Items.Clear();
            foreach (ListaVrhova l in uzvisenje.Lista_Vrhova)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    l.Id.ToString(),
                    l.Ime,
                    l.Nadmorska_visina.ToString(),
                });
                listViewListaVrhova.Items.Add(item);
            }
            listViewListaVrhova.Refresh();

            listViewListaSvihVrhova.Items.Clear();
            foreach (ListaVrhova l in uzvisenje.listaSvihVrhova)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    l.Id.ToString(),
                    l.Ime,
                    l.Nadmorska_visina.ToString(),
                });
                listViewListaSvihVrhova.Items.Add(item);
            }
            listViewListaSvihVrhova.Refresh();
        }
        private void popuniSveGeogVrh()
        {
            listViewSvihGeografskihObjekata.Items.Clear();
            List<GeografskiObjekatBasic> lista = DTOManager.VratiGeografskeObjekte();
            foreach (GeografskiObjekatBasic g in lista)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    g.Id.ToString(),
                    g.Naziv,
                });

                listViewSvihGeografskihObjekata.Items.Add(item);
            }
            listViewSvihGeografskihObjekata.Refresh();

            listViewListaSvihVrhova.Items.Clear();
            List<ListaVrhovaBasic> vrhovi = DTOManager.vratiSveVrhove();
            foreach (ListaVrhovaBasic g in vrhovi)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    g.Id.ToString(),
                    g.Ime,
                    g.Nadmorska_visina.ToString(),
                });

                listViewListaSvihVrhova.Items.Add(item);
            }
            listViewListaSvihVrhova.Refresh();
        }
        private void btnDodajPostojeciGeografski_Click(object sender, EventArgs e)
        {
            if (listViewSvihGeografskihObjekata.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate odabrati objekat.", "Obavestenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int odId = Int32.Parse(listViewSvihGeografskihObjekata.SelectedItems[0].SubItems[0].Text);
            GeografskiObjekatBasic g = DTOManager.vratiGeografskiObjekat(odId);

            GeografskiObjekat novi = new GeografskiObjekat();
            novi.Id = g.Id;
            novi.Naziv = g.Naziv;

            uzvisenje.Lista_Geografskih_objekata.Add(novi);

            //cisto prikaz dok se ne sacuva uzvisenje celo
            ListViewItem item = new ListViewItem(new string[]
              {
                    g.Id.ToString(),
                    g.Naziv,
              });
            listViewGeografski.Items.Add(item);
            listViewGeografski.Refresh();
        }
        private void btnDodajNoviGeog_Click(object sender, EventArgs e)
        {
            MFormDodajAzurirajGeografskiObjekat f = new MFormDodajAzurirajGeografskiObjekat();
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DTOManager.dodajGeog(f.geog);
                popuniSveGeogVrh();

                GeografskiObjekatBasic g = DTOManager.vratiGeografskiObjekat(f.geog.Naziv);

                GeografskiObjekat novi = new GeografskiObjekat();
                novi.Id = g.Id;
                novi.Naziv = g.Naziv;

                uzvisenje.Lista_Geografskih_objekata.Add(novi);

                ListViewItem item = new ListViewItem(new string[]
                {
                    f.geog.Id.ToString(),
                    f.geog.Naziv,
                });

                listViewGeografski.Items.Add(item);
                listViewGeografski.Refresh();
            }
        }
        private void btnDodajPostojeciVrh_Click(object sender, EventArgs e)
        {
            if (listViewListaSvihVrhova.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate odabrati objekat.", "Obavestenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int odId = Int32.Parse(listViewListaSvihVrhova.SelectedItems[0].SubItems[0].Text);
            ListaVrhovaBasic basic = DTOManager.vratiVrh(odId);

            ListaVrhova l = new ListaVrhova();
            l.Id = basic.Id;
            l.Ime = basic.Ime;
            l.Nadmorska_visina = basic.Nadmorska_visina;

            uzvisenje.Lista_Vrhova.Add(l);

            ListViewItem item = new ListViewItem(new string[]
               {
                    l.Id.ToString(),
                    l.Ime,
                    l.Nadmorska_visina.ToString(),
               });
            listViewListaVrhova.Items.Add(item);
            listViewListaVrhova.Refresh();
        }
        private void btnDodajNoviVrh_Click(object sender, EventArgs e)
        {
            DTOManager.upisiVrh(txtNazivVrha.Text, Double.Parse(txtVisinaNovogVrha.Text), uzvisenje);

            ListaVrhovaBasic basic = DTOManager.vratiVrh(txtNazivVrha.Text);
            popuniSveGeogVrh();

            ListaVrhova l = new ListaVrhova();
            l.Id = basic.Id;
            l.Ime = basic.Ime;
            l.Nadmorska_visina = basic.Nadmorska_visina;

            uzvisenje.Lista_Vrhova.Add(l);

            ListViewItem item = new ListViewItem(new string[]
               {
                    l.Id.ToString(),
                    l.Ime,
                    l.Nadmorska_visina.ToString(),
               });
            listViewListaVrhova.Items.Add(item);
            listViewListaVrhova.Refresh();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (validacija())
            {
                this.Close();
                DialogResult = DialogResult.OK;
            }
        }
        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.No;
        }
        private void MFormDodajAzurirajUzvisenje_Load(object sender, EventArgs e)
        {

        }
        private void txtNaziv_TextChanged(object sender, EventArgs e)
        {
            uzvisenje.naziv = txtNaziv.Text;
        }
        private void txtVisina_TextChanged(object sender, EventArgs e)
        {
            uzvisenje.Nadmorska_visina = Double.Parse(txtVisina.Text);
        }
    }
}
