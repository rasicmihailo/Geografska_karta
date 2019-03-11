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
    public partial class MFormDodajAzurirajLinijskiObjekat : Form
    {

        public LinijskiObjekatBasic lin;
        public Button btnDodajTac { get; set; }
        public Button btnDodajKoor { get; set; }
        public Button btnDodajPostojeci { get; set; }


        public MFormDodajAzurirajLinijskiObjekat()
        {
            lin = new LinijskiObjekatBasic();
            InitializeComponent();
            this.popuniPovrsinski_Tackast();
            this.btnDodajKoor = btnDodajKoordinate;
            this.btnDodajPostojeci = btnDodajPostojeciTackasti;
            this.btnDodajTac = btnDodajNoviTackasti;

        }
        public MFormDodajAzurirajLinijskiObjekat(LinijskiObjekatBasic l)
        {
            this.lin = l;
            InitializeComponent();
            ucitajPodatke();
            this.popuniSveTackaste();
            this.popuniKoordinate();
            this.popuniTackasteKojeSadrzi();

            this.btnDodajKoor = btnDodajKoordinate;
            this.btnDodajPostojeci = btnDodajPostojeciTackasti;
            this.btnDodajTac = btnDodajNoviTackasti;
        }


        private void popuniPovrsinski_Tackast()
        {
            List<PovrsinskiObjekatBasic> list = DTOManager.vratiPovrsinske();

            List<TackastiObjekatBasic> tac = DTOManager.vratiTackaste();
            try
            {
                listViewPovrsinki.Items.Clear();
                foreach (PovrsinskiObjekatBasic k in list)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        k.Id.ToString(),
                        k.Naziv,
                    });
                    listViewPovrsinki.Items.Add(item);
                }
                listViewPovrsinki.Refresh();


                listViewSvihTackastihObjekata.Items.Clear();
                foreach (TackastiObjekatBasic k in tac)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        k.Id.ToString(),
                        k.Naziv,
                        k.Opstina,
                    });
                    listViewSvihTackastihObjekata.Items.Add(item);
                }
                listViewSvihTackastihObjekata.Refresh();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        public void ucitajPodatke()
        {
            txtNaziv.Text = lin.Naziv;
            txtDuzina.Text = lin.Duzina;
            txtOpis.Text = lin.Opis_Objekta;

            if (lin.Tip_Objekta == "reka")
                cmxTip.Text = cmxTip.Items[0].ToString();
            else if (lin.Tip_Objekta == "granica")
                cmxTip.Text = cmxTip.Items[1].ToString();
            else
                cmxTip.Text = cmxTip.Items[2].ToString();
        }
        private void popuniSveTackaste()
        {
            try
            {
                listViewSvihTackastihObjekata.Items.Clear();
                foreach (TackastiObjekat tac in lin.Lista_Svih_Tackastih_objekata)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                    tac.Id.ToString(),
                    tac.Naziv,
                    tac.Opstina,
                    });
                    listViewSvihTackastihObjekata.Items.Add(item);
                }
                listViewSvihTackastihObjekata.Refresh();


                listViewPovrsinki.Items.Clear();

                foreach (PovrsinskiObjekat pov in lin.Lista_Povrsinskih_objekata)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                    pov.Id.ToString(),
                    pov.Naziv,
                    });
                    listViewPovrsinki.Items.Add(item);
                }
                listViewPovrsinki.Refresh();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        private void popuniKoordinate()
        {
            try
            {
                listViewKoordinate.Items.Clear();
                foreach (Koordinate k in lin.ListaKoordinata)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                    k.X_lin.ToString(),
                    k.Y_lin.ToString(),
                    });
                    listViewKoordinate.Items.Add(item);
                }
                listViewKoordinate.Refresh();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        private void popuniTackasteKojeSadrzi()
        {
            try
            {
                listViewTackasti.Items.Clear();
                foreach (TackastiObjekat t in lin.Lista_Tackastih_objekata)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                    t.Id.ToString(),
                    t.Naziv,
                    t.Opstina,
                    });

                    listViewTackasti.Items.Add(item);
                }
                listViewTackasti.Refresh();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
            this.btnDodajKoordinate.Enabled = true;
            this.btnDodajPostojeciTackasti.Enabled = true;
            this.btnDodajNoviTackasti.Enabled = true;
            DialogResult = DialogResult.OK;
        }
        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.Close();

            this.btnDodajKoordinate.Enabled = true;
            this.btnDodajPostojeciTackasti.Enabled = true;
            this.btnDodajNoviTackasti.Enabled = true;
        }
        private void btnDodajPostojeciTackasti_Click(object sender, EventArgs e)
        {
            if (listViewSvihTackastihObjekata.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate odabrati objekat.", "Obavestenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int odId = Int32.Parse(listViewSvihTackastihObjekata.SelectedItems[0].SubItems[0].Text);
            TackastiObjekatBasic t = DTOManager.vratiSamoTackastiObjekat(odId);

            TackastiObjekat tn = new TackastiObjekat();
            tn.Id = t.Id;
            tn.Naziv = t.Naziv;
            tn.Opstina = t.Opstina;
            tn.Tip_naselja = t.Tip_naselja;
            tn.Tip_turizma = t.Tip_turizma;
            tn.X_tac = t.X_tac;
            tn.Y_tac = t.Y_tac;
            tn.F_naseljeno = t.F_naseljeno;
            tn.F_turisticko = t.F_turisticko;
            tn.Datum_status = t.Datum_status;
            tn.Datum_Osnivanja = t.Datum_Osnivanja;
            tn.Broj_Stanovnika = t.Broj_Stanovnika;

            lin.Lista_Tackastih_objekata.Add(tn);

            ListViewItem item = new ListViewItem(new string[]
               {
                    t.Id.ToString(),
                    t.Naziv,
                    t.Opstina,
               });

            listViewTackasti.Items.Add(item);
            listViewTackasti.Refresh();
        }
        private void btnDodajNoviTackasti_Click(object sender, EventArgs e)
        {
            MFormDodajAzurirajTackastiObjekat f = new MFormDodajAzurirajTackastiObjekat();

            if (f.ShowDialog() == DialogResult.OK)
            {
                popuniPovrsinski_Tackast();

                TackastiObjekatBasic t = DTOManager.GetTackastiObjekatBasic(f.Tackasti.Naziv);

                TackastiObjekat tn = new TackastiObjekat();
                tn.Id = t.Id;
                tn.Naziv = t.Naziv;
                tn.Opstina = t.Opstina;
                tn.Tip_naselja = t.Tip_naselja;
                tn.Tip_turizma = t.Tip_turizma;
                tn.X_tac = t.X_tac;
                tn.Y_tac = t.Y_tac;
                tn.F_naseljeno = t.F_naseljeno;
                tn.F_turisticko = t.F_turisticko;
                tn.Datum_status = t.Datum_status;
                tn.Datum_Osnivanja = t.Datum_Osnivanja;
                tn.Broj_Stanovnika = t.Broj_Stanovnika;
                tn.Lista_Znamenitosti = t.Lista_Znamenitosti;

                lin.Lista_Tackastih_objekata.Add(tn);

                ListViewItem item = new ListViewItem(new string[]
               {
                    tn.Id.ToString(),
                    tn.Naziv,
                    tn.Opstina,
               });

                listViewTackasti.Items.Add(item);
                listViewTackasti.Refresh();
            }

        }
        private void btnDodajKoordinate_Click(object sender, EventArgs e)
        {
            KoordinateBasic k = new KoordinateBasic();
            k.X_lin = Double.Parse(txtX.Text);
            k.Y_lin = Double.Parse(txtY.Text);

            DTOManager.dodajKoordinatu(k);

            KoordinateBasic kb = DTOManager.vratiKoordinate(k.X_lin, k.Y_lin);

            Koordinate ne = new Koordinate();
            ne.Id = kb.Id;
            ne.X_lin = kb.X_lin;
            ne.Y_lin = kb.Y_lin;

            lin.ListaKoordinata.Add(ne);

            ListViewItem item = new ListViewItem(new string[]
                  {
                    k.X_lin.ToString(),
                    k.Y_lin.ToString(),
                  });

            listViewKoordinate.Items.Add(item);
            listViewKoordinate.Refresh();
        }
        private void MFormDodajAzurirajLinijskiObjekat_Load(object sender, EventArgs e)
        {

        }
        private void txtNaziv_TextChanged(object sender, EventArgs e)
        {
            lin.Naziv = txtNaziv.Text;
        }
        private void txtDuzina_TextChanged(object sender, EventArgs e)
        {
            lin.Duzina = txtDuzina.Text;
        }
        private void txtOpis_TextChanged(object sender, EventArgs e)
        {
            lin.Opis_Objekta = txtOpis.Text;
        }
        private void cmxTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmxTip.SelectedIndex == 0)
                lin.Tip_Objekta = "reka";
            else if (cmxTip.SelectedIndex == 1)
                lin.Tip_Objekta = "granica";
            else if (cmxTip.SelectedIndex == 2)
                lin.Tip_Objekta = "put";
        }
    }
}
