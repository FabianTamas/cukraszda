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
            lbKiiras.Items.Clear();
            
            int max = 0;
            int maxIndex = 0;
            int min = 50000;
            int minIndex = 0;
            for (int i = 0; i < cukis.Count; i++)
            {
                if (cukis[i].Ar > max)
                {
                    max = cukis[i].Ar;
                    maxIndex = i;
                }
            }

            for (int i = 0; i < cukis.Count; i++)
            {
                if (cukis[i].Ar < min)
                {
                    min = cukis[i].Ar;
                    minIndex = i;
                }
            }

            lbKiiras.Items.Add("A legdrágább sütemény: " + cukis[maxIndex].Nev);
            lbKiiras.Items.Add("Ára: " + cukis[maxIndex].Ar);

            lbKiiras.Items.Add("A legolcsóbb sütemény: " + cukis[minIndex].Nev);
            lbKiiras.Items.Add("Ára: " + cukis[minIndex].Ar);
        }

        private void btnHarmadik_Click(object sender, EventArgs e)
        {
            lbKiiras.Items.Clear();

            int db = 0;
            foreach (var c in cukis)
            {
                if (c.Dijazott == true)
                {
                    db++;
                }
            }

            lbKiiras.Items.Add("Díjazott sütik száma: " + db);
        }

        private void btnNegyedik_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> sutik = new Dictionary<string, string>();
            foreach (var c in cukis)
            {
                if (!sutik.ContainsKey(c.Nev))
                {
                    sutik.Add(c.Nev, c.Tipus);
                }
            }

            StreamWriter sw = new StreamWriter("lista.txt");
            foreach (var s in sutik)
            {
                sw.WriteLine(s.Key + " " + s.Value);
            }
            sw.Close();

            MessageBox.Show("Sikeres kiírás.");
        }

    private void btnotodik_Click(object sender, EventArgs e)
    {
      Dictionary<string, int> fajta = new Dictionary<string, int>();

      foreach (var c in cukis)
      {
        if (!fajta.ContainsKey(c.Tipus))
        {
          fajta.Add(c.Tipus, 1);
        }
        else
        {
          fajta[c.Tipus]++;
        }
      }
      StreamWriter ir = new StreamWriter("stat.csv");
      foreach (var f in fajta)
      {
        ir.WriteLine(f.Key + ";" + f.Value);
      }
      ir.Close();
      MessageBox.Show("Sikeres kiírás.");
    }
  }
}
