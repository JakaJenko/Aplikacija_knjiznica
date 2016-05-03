using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knjiznica_zaposlen
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Uredi_knjige f2 = new Uredi_knjige();
            f2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Izposodi_knjige f2 = new Izposodi_knjige();
            f2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Vrni_knjige f2 = new Vrni_knjige();
            f2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Prenesi_knjige f2 = new Prenesi_knjige();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Spremeni_geslo f2 = new Spremeni_geslo();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Izpis_podatkov f2 = new Izpis_podatkov();
            f2.Show();
        }
    }
}
