using GeografskaKartaNovo.Entiteti;
using NHibernate;
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
    public partial class MFormDodajAzurirajTackastiObjekat : Form
    {

        #region atributi

        public TackastiObjekatBasic Tackasti { get; set; }

        /*
        za Tip:
        0 - forma pozvana preko "dodaj novi tacksati"
        1 - forma pozvana preko "azuriraj"
        2 - forma pozvana preko "prikazi"
        */
        public int Tip { get; set; }

        #endregion

        #region konstruktor

        public MFormDodajAzurirajTackastiObjekat()
        {
            InitializeComponent();
            Tackasti = new TackastiObjekatBasic();
        }

        #endregion

        #region metode

        public void RetrieveInfo(TackastiObjekatBasic tackasti)
        {

            txtNaziv.Text = tackasti.Naziv;
            txtX.Text = tackasti.X_tac.ToString();
            txtY.Text = tackasti.Y_tac.ToString();

            if (tackasti.F_naseljeno == 1 && tackasti.F_turisticko == 1)
            {
                cmxTip.SelectedIndex = 2;

                txtBrojStanovnika.Text = tackasti.Broj_Stanovnika.ToString();
                txtOpstina.Text = tackasti.Opstina.ToString();
                dateOsnivanje.Value = tackasti.Datum_Osnivanja;

                dateStatus.Value = tackasti.Datum_status;

                if (tackasti.Tip_naselja.Equals("1000-10000"))
                {
                    comboBoxTipNaselja.SelectedIndex = 0;
                }
                else if (tackasti.Tip_naselja.Equals("10000-100000"))
                {
                    comboBoxTipNaselja.SelectedIndex = 1;
                }
                else if (tackasti.Tip_naselja.Equals("100000-500000"))
                {
                    comboBoxTipNaselja.SelectedIndex = 2;
                }
                else if (tackasti.Tip_naselja.Equals("500000-1000000"))
                {
                    comboBoxTipNaselja.SelectedIndex = 3;
                }
                else if (tackasti.Tip_naselja.Equals("1000000-10000000"))
                {
                    comboBoxTipNaselja.SelectedIndex = 3;
                }

                if (tackasti.Tip_turizma.Equals("banjski"))
                {
                    comboBoxTipTurizma.SelectedIndex = 0;
                }
                else if (tackasti.Tip_turizma.Equals("zimski"))
                {
                    comboBoxTipTurizma.SelectedIndex = 1;
                }
                else if (tackasti.Tip_turizma.Equals("letnji"))
                {
                    comboBoxTipTurizma.SelectedIndex = 2;
                }
            }
            else if (tackasti.F_naseljeno == 1 && tackasti.F_turisticko == 0)
            {
                cmxTip.SelectedIndex = 1;

                txtBrojStanovnika.Text = tackasti.Broj_Stanovnika.ToString();
                txtOpstina.Text = tackasti.Opstina.ToString();
                dateOsnivanje.Value = tackasti.Datum_Osnivanja;

                if (tackasti.Tip_naselja.Equals("1000-10000"))
                {
                    comboBoxTipNaselja.SelectedIndex = 0;
                }
                else if (tackasti.Tip_naselja.Equals("10000-100000"))
                {
                    comboBoxTipNaselja.SelectedIndex = 1;
                }
                else if (tackasti.Tip_naselja.Equals("100000-500000"))
                {
                    comboBoxTipNaselja.SelectedIndex = 2;
                }
                else if (tackasti.Tip_naselja.Equals("500000-1000000"))
                {
                    comboBoxTipNaselja.SelectedIndex = 3;
                }
                else if (tackasti.Tip_naselja.Equals("1000000-10000000"))
                {
                    comboBoxTipNaselja.SelectedIndex = 3;
                }
            }
            else if (tackasti.F_naseljeno == 0 && tackasti.F_turisticko == 0)
            {
                cmxTip.SelectedIndex = 0;
            }

            

            foreach (LinijskiObjekat se in tackasti.Lista_Linijskih_objekata)
            {
                try
                {
                    LinijskiObjekat lin = DTOManager.GetLinijskiObjekat(se.Id);

                    ListViewItem item = new ListViewItem(new string[] { lin.Id.ToString(), lin.Naziv });
                    listViewLinijski.Items.Add(item);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

            }
            listViewLinijski.Refresh();

            foreach (var se in tackasti.Lista_Znamenitosti)
            {
                try
                {
                    ListViewItem item = new ListViewItem(new string[] { se.Naziv_Znamenitost });
                    listViewZnamenitosti.Items.Add(item);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

            }
            listViewZnamenitosti.Refresh();

            //SveZnamenitostiBasic svb = DTOManager.GetSveZnamenitosti();
            //foreach (var se in svb.Lista_Znamenitosti)
            //{
            //    try
            //    {
            //        ListViewItem item = new ListViewItem(new string[] { se.Id.ToString(), se.Naziv_Znamenitost });
            //        listViewSvihZnamenitosti.Items.Add(item);
            //    }
            //    catch (Exception e)
            //    {
            //        MessageBox.Show(e.Message);
            //    }

            //}
            //listViewSvihZnamenitosti.Refresh();
        }

        #endregion

        #region event handlers

        private void MFormDodajAzurirajTackastiObjekat_Load(object sender, EventArgs e)
        {
            if (Tip == 0)//dodaj
            {
                cmxTip.SelectedIndex = 0;

                //txtNovaZnamenitost.Enabled = false;///
                //listViewZnamenitosti.Enabled = false;///
                //btnDodajNovuZnamenitost.Enabled = false;///
            }
            else if (Tip == 1)//azuriraj
                RetrieveInfo(Tackasti);
            else if (Tip == 2)//prikazi
            {
                RetrieveInfo(Tackasti);

                txtNaziv.Enabled = false;
                txtX.Enabled = false;
                txtY.Enabled = false;
                txtBrojStanovnika.Enabled = false;
                txtOpstina.Enabled = false;
                cmxTip.Enabled = false;
                comboBoxTipNaselja.Enabled = false;
                comboBoxTipTurizma.Enabled = false;
                dateOsnivanje.Enabled = false;
                dateStatus.Enabled = false;
                //listViewZnamenitosti.Enabled = false;//
                //listViewSvihZnamenitosti.Enabled = false;
                //listViewLinijski.Enabled = false;//
                btnDodajNovuZnamenitost.Enabled = false;
                //btnDodajPostojecuZnamenitost.Enabled = false;
                txtNovaZnamenitost.Enabled = false;
            }
        }

        private void cmxTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmxTip.SelectedIndex == 0) //tackasti
            {
                txtBrojStanovnika.Enabled = false;
                txtOpstina.Enabled = false;
                comboBoxTipNaselja.Enabled = false;
                comboBoxTipTurizma.Enabled = false;
                //dateOsnivanje.Enabled = false;
                dateStatus.Enabled = false;
                //if (Tip != 0)//ako je tip = 0 onda je mod za dodavanje i ne moze se dodati znamenitost dok se ne sacuva tackasti objekat
                //edit: sada je ipak odradjeno tako da moze!
                {
                    listViewZnamenitosti.Enabled = false;
                    //listViewSvihZnamenitosti.Enabled = false;
                    btnDodajNovuZnamenitost.Enabled = false;
                    //btnDodajPostojecuZnamenitost.Enabled = false;
                    txtNovaZnamenitost.Enabled = false;
                }
            }
            else if (cmxTip.SelectedIndex == 1) //naseljeno
            {
                txtBrojStanovnika.Enabled = true;
                txtOpstina.Enabled = true;
                comboBoxTipNaselja.Enabled = true;
                comboBoxTipTurizma.Enabled = false;
                //dateOsnivanje.Enabled = true;
                dateStatus.Enabled = false;
                //if (Tip != 0)
                {
                    listViewZnamenitosti.Enabled = true;
                    //listViewSvihZnamenitosti.Enabled = true;
                    btnDodajNovuZnamenitost.Enabled = true;
                    //btnDodajPostojecuZnamenitost.Enabled = true;
                    txtNovaZnamenitost.Enabled = true;
                }
            }
            else if (cmxTip.SelectedIndex == 2) //turisticko
            {
                txtBrojStanovnika.Enabled = true;
                txtOpstina.Enabled = true;
                comboBoxTipNaselja.Enabled = true;
                comboBoxTipTurizma.Enabled = true;
                //dateOsnivanje.Enabled = true;
                dateStatus.Enabled = true;
                //if (Tip != 0)
                {
                    listViewZnamenitosti.Enabled = true;
                    //listViewSvihZnamenitosti.Enabled = true;
                    btnDodajNovuZnamenitost.Enabled = true;
                    //btnDodajPostojecuZnamenitost.Enabled = true;
                    txtNovaZnamenitost.Enabled = true;
                }
            }
        }

        private void btnDodajNovuZnamenitost_Click(object sender, EventArgs e)
        {
            //ZnamenitostBasic z = new ZnamenitostBasic(txtNovaZnamenitost.Text, DTOManager.GetTackastiObjekat(Tackasti.Id));///
            //DTOManager.AddZnamenitost(z);///

            if (this.Tip == 0)
                Tackasti.Lista_Znamenitosti.Add(new Znamenitost(txtNovaZnamenitost.Text));///
            else if (this.Tip == 1)
            {
                Tackasti.Lista_Znamenitosti.Add(new Znamenitost(txtNovaZnamenitost.Text, DTOManager.GetTackastiObjekat(Tackasti.Id)));///
            }

            ListViewItem item = new ListViewItem(new string[] { txtNovaZnamenitost.Text });

            listViewZnamenitosti.Items.Add(item);
            listViewZnamenitosti.Refresh();
            //ListViewItem item = new ListViewItem(new string[] { se.Id.ToString(), se.Naziv_Znamenitost });
            //listViewSvihZnamenitosti.Items.Add(item);
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Tip == 0)//dodaj
            {
                Tackasti.Naziv = txtNaziv.Text;
                if (cmxTip.SelectedIndex == 0) //tackasti
                {
                    DTOManager.AddTackastiObjekatBasic(new TackastiObjekatBasic(
                        0, txtNaziv.Text, txtX.Text, txtY.Text, dateOsnivanje.Value));
                }
                else if (cmxTip.SelectedIndex == 1) //naseljeno
                {
                    DTOManager.AddTackastiObjekatBasic(new TackastiObjekatBasic(
                        0, txtNaziv.Text, txtX.Text, txtY.Text, dateOsnivanje.Value,
                        txtBrojStanovnika.Text, comboBoxTipNaselja.Text, txtOpstina.Text, Tackasti.Lista_Znamenitosti));
                }
                else if (cmxTip.SelectedIndex == 2) //turisticko
                {
                    DTOManager.AddTackastiObjekatBasic(new TackastiObjekatBasic(
                        0, txtNaziv.Text, txtX.Text, txtY.Text, dateOsnivanje.Value,
                        txtBrojStanovnika.Text, comboBoxTipNaselja.Text, txtOpstina.Text, Tackasti.Lista_Znamenitosti,
                        comboBoxTipTurizma.Text, dateStatus.Value));
                }
            }
            else if (Tip == 1)//azuriraj
            {
                if (cmxTip.SelectedIndex == 0) //tackasti
                {
                    DTOManager.UpdateTackastiObjekatBasic(new TackastiObjekatBasic(
                        Tackasti.Id, txtNaziv.Text, txtX.Text, txtY.Text, dateOsnivanje.Value));
                }
                else if (cmxTip.SelectedIndex == 1) //naseljeno
                {
                    DTOManager.UpdateTackastiObjekatBasic(new TackastiObjekatBasic(
                        Tackasti.Id, txtNaziv.Text, txtX.Text, txtY.Text, dateOsnivanje.Value,
                        txtBrojStanovnika.Text, comboBoxTipNaselja.Text, txtOpstina.Text, Tackasti.Lista_Znamenitosti));
                }
                else if (cmxTip.SelectedIndex == 2) //turisticko
                {
                    DTOManager.UpdateTackastiObjekatBasic(new TackastiObjekatBasic(
                        Tackasti.Id, txtNaziv.Text, txtX.Text, txtY.Text, dateOsnivanje.Value,
                        txtBrojStanovnika.Text, comboBoxTipNaselja.Text, txtOpstina.Text, Tackasti.Lista_Znamenitosti,
                        comboBoxTipTurizma.Text, dateStatus.Value));
                }


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