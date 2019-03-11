using GeografskaKartaNovo.Entiteti;
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
    public partial class MFormDodajAzurirajPovrsinskiObjekti : Form
    {

        #region atributi

        public PovrsinskiObjekatBasic Povrsinski { get; set; }

        /*
        za Tip:
        0 - forma pozvana preko "dodaj novi tacksati"
        1 - forma pozvana preko "azuriraj"
        2 - forma pozvana preko "prikazi"
        */
        public int Tip { get; set; }

        #endregion

        #region konstuktor

        public MFormDodajAzurirajPovrsinskiObjekti()
        {
            InitializeComponent();
            Povrsinski = new PovrsinskiObjekatBasic();
        }

        #endregion

        #region metode


        private void RetrieveInfo(PovrsinskiObjekatBasic povrsinski)
        {

            txtNaziv.Text = povrsinski.Naziv;

            foreach (LinijskiObjekat se in Povrsinski.Lista_Linijskih_objekata)
            {
                try
                {
                    LinijskiObjekat lin = DTOManager.GetLinijskiObjekat(se.Id);

                    ListViewItem item = new ListViewItem(new string[] { lin.Id.ToString(), lin.Naziv, lin.Duzina, lin.Tip_Objekta, lin.Opis_Objekta });
                    listViewLinijskihObjekata.Items.Add(item);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

            }
            listViewLinijskihObjekata.Refresh();

            
        }

        private void PrikaziSveLinijske()
        {
            foreach (var lin in DTOManager.GetSveLinijskeObjekteBasic())
            {
                try
                {
                    ListViewItem item = new ListViewItem(new string[] { lin.Id.ToString(), lin.Naziv, lin.Duzina, lin.Tip_Objekta, lin.Opis_Objekta });
                    listViewSviLinijskiObjekti.Items.Add(item);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

            }
            listViewSviLinijskiObjekti.Refresh();
        }

        #endregion

        #region event handlers

        private void MFormDodajAzurirajPovrsinskiObjekti_Load(object sender, EventArgs e)
        {
            if (Tip == 0)//dodaj
                this.PrikaziSveLinijske();
            else if (Tip == 1)//azuriraj
            {
                this.RetrieveInfo(Povrsinski);
                this.PrikaziSveLinijske();
            }
            else if (Tip == 2)//prikazi
            {
                RetrieveInfo(Povrsinski);

                txtNaziv.Enabled = false;
                btnDodajNoviLinijski.Enabled = false;
                btnDodajPostojeci.Enabled = false;
            }
        }

        private void btnDodajNoviLinijski_Click(object sender, EventArgs e)
        {
            MFormDodajAzurirajLinijskiObjekat f = new MFormDodajAzurirajLinijskiObjekat();

            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                DTOManager.dodajLinijskiObjekat(f.lin);
                PrikaziSveLinijske();

                LinijskiObjekatBasic l = DTOManager.vratilinijskiObjekat(f.lin.Naziv);

                LinijskiObjekat prvi = new LinijskiObjekat();
                prvi.Id = l.Id;
                prvi.Duzina = l.Duzina;
                prvi.Naziv = l.Naziv;
                prvi.Opis_Objekta = l.Opis_Objekta;
                prvi.Tip_Objekta = l.Tip_Objekta;
                prvi.ListaKoordinata = l.ListaKoordinata;
                prvi.Lista_SadrziLin = l.Lista_SadrziLin;
                prvi.Lista_SadrziTac = l.Lista_SadrziTac;

                PovrsinskiObjekat po = new PovrsinskiObjekat();
                po.Id = Povrsinski.Id;

                Povrsinski.Lista_Linijskih_objekata.Add(prvi);
                Povrsinski.Lista_SadrziLin.Add(new SadrziLin(po, prvi));

                ListViewItem item = new ListViewItem(new string[] { prvi.Id.ToString(), prvi.Naziv, prvi.Duzina, prvi.Tip_Objekta, prvi.Opis_Objekta });

                listViewLinijskihObjekata.Items.Add(item);
                listViewLinijskihObjekata.Refresh();

            }
        }
        private void btnDodajPostojeci_Click(object sender, EventArgs e)
        {
            if (listViewSviLinijskiObjekti.SelectedItems.Count == 0)
            {
                return;
            }
            int id = Int32.Parse(listViewSviLinijskiObjekti.SelectedItems[0].SubItems[0].Text);
            LinijskiObjekat lo = DTOManager.GetLinijskiObjekat(id);

            PovrsinskiObjekat po = new PovrsinskiObjekat();
            po.Id = Povrsinski.Id;

            Povrsinski.Lista_Linijskih_objekata.Add(lo);
            Povrsinski.Lista_SadrziLin.Add(new SadrziLin(po, lo));

            ListViewItem item = new ListViewItem(new string[] { lo.Id.ToString(), lo.Naziv, lo.Duzina, lo.Tip_Objekta, lo.Opis_Objekta });

            listViewLinijskihObjekata.Items.Add(item);
            listViewLinijskihObjekata.Refresh();

        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Tip == 0)//dodaj
            {
                DTOManager.AddPovrsinskiObjekatBasic(new PovrsinskiObjekatBasic(
                    0, txtNaziv.Text, Povrsinski.Lista_SadrziLin, Povrsinski.Lista_Linijskih_objekata));

            }
            else if (Tip == 1)//azuriraj
            {
                DTOManager.UpdatePovrsinskiObjekatBasic(new PovrsinskiObjekatBasic(
                    Povrsinski.Id, txtNaziv.Text, Povrsinski.Lista_SadrziLin, Povrsinski.Lista_Linijskih_objekata));

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
