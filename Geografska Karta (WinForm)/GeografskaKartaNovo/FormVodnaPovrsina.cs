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
    public partial class FormVodnaPovrsina : Form
    {

        #region konstruktor

        public FormVodnaPovrsina()
        {
            InitializeComponent();
        }

        #endregion

        #region metode

        private void PopulateInfos()
        {
            listViewGeografski.Items.Clear();
            List<VodnaPovrsinaBasic> vpbList = DTOManager.GetSveVodnePovrsine();
            foreach (VodnaPovrsinaBasic vpb in vpbList)
            {
                ListViewItem item = new ListViewItem(new string[] { vpb.Id.ToString(), vpb.Naziv, vpb.Tip_Vode });

                listViewGeografski.Items.Add(item);
                
            }
            listViewGeografski.Refresh();
        }

        #endregion

        #region event handlers

        private void FormVodnaPovrsina_Load(object sender, EventArgs e)
        {
            this.PopulateInfos();
        }

        private void btnDodajNovi_Click(object sender, EventArgs e)
        {
            MFormDodajAzurirajVodnaPovrsina f = new MFormDodajAzurirajVodnaPovrsina();

            f.Tip = 0;

            if (f.ShowDialog() == DialogResult.OK) { }
                this.PopulateInfos();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            
            if (listViewGeografski.SelectedItems.Count == 0)
            {
                return;
            }

            int id = Int32.Parse(listViewGeografski.SelectedItems[0].SubItems[0].Text);
            VodnaPovrsinaBasic vpb = DTOManager.GetVodnaPovrsinaBasic(id);

            MFormDodajAzurirajVodnaPovrsina f = new MFormDodajAzurirajVodnaPovrsina();

            f.Tip = 1;
            f.Vodna = vpb;

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
            VodnaPovrsinaBasic vpb = DTOManager.GetVodnaPovrsinaBasic(id);

            MFormDodajAzurirajVodnaPovrsina f = new MFormDodajAzurirajVodnaPovrsina();

            f.Tip = 2;
            f.Vodna = vpb;

            f.Show();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (listViewGeografski.SelectedItems.Count == 0)
            {
                return;
            }

            int id = Int32.Parse(listViewGeografski.SelectedItems[0].SubItems[0].Text);


            DTOManager.DeleteVodnaPovrsinaBasic(id);

            this.PopulateInfos();
        }

        #endregion


    }
}
