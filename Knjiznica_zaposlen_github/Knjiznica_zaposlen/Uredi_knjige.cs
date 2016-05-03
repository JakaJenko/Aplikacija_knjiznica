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
    public partial class Uredi_knjige : Form
    {

        int[] avtor_zap_id = new int[1000];

        public Uredi_knjige()
        {
            InitializeComponent();
        }

        private void dodaj_avtorja_Click(object sender, EventArgs e)
        {
            avtor_zap_id = null;

            baza_data.dodaj_avtorja(dodaj_avtor_ime.Text, dodaj_avtor_priimek.Text);

            dodaj_avtor_ime.Text = "";
            dodaj_avtor_priimek.Text = "";


            dodaj_nov_knj_avtor.Items.Clear();
            obs_knj_avtor.Items.Clear();

            int x = 0;

            foreach (avtor_class i in baza_data.Select_avtorji())
            {
                dodaj_nov_knj_avtor.Items.Add(i.ImeInPriimek);
                obs_knj_avtor.Items.Add(i.ImeInPriimek);

                avtor_zap_id[x] = Convert.ToInt32(i.Id);
                x++;
            }
        }

        private void Uredi_knjige_Load(object sender, EventArgs e)
        {
            moja_knj2.Text = Zaposlen.knj_ime;

            dodaj_nov_knj_jezik.DataSource = baza_data.Select_jeziki();
            dodaj_nov_knj_zvrst.DataSource = baza_data.Select_zvrsti();
            dodaj_nov_knj_zalozba.DataSource = baza_data.Select_zalozbe();
            obs_knj_jezik.DataSource = baza_data.Select_jeziki();
            obs_knj_zvrst.DataSource = baza_data.Select_zvrsti();
            obs_knj_zalozba.DataSource = baza_data.Select_zalozbe();

            int x = 0;

            foreach (avtor_class i in baza_data.Select_avtorji())
            {
                dodaj_nov_knj_avtor.Items.Add(i.ImeInPriimek);
                obs_knj_avtor.Items.Add(i.ImeInPriimek);

                avtor_zap_id[x] = Convert.ToInt32(i.Id);
                x++;
            }
        }

        private void dodaj_novo_knjigo_Click(object sender, EventArgs e)
        {
            try
            {
                baza_data.dodaj_novo_knjigo(avtor_zap_id[dodaj_nov_knj_avtor.SelectedIndex], dodaj_nov_knj_jezik.SelectedIndex + 1, dodaj_nov_knj_zvrst.SelectedIndex + 1, dodaj_nov_knj_zalozba.SelectedIndex + 1, Convert.ToInt32(dodaj_nov_knj_leto.Text), dodaj_nov_knj_opombe.Text, dodaj_nov_knj_ISBN.Text, dodaj_nov_knj_UKD.Text, dodaj_nov_knj_naslov.Text);

                MessageBox.Show("Uspešno dodana knjiga");

                dodaj_nov_knj_naslov.Text = "";
                dodaj_nov_knj_jezik.SelectedIndex = 0;
                dodaj_nov_knj_zvrst.SelectedIndex = 0;
                dodaj_nov_knj_leto.Text = "";
                dodaj_nov_knj_zalozba.SelectedIndex = 0;
                dodaj_nov_knj_opombe.Text = "";
                dodaj_nov_knj_ISBN.Text = "";
                dodaj_nov_knj_UKD.Text = "";
                dodaj_nov_knj_avtor.SelectedIndex = 0;
            }
            catch (ArgumentException a)
            {
                MessageBox.Show("Polje 'leto' mora biti izpoljeno - dovoljene so le številke");
            }
        }

        private void izvedi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (izvedi.SelectedItem.ToString() == "Dodaj obstoječo knjigo")
            {
                odstrani_knj.Visible = false;
                dodaj_knj.Visible = true;
                dodaj_knj.BringToFront();
            }
            else
            {
                dodaj_knj.Visible = false;
                odstrani_knj.Visible = true;
                odstrani_knj.BringToFront();
            }
        }

        private void isci_knjige_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            int avtor_id;

            if (izvedi.SelectedIndex == 0)
            {
                if (obs_knj_avtor.SelectedIndex != -1)
                {
                    avtor_id = avtor_zap_id[obs_knj_avtor.SelectedIndex];
                }
                else
                {
                    avtor_id = 0;
                }

                dataAdapter = baza_data.Select_knjige(obs_knj_naslov.Text, avtor_id, obs_knj_jezik.SelectedIndex + 1, obs_knj_zvrst.SelectedIndex + 1, obs_knj_zalozba.SelectedIndex + 1);

                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;

                dodaj_obs_knj_data.DataSource = bindingSource1;
            }
            else if (izvedi.SelectedIndex == 1)
            {
                if (obs_knj_avtor.SelectedIndex != -1)
                {
                    avtor_id = avtor_zap_id[obs_knj_avtor.SelectedIndex];
                }
                else
                {
                    avtor_id = 0;
                }

                dataAdapter = baza_data.Select_knjige_v_knjiznici(obs_knj_naslov.Text, avtor_id, obs_knj_jezik.SelectedIndex + 1, obs_knj_zvrst.SelectedIndex + 1, obs_knj_zalozba.SelectedIndex + 1);

                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;

                ods_obs_knj_data.DataSource = bindingSource1;
            }
            else
            {
                MessageBox.Show("Izberi izvedbo");
            }
        }

        private void dodaj_obs_knj_Click(object sender, EventArgs e)
        {
            if (dodaj_obs_knj_data.DataSource != null)
            {
                try
                {
                    if (Convert.ToInt32(dodaj_obs_knj_krat.Text) > 0 && Convert.ToInt32(dodaj_obs_knj_krat.Text) < 100)
                    {
                        int id;
                        id = dodaj_obs_knj_data.CurrentCell.RowIndex;
                        id = Convert.ToInt32(dodaj_obs_knj_data.Rows[id].Cells[0].Value);

                        baza_data.dodaj_obs_knjigo(id, Convert.ToInt32(Zaposlen.knj_id), Convert.ToInt32(dodaj_obs_knj_krat.Text));
                    }
                    else
                    {
                        MessageBox.Show("Dovoljena so samo števila večja od 0 in manjša od 100");
                    }
                }
                catch
                {
                    MessageBox.Show("Dovoljeno je vnašati samo številke");
                }
            }
            else
            {
                MessageBox.Show("Izberi knjigo");
            }
        }

        private void ods_obs_knj_Click(object sender, EventArgs e)
        {
            if (ods_obs_knj_data.DataSource != null)
            {
                try
                {
                    if (Convert.ToInt32(ods_ons_knj_krat.Text) > 0 && Convert.ToInt32(ods_ons_knj_krat.Text) < 100)
                    {
                        int id;
                        id = ods_obs_knj_data.CurrentCell.RowIndex;
                        id = Convert.ToInt32(ods_obs_knj_data.Rows[id].Cells[0].Value);

                        baza_data.ods_obs_knjigo(id, Convert.ToInt32(Zaposlen.knj_id), Convert.ToInt32(ods_ons_knj_krat.Text));
                    }
                    else
                    {
                        MessageBox.Show("Dovoljena so samo števila večja od 0 in manjša od 100");
                    }
                }
                catch
                {
                    MessageBox.Show("Dovoljeno je vnašati samo številke");
                }
            }
            else
            {
                MessageBox.Show("Izberi knjigo");
            }
        }

        private void ods_vse_obs_knj_Click(object sender, EventArgs e)
        {
            int id;
            id = ods_obs_knj_data.CurrentCell.RowIndex;
            id = Convert.ToInt32(ods_obs_knj_data.Rows[id].Cells[0].Value);

            baza_data.ods_obs_knjigo(id, Convert.ToInt32(Zaposlen.knj_id), -1);
        }
    }
}
