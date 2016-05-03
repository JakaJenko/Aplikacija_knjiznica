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
    public partial class Izposodi_knjige : Form
    {
        int[] avtor_zap_id = new int[1000];
        List<int> izp_knj_oznacene = new List<int>();

        public Izposodi_knjige()
        {
            InitializeComponent();
        }

        private void Izposodi_knjige_Load(object sender, EventArgs e)
        {
            moja_knj.Text = Zaposlen.knj_ime;

            izp_knj_jezik.DataSource = baza_data.Select_jeziki();
            izp_knj_zvrst.DataSource = baza_data.Select_zvrsti();
            izp_knj_zalozba.DataSource = baza_data.Select_zalozbe();

            int x = 0;

            foreach (avtor_class i in baza_data.Select_avtorji())
            {
                izp_knj_avtor.Items.Add(i.ImeInPriimek);

                avtor_zap_id[x] = Convert.ToInt32(i.Id);
                x++;
            }
        }

        private void izp_isci_knj_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            int avtor_id;

            if (izp_knj_avtor.SelectedIndex != -1)
            {
                avtor_id = avtor_zap_id[izp_knj_avtor.SelectedIndex];
            }
            else
            {
                avtor_id = 0;
            }

            dataAdapter = baza_data.Select_knjige_v_knjiznici(izp_knj_naslov.Text, avtor_id, izp_knj_jezik.SelectedIndex + 1, izp_knj_zvrst.SelectedIndex + 1, izp_knj_zalozba.SelectedIndex + 1);

            dataAdapter.Fill(table);
            bindingSource1.DataSource = table;

            izp_knj_data.DataSource = bindingSource1;

            foreach (DataGridViewRow i in izp_knj_data.Rows)
            {
                foreach (int x in izp_knj_oznacene)
                {
                    if (Convert.ToInt32(i.Cells[0].Value) == x)
                    {
                        izp_knj_data.Rows[i.Index].DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                }
            }

            //označi katere so vse izposojene
            foreach (DataGridViewRow i in izp_knj_data.Rows)
            {
                foreach (string x in baza_data.Select_izposojene_vse())
                {
                    if (i.Cells[0].Value.ToString() == x)
                    {
                        izp_knj_data.Rows[i.Index].DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
        }

        private void izp_knj_izposodi_Click(object sender, EventArgs e)
        {
            int row_index = izp_knj_data.CurrentCell.RowIndex;
            int knj_id = Convert.ToInt32(izp_knj_data.Rows[row_index].Cells[0].Value);
            bool obs = false;

            if (izp_knj_data.Rows[row_index].DefaultCellStyle.BackColor != Color.Red)
            {
                foreach (int i in izp_knj_oznacene)
                {
                    if (i == knj_id)
                    {
                        obs = true;
                    }
                }

                if (obs == false)
                {
                    izp_knj_data.Rows[row_index].DefaultCellStyle.BackColor = Color.LightGreen;
                    izp_knj_oznacene.Add(knj_id);
                }
            }
            else
            {
                MessageBox.Show("Vse knjige so izposojene");
            }
        }

        private void izp_knj_neizposodi_Click(object sender, EventArgs e)
        {
            int row_index = izp_knj_data.CurrentCell.RowIndex;
            int knj_id = Convert.ToInt32(izp_knj_data.Rows[row_index].Cells[0].Value);
            bool ods = false;

            foreach (int i in izp_knj_oznacene)
            {
                if (i == knj_id)
                {
                    ods = true;
                }
            }

            if (ods == true)
            {
                izp_knj_data.Rows[row_index].DefaultCellStyle.BackColor = Color.White;
                izp_knj_oznacene.Remove(knj_id);
            }
        }

        private void izp_knj_data_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DataGridViewRow row in izp_knj_data.Rows)
            {
                foreach (int i in izp_knj_oznacene)
                {
                    try
                    {
                        if (Convert.ToInt32(row.Cells[0].Value) == i)
                        {
                            izp_knj_data.Rows[row.Index].DefaultCellStyle.BackColor = Color.LightGreen;
                        }
                    }
                    catch
                    { }
                }
            }

            foreach (DataGridViewRow i in izp_knj_data.Rows)
            {
                foreach (string x in baza_data.Select_izposojene_vse())
                {
                    if (i.Cells[0].Value.ToString() == x)
                    {
                        izp_knj_data.Rows[i.Index].DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
        }

        private void izp_knj_koncaj_Click(object sender, EventArgs e)
        {
            if (izp_knj_oznacene.Count != 0)
            {
                izposoja_shrani.izp_knj = izp_knj_oznacene;

                koncaj_izposojo f2 = new koncaj_izposojo();
                f2.Show();

                izposoja_shrani.izvedi = true;
            }
            else
            {
                MessageBox.Show("Izberi vsaj eno knjigo");
            }
        }

        private void Izposodi_knjige_Activated(object sender, EventArgs e)
        {
            if (izposoja_shrani.izvedi == true)
            {
                izposoja_shrani.izvedi = false;

                if (izposoja_shrani.izp_knj.Count > 0)
                {
                    foreach (DataGridViewRow i in izp_knj_data.Rows)
                    {
                        foreach (int x in izp_knj_oznacene)
                        {
                            if (Convert.ToInt32(i.Cells[0].Value) != x)
                            {
                                izp_knj_data.Rows[i.Index].DefaultCellStyle.BackColor = Color.White;
                            }
                        }
                    }
                    foreach (DataGridViewRow i in izp_knj_data.Rows)
                    {
                        foreach (int x in izp_knj_oznacene)
                        {
                            if (Convert.ToInt32(i.Cells[0].Value) == x)
                            {
                                izp_knj_data.Rows[i.Index].DefaultCellStyle.BackColor = Color.LightGreen;
                            }
                        }
                    }
                }
                else
                {
                    foreach (DataGridViewRow i in izp_knj_data.Rows)
                    {
                        izp_knj_data.Rows[i.Index].DefaultCellStyle.BackColor = Color.White;
                    }
                }

                foreach (DataGridViewRow i in izp_knj_data.Rows)
                {
                    foreach (string x in baza_data.Select_izposojene_vse())
                    {
                        if (i.Cells[0].Value.ToString() == x)
                        {
                            izp_knj_data.Rows[i.Index].DefaultCellStyle.BackColor = Color.Red;
                        }
                    }
                }
            }
        }
    }
}
