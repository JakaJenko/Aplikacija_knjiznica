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
    public partial class Vrni_knjige : Form
    {
        public Vrni_knjige()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //vrni gumb
        {
            if (Convert.ToInt32(card_number.Text) > 0 && Convert.ToInt32(card_number.Text) < 100000000)
            {
                if (baza_data.izberi_uporabnika(Convert.ToInt32(card_number.Text)))
                {
                    Vrni_knjige_izberi f2 = new Vrni_knjige_izberi();
                    f2.Show();
                }
            }
            else
            {
                MessageBox.Show("Številka kartice je med 0 in 100000000");
            }
        }
    }
}
