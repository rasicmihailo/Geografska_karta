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
    public partial class FormTackastiObjekti : Form
    {

        #region konstruktor

        public FormTackastiObjekti()
        {
            InitializeComponent();
        }

        #endregion

        #region metode

        private void PopulateInfos()
        {
            listViewGeografski.Items.Clear();
            List<TackastiObjekatBasic> tobList = DTOManager.GetSveTackasteObjekteBasic();
            foreach (TackastiObjekatBasic to in tobList)
            {
                if (to.F_naseljeno == 1 && to.F_turisticko == 1)
                {

                    //String s = to.Tip_naselja;
                    ListViewItem item = new ListViewItem(new string[] { to.Id.ToString(), to.Naziv, to.X_tac.ToString(), to.Y_tac.ToString(), to.Datum_Osnivanja.ToString(), to.F_naseljeno.ToString(),
                            to.F_turisticko.ToString(), to.Broj_Stanovnika.ToString(), to.Tip_naselja.ToString(), to.Opstina.ToString(), to.Datum_status.ToString(),
                            to.Tip_turizma.ToString()});

                    listViewGeografski.Items.Add(item);
                }
                else if (to.F_naseljeno == 1 && to.F_turisticko == 0)
                {

                    //String s = to.Tip_naselja;
                    ListViewItem item = new ListViewItem(new string[] { to.Id.ToString(), to.Naziv, to.X_tac.ToString(), to.Y_tac.ToString(), to.Datum_Osnivanja.ToString(), to.F_naseljeno.ToString(),
                            to.F_turisticko.ToString(), to.Broj_Stanovnika.ToString(), to.Tip_naselja.ToString(), to.Opstina.ToString()});

                    listViewGeografski.Items.Add(item);
                }
                else if (to.F_naseljeno == 0 && to.F_turisticko == 0)
                {

                    //String s = to.Tip_naselja;
                    ListViewItem item = new ListViewItem(new string[] { to.Id.ToString(), to.Naziv, to.X_tac.ToString(),
                        to.Y_tac.ToString(), to.Datum_Osnivanja.ToString(), to.F_naseljeno.ToString(), to.F_turisticko.ToString() });

                    listViewGeografski.Items.Add(item);
                }
            }
            listViewGeografski.Refresh();
        }

        #endregion

        #region event handlers

        private void FormTackastiObjekti_Load(object sender, EventArgs e)
        {
            this.PopulateInfos();
        }

        private void btnDodajNovi_Click(object sender, EventArgs e)
        {
       
            MFormDodajAzurirajTackastiObjekat f = new MFormDodajAzurirajTackastiObjekat();

            f.Tip = 0;

            if(f.ShowDialog() == DialogResult.OK)
                this.PopulateInfos();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
        
            if (listViewGeografski.SelectedItems.Count == 0)
            {
                return;
            }
            int id = Int32.Parse(listViewGeografski.SelectedItems[0].SubItems[0].Text);
            TackastiObjekatBasic to = DTOManager.GetTackastiObjekatBasic(id);

            
            MFormDodajAzurirajTackastiObjekat f = new MFormDodajAzurirajTackastiObjekat();

            f.Tip = 1;
            f.Tackasti = to;

            if (f.ShowDialog() == DialogResult.OK)
                this.PopulateInfos();

        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            if (listViewGeografski.SelectedItems.Count == 0)
            {
                return;
            }

            int id = Int32.Parse(listViewGeografski.SelectedItems[0].SubItems[0].Text);
            TackastiObjekatBasic to = DTOManager.GetTackastiObjekatBasic(id);


            MFormDodajAzurirajTackastiObjekat f = new MFormDodajAzurirajTackastiObjekat();

            f.Tip = 2;
            f.Tackasti = to;

            f.Show();
        }
        
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (listViewGeografski.SelectedItems.Count == 0)
            {
                return;
            }

            int id = Int32.Parse(listViewGeografski.SelectedItems[0].SubItems[0].Text);
            

            DTOManager.DeleteTackastiObjekatBasic(id);

            this.PopulateInfos();
        }

        #endregion

    }
}
