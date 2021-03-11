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
        }
    }
}
