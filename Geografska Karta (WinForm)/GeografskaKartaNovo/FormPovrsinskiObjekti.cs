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
    public partial class FormPovrsinskiObjekti : Form
    {

        #region konstruktor

        public FormPovrsinskiObjekti()
        {
            InitializeComponent();
        }

        #endregion

        #region metode

        private void PopulateInfos()
        {
            listViewGeografski.Items.Clear();
            List<PovrsinskiObjekatBasic> pobList = DTOManager.GetSvePovrsinskeObjekteBasic();
            foreach (PovrsinskiObjekatBasic po in pobList)
            {

                    ListViewItem item = new ListViewItem(new string[] { po.Id.ToString(), po.Naziv });

                    listViewGeografski.Items.Add(item);

            }
            listViewGeografski.Refresh();
        }

        #endregion
        
        #region event handlers

        private void FormPovrsinskiObjekti_Load(object sender, EventArgs e)
        {
            this.PopulateInfos();
        }

        private void btnDodajNovi_Click(object sender, EventArgs e)
        {
            MFormDodajAzurirajPovrsinskiObjekti f = new MFormDodajAzurirajPovrsinskiObjekti();

            f.Tip = 0;

            if (f.ShowDialog() == DialogResult.OK)
                this.PopulateInfos();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            if (listViewGeografski.SelectedItems.Count == 0)
            {
                return;
            }
            int id = Int32.Parse(listViewGeografski.SelectedItems[0].SubItems[0].Text);
            PovrsinskiObjekatBasic po = DTOManager.GetPovrsinskiObjekatBasic(id);


            MFormDodajAzurirajPovrsinskiObjekti f = new MFormDodajAzurirajPovrsinskiObjekti();

            f.Tip = 1;
            f.Povrsinski = po;

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
            PovrsinskiObjekatBasic po = DTOManager.GetPovrsinskiObjekatBasic(id);


            MFormDodajAzurirajPovrsinskiObjekti f = new MFormDodajAzurirajPovrsinskiObjekti();

            f.Tip = 2;
            f.Povrsinski = po;

            f.Show();
        }
        
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (listViewGeografski.SelectedItems.Count == 0)
            {
                return;
            }

            int id = Int32.Parse(listViewGeografski.SelectedItems[0].SubItems[0].Text);


            DTOManager.DeletePovrsinskiObjekatBasic(id);

            this.PopulateInfos();
        }

        #endregion

    }
}
