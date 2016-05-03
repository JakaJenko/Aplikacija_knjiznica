using MySql.Data.MySqlClient;
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
    public partial class koncaj_izposojo : Form
    {
        public koncaj_izposojo()
        {
            InitializeComponent();
        }

        private void koncaj_izposojo_Load(object sender, EventArgs e)
        {
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            DataTable table = new DataTable();


            dataAdapter = baza_data.Select_knjige_za_izposojo();

            dataAdapter.Fill(table);
            bindingSource1.DataSource = table;

            kon_izp_data.DataSource = bindingSource1;
        }

        private void button1_Click(object sender, EventArgs e) //kon_izp_odstrani_knj
        {
            try
            {
                int row_index = kon_izp_data.CurrentCell.RowIndex;

                izposoja_shrani.izp_knj.Remove(Convert.ToInt32(kon_izp_data.Rows[row_index].Cells[0].Value));

                kon_izp_data.Rows.RemoveAt(row_index);
            }
            catch
            { }
        }

        private void izp_knj_potrdi_Click(object sender, EventArgs e)
        {
            bool napaka = false;

            //označi vse ki jih že ima doma NAREDI
            foreach (DataGridViewRow i in kon_izp_data.Rows)
            {
                foreach (string x in baza_data.Select_izposojene_od_uporabnika(Convert.ToInt32(user_card_nuber.Text)))
                {
                    try
                    {
                        if (i.Cells[0].Value.ToString() == x)
                        {
                            kon_izp_data.Rows[i.Index].DefaultCellStyle.BackColor = Color.Yellow;

                            napaka = true;
                        }
                    }
                    catch (Exception ex)
                    { }
                }
            }

            if (napaka == false)
            {
                if (DateTime.Compare(vrni_do.Value, DateTime.Now) == 1)
                {
                    if (izposoja_shrani.izp_knj.Count > 0)
                    {
                        baza_data.Insert_into_izposoja(user_card_nuber.Text, vrni_do.Text);
                    }
                    else
                    {
                        MessageBox.Show("Izbrana mora biti vsaj ena knjiga");
                    }
                }
                else
                {
                    MessageBox.Show("Datum vrnitve mora biti večji od današnjega");
                }
            }
            else
            {
                MessageBox.Show("Nekatere od teh knjig so že izposojene na tem računu");
            }
        }
    }
}
