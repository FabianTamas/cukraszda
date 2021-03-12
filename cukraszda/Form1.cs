using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace cukraszda
{
    public partial class frmFo : Form
    {
        List<Cuki> cukis = new List<Cuki>();

        public frmFo()
        {
            InitializeComponent();
        }

        private void btnBeolvas_Click(object sender, EventArgs e)
        {
            StreamReader be = new StreamReader("cuki.txt");
            while (!be.EndOfStream)
            {
                string[] a = be.ReadLine().Split(';');
                cukis.Add(new Cuki(a[0], a[1], bool.Parse(a[2]), int.Parse(a[3]), a[4]));
            }
            be.Close();

            MessageBox.Show("Beolvasva.");
        }

        private void btnElso_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int index = rnd.Next(0, cukis.Count);
            lbKiiras.Items.Clear();
            for (int i = 0; i < cukis.Count; i++)
            {
                if (i == index)
                {
                    lbKiiras.Items.Add(cukis[index].Nev);
                }
            }
        }

        private void btnMasodik_Click(object sender, EventArgs e)
        {

        }
    }
}
