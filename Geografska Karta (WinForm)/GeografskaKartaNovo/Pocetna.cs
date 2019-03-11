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
    public partial class Pocetna : Form
    {
        public Pocetna()
        {
            InitializeComponent();
        }

        private void btnGeografski_Click(object sender, EventArgs e)
        {
            FormGeografskiObjekti f = new FormGeografskiObjekti();

            f.Show();
        }

        private void btnTackasti_Click(object sender, EventArgs e)
        {
            FormTackastiObjekti f = new FormTackastiObjekti();

            f.Show();
        }

        private void btnLinijski_Click(object sender, EventArgs e)
        {
            FormLinijskiObjekti f = new FormLinijskiObjekti();

            f.Show();
        }

        private void btnPovrsinski_Click(object sender, EventArgs e)
        {
            FormPovrsinskiObjekti f = new FormPovrsinskiObjekti();

            f.Show();
        }

        private void btnUzvisenje_Click(object sender, EventArgs e)
        {
            FormUzvisenje f = new FormUzvisenje();

            f.Show();

        }

        private void btnVodnaPovrsina_Click(object sender, EventArgs e)
        {
             FormVodnaPovrsina f = new FormVodnaPovrsina();

            f.Show();
        }
    }
}
