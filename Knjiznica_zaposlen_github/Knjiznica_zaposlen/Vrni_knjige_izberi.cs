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
    public partial class Vrni_knjige_izberi : Form
    {
        List<int> vrn_knj_oznacene = new List<int>();

        public Vrni_knjige_izberi()
        {
            InitializeComponent();
        }

        private void Vrni_knjige_izberi_Load(object sender, EventArgs e)
        {
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            DataTable table = new DataTable();


            dataAdapter = baza_data.Select_izposojene_knjige_od_uporabnika();

            dataAdapter.Fill(table);
            bindingSource1.DataSource = table;

            knj_vrn_data.DataSource = bindingSource1;


            foreach (DataGridViewRow i in knj_vrn_data.Rows)
            {
                try
                {
                    if (baza_data.predolga_izposoja(Convert.ToInt32(i.Cells[0].Value)))
                    {
                        knj_vrn_data.Rows[i.Index].DefaultCellStyle.BackColor = Color.Red;
                    }
                }
                catch (Exception ex)
                { }
            }
        }

        private void button1_Click(object sender, EventArgs e) //vrni_knj gumb
        {
            int row_index = knj_vrn_data.CurrentCell.RowIndex;
            int knj_id = Convert.ToInt32(knj_vrn_data.Rows[row_index].Cells[0].Value);

            if (knj_vrn_data.Rows[row_index].DefaultCellStyle.BackColor != Color.Red)
            {
                knj_vrn_data.Rows[row_index].DefaultCellStyle.BackColor = Color.LightGreen;
                vrn_knj_oznacene.Add(knj_id);
            }
            else
            {
                knj_vrn_data.Rows[row_index].DefaultCellStyle.BackColor = Color.Yellow;
                vrn_knj_oznacene.Add(knj_id);
            }
        }

        private void vrni_knj_koncaj_Click(object sender, EventArgs e)
        {
            baza_data.Delete_izposojene_knjige(Uporabnik.id, vrn_knj_oznacene);
        }
    }
}
