using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knjiznica_zaposlen
{
    class baza_data
    {
        public static bool check_login(string user_name, string password)
        {
            string query = "preveri_prijavo";

            string izpis_knj_id;
            string izpis_knj_ime;

            if (baza_povezovanje.db_povezi() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, baza_povezovanje.connection);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@user_name", user_name);
                cmd.Parameters.AddWithValue("@password", password);

                cmd.Parameters.Add(new MySqlParameter("?knj_id", MySqlDbType.Int64));
                cmd.Parameters["?knj_id"].Direction = ParameterDirection.Output;

                cmd.Parameters.Add(new MySqlParameter("?knj_ime", MySqlDbType.String));
                cmd.Parameters["?knj_ime"].Direction = ParameterDirection.Output;


                cmd.ExecuteNonQuery();


                izpis_knj_id = cmd.Parameters["?knj_id"].Value.ToString();
                izpis_knj_ime = cmd.Parameters["?knj_ime"].Value.ToString();

                Zaposlen.upor_ime = user_name;
                Zaposlen.knj_id = izpis_knj_id;
                Zaposlen.knj_ime = izpis_knj_ime;
                
                baza_povezovanje.db_prekini_povezavo();

                if (izpis_knj_id != "")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        public static void dodaj_avtorja(string avtor_ime, string avtor_priimek)
        {
            string query = "dodaj_avtorja";

            string izpis;

            if (baza_povezovanje.db_povezi() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, baza_povezovanje.connection);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@vpis_ime", avtor_ime);
                cmd.Parameters.AddWithValue("@vpis_priimek", avtor_priimek);

                cmd.Parameters.Add(new MySqlParameter("?obstaja", MySqlDbType.Int64));
                cmd.Parameters["?obstaja"].Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();


                izpis = cmd.Parameters["?obstaja"].Value.ToString();

                baza_povezovanje.db_prekini_povezavo();

                if (izpis == "")
                {
                    MessageBox.Show("Uspešno dodan avtor");

                    return;
                }
                else
                {
                    MessageBox.Show("Avtor že obstaja");

                    return;
                }
            }
            else
            {
                return;
            }
        }


        public static List<string> Select_jeziki()
        {
            string query = "SELECT ime FROM jeziki";

            List<string> list = new List<string>();
            list = new List<string>();

            if (baza_povezovanje.db_povezi() == true)
            {

                MySqlCommand cmd = new MySqlCommand(query, baza_povezovanje.connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();


                while (dataReader.Read())
                {
                    list.Add(dataReader["ime"].ToString());
                }

                dataReader.Close();
                baza_povezovanje.db_prekini_povezavo();

                //MessageBox.Show(list[0][0]);

                return list;
            }
            else
            {
                return list;
            }
        }


        public static List<string> Select_zvrsti()
        {
            string query = "SELECT ime FROM zvrsti";

            List<string> list = new List<string>();
            list = new List<string>();

            if (baza_povezovanje.db_povezi() == true)
            {

                MySqlCommand cmd = new MySqlCommand(query, baza_povezovanje.connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();


                while (dataReader.Read())
                {
                    list.Add(dataReader["ime"].ToString());
                }

                dataReader.Close();
                baza_povezovanje.db_prekini_povezavo();

                return list;
            }
            else
            {
                return list;
            }
        }


        public static List<string> Select_zalozbe()
        {
            string query = "SELECT ime FROM zalozbe";

            List<string> list = new List<string>();
            list = new List<string>();

            if (baza_povezovanje.db_povezi() == true)
            {

                MySqlCommand cmd = new MySqlCommand(query, baza_povezovanje.connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();


                while (dataReader.Read())
                {
                    list.Add(dataReader["ime"].ToString());
                }

                dataReader.Close();
                baza_povezovanje.db_prekini_povezavo();

                return list;
            }
            else
            {
                return list;
            }
        }


        public static List<avtor_class> Select_avtorji()
        {
            string query = "SELECT id, ime, priimek FROM avtorji ORDER BY priimek, ime";

            List<avtor_class> list = new List<avtor_class>();


            /*List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();*/


            if (baza_povezovanje.db_povezi() == true)
            {

                MySqlCommand cmd = new MySqlCommand(query, baza_povezovanje.connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();


                while (dataReader.Read())
                {
                    //list.Add(dataReader["id"].ToString());
                    list.Add(new avtor_class(dataReader["priimek"].ToString() + " " + dataReader["ime"].ToString(), dataReader["id"].ToString()));
                }

                dataReader.Close();
                baza_povezovanje.db_prekini_povezavo();

                return list;
            }
            else
            {
                return list;
            }
        }


        public static void dodaj_novo_knjigo(int avtor, int jezik, int zvrst, int zalozba, int leto, string opomba, string ISBN, string UKD, string naslov)
        {
            if (naslov != "")
            {
                string query = "dodaj_novo_knjigo";

                string izpis;

                if (baza_povezovanje.db_povezi() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, baza_povezovanje.connection);

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@in_avtor", avtor);
                    cmd.Parameters.AddWithValue("@in_prazno", 0);
                    cmd.Parameters.AddWithValue("@in_jezik", jezik);
                    cmd.Parameters.AddWithValue("@in_zvrst", zvrst);
                    cmd.Parameters.AddWithValue("@in_zalozba", zalozba);
                    cmd.Parameters.AddWithValue("@in_leto", leto);
                    cmd.Parameters.AddWithValue("@in_opomba", opomba);
                    cmd.Parameters.AddWithValue("@in_ISBN", ISBN);
                    cmd.Parameters.AddWithValue("@in_UKD", UKD);
                    cmd.Parameters.AddWithValue("@in_naslov", naslov);

                    cmd.Parameters.Add(new MySqlParameter("?out_napaka", MySqlDbType.VarChar));
                    cmd.Parameters["?out_napaka"].Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();


                    izpis = cmd.Parameters["?out_napaka"].Value.ToString();

                    baza_povezovanje.db_prekini_povezavo();

                    if (izpis == "obstaja")
                    {
                        MessageBox.Show("Takšna knjiga že obstaja");

                        return;
                    }
                    else if (izpis=="ISBN_UKD_obstaja")
                    {
                        MessageBox.Show("Knjiga z tem ISBN-jem ali UKD-jem že obstaja");

                        return;
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Naslov je obvezen");
            }
        }


        public static MySqlDataAdapter Select_knjige(string naslov, int avtor, int jezik, int zvrst, int zalozba)
        {
            bool dodaj = false;

            string query = "SELECT k.id, z.ime AS zalozba, zv.ime AS zvrst, j.ime AS jezik, a.ime, a.priimek, k.naslov, k.leto, k.opombe, k.ISBN, k.UKD "
                            + "FROM knjige k "
                            + "INNER JOIN avtorji a ON k.avtor_id = a.id "
                            + "INNER JOIN jeziki j ON k.jezik_id = j.id "
                            + "INNER JOIN zvrsti zv ON k.vrsta_id = zv.id "
                            + "INNER JOIN zalozbe z ON k.zalozba_id = z.id "
                            + "WHERE ";

            if (naslov != "")
            {
                query = funkcije.and(query, dodaj) + query +"k.ime=" + naslov;
                dodaj = true;
            }
            if (avtor != 0)
            {
                query = funkcije.and(query, dodaj) + "k.avtor_id=" + avtor;
                dodaj = true;
            }
            if (jezik != 0)
            {
                query = funkcije.and(query, dodaj) + "k.jezik_id=" + jezik;
                dodaj = true;
            }
            if (zvrst != 0)
            {
                query = funkcije.and(query, dodaj) + "k.vrsta_id=" + zvrst;
                dodaj = true;
            }
            if (zalozba != 0)
            {
                query = funkcije.and(query, dodaj) + "k.zalozba_id=" + zalozba;
            }

            query = query + " ORDER BY a.priimek, a.ime, k.naslov, k.id";


            List<knjiga_class> list = new List<knjiga_class>();


            if (baza_povezovanje.db_povezi() == true)
            {

                MySqlCommand cmd = new MySqlCommand(query, baza_povezovanje.connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                dataAdapter = new MySqlDataAdapter(query, baza_povezovanje.connection);
                

                while (dataReader.Read())
                {
                    list.Add(new knjiga_class(dataReader[0].ToString(), dataReader[1].ToString(), dataReader[2].ToString(), dataReader[3].ToString(), dataReader[4].ToString() + dataReader[5].ToString(), dataReader[6].ToString(), dataReader[7].ToString(), dataReader[8].ToString(), dataReader[9].ToString(), dataReader[10].ToString()));
                }

                dataReader.Close();
                baza_povezovanje.db_prekini_povezavo();

                return dataAdapter;
            }
            else
            {
                return null;
            }
        }


        public static void dodaj_obs_knjigo(int knjiga_id, int knjiznica_id, int kol)
        {
            string query = "dodaj_obs_knjigo";

            string izpis;

            if (baza_povezovanje.db_povezi() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, baza_povezovanje.connection);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@in_knj_id", knjiznica_id);
                cmd.Parameters.AddWithValue("@in_knjiga_id", knjiga_id);
                cmd.Parameters.AddWithValue("@in_kol", kol);

                cmd.Parameters.Add(new MySqlParameter("?out_skupno_st", MySqlDbType.VarChar));
                cmd.Parameters["?out_skupno_st"].Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();


                izpis = cmd.Parameters["?out_skupno_st"].Value.ToString();

                baza_povezovanje.db_prekini_povezavo();

                MessageBox.Show("Uspešno dodanih " + kol + " knjig. Skupaj jih je v knjižnici " + izpis);

                return;
            }
            else
            {
                return;
            }
        }


        public static MySqlDataAdapter Select_knjige_v_knjiznici(string naslov, int avtor, int jezik, int zvrst, int zalozba)
        {
            string query = "SELECT kk.id, z.ime AS zalozba, zv.ime AS zvrst, j.ime AS jezik, a.ime, a.priimek, k.naslov, k.leto, k.opombe, k.ISBN, k.UKD "
                            + "FROM knjige k "
                            + "INNER JOIN avtorji a ON k.avtor_id = a.id "
                            + "INNER JOIN jeziki j ON k.jezik_id = j.id "
                            + "INNER JOIN zvrsti zv ON k.vrsta_id = zv.id "
                            + "INNER JOIN zalozbe z ON k.zalozba_id = z.id "
                            + "INNER JOIN knjige_knjiznice kk ON kk.knjiga_id=k.id "
                            + "WHERE kk.knjiznica_id=" + Zaposlen.knj_id;

            if (naslov != "")
            {
                query = query + " AND k.ime=" + naslov;
            }
            if (avtor != 0)
            {
                query = query + " AND k.avtor_id=" + avtor;
            }
            if (jezik != 0)
            {
                query = query + " AND k.jezik_id=" + jezik;
            }
            if (zvrst != 0)
            {
                query = query + " AND k.vrsta_id=" + zvrst;
            }
            if (zalozba != 0)
            {
                query = query + " AND k.zalozba_id=" + zalozba;
            }

            query = query + " ORDER BY a.priimek, a.ime, k.naslov, k.id";


            List<knjiga_class> list = new List<knjiga_class>();


            if (baza_povezovanje.db_povezi() == true)
            {

                MySqlCommand cmd = new MySqlCommand(query, baza_povezovanje.connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                dataAdapter = new MySqlDataAdapter(query, baza_povezovanje.connection);


                while (dataReader.Read())
                {
                    list.Add(new knjiga_class(dataReader[0].ToString(), dataReader[1].ToString(), dataReader[2].ToString(), dataReader[3].ToString(), dataReader[4].ToString() + dataReader[5].ToString(), dataReader[6].ToString(), dataReader[7].ToString(), dataReader[8].ToString(), dataReader[9].ToString(), dataReader[10].ToString()));
                }

                dataReader.Close();
                baza_povezovanje.db_prekini_povezavo();

                return dataAdapter;
            }
            else
            {
                return null;
            }
        }


        public static void ods_obs_knjigo(int knjiga_id, int knjiznica_id, int kol)
        {
            string query = "odstrani_obs_knj";

            int izpis;

            if (baza_povezovanje.db_povezi() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, baza_povezovanje.connection);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@in_knj_id", knjiznica_id);
                cmd.Parameters.AddWithValue("@in_knjiga_id", knjiga_id);
                cmd.Parameters.AddWithValue("@in_kol", kol);

                cmd.Parameters.Add(new MySqlParameter("?out_skupno_st", MySqlDbType.VarChar));
                cmd.Parameters["?out_skupno_st"].Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();


                izpis = Convert.ToInt32(cmd.Parameters["?out_skupno_st"].Value);

                baza_povezovanje.db_prekini_povezavo();

                if (izpis == 0)
                {
                    MessageBox.Show("Uspešno odstranjenie vse knjige");
                }
                else if (izpis == -404)
                {
                    MessageBox.Show("V knjižnici je teh knjig manj od želenega števila izbrisanih!");
                }
                else if (izpis < -404)
                {
                    MessageBox.Show("V knjižnici je nekaj knjig, katerih želite odstraniti izposojenih. Odstranite lahko največ " + (Math.Abs(Convert.ToInt32(izpis))-405) + " knjig. Za izbris večih knjig, jih najprej odtrsanite pri uporabniku, ali pa počakate, da jih uporabnik vrne.");
                }
                else
                {
                    MessageBox.Show("Uspešno odstranjenih " + kol + " knjig. Skupaj jih je v knjižnici " + izpis);
                }

                return;
            }
            else
            {
                return;
            }
        }


        public static MySqlDataAdapter Select_knjige_za_izposojo()
        {
            string query = "SELECT kk.id, z.ime AS zalozba, zv.ime AS zvrst, j.ime AS jezik, a.ime, a.priimek, k.naslov, k.leto, k.opombe, k.ISBN, k.UKD "
                            + "FROM knjige k "
                            + "INNER JOIN avtorji a ON k.avtor_id = a.id "
                            + "INNER JOIN jeziki j ON k.jezik_id = j.id "
                            + "INNER JOIN zvrsti zv ON k.vrsta_id = zv.id "
                            + "INNER JOIN zalozbe z ON k.zalozba_id = z.id "
                            + "INNER JOIN knjige_knjiznice kk ON kk.knjiga_id=k.id "
                            + "WHERE kk.id IN (";

            bool prvo = true;

            foreach (int i in izposoja_shrani.izp_knj)
            {
                if (prvo == true)
                {
                    query = query + i;
                    prvo = false;
                }
                else
                {
                    query = query + ", " + i;
                }
            }

            query = query + ")";

            List<knjiga_class> list = new List<knjiga_class>();


            if (baza_povezovanje.db_povezi() == true)
            {

                MySqlCommand cmd = new MySqlCommand(query, baza_povezovanje.connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                dataAdapter = new MySqlDataAdapter(query, baza_povezovanje.connection);

                dataReader.Close();
                baza_povezovanje.db_prekini_povezavo();

                return dataAdapter;
            }
            else
            {
                return null;
            }
        }


        public static void Insert_into_izposoja(string user_id, string datum_vrn)
        {
            string query = "INSERT INTO izposojene_knjige (id, uporabnik_id, knjiga_knjiznica_id, datum_izp, datum_vrn) VALUES ";

            bool prvo = true;

            foreach (int i in izposoja_shrani.izp_knj)
            {
                if (prvo == true)
                {
                    query = query + "(null, (SELECT u.id FROM uporabniki u WHERE u.user_id=" + user_id + "), " + i + ", CURDATE(), '" + datum_vrn + "') ";
                    prvo = false;
                }
                else
                {
                    query = query + ", (null, (SELECT u.id FROM uporabniki u WHERE u.user_id=" + user_id + "), " + i + ", CURDATE(), '" + datum_vrn + "') ";
                }
            }

            try
            {
                if (baza_povezovanje.db_povezi() == true)
                {

                    MySqlCommand cmd = new MySqlCommand(query, baza_povezovanje.connection);

                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                    dataAdapter = new MySqlDataAdapter(query, baza_povezovanje.connection);

                    dataReader.Close();
                    baza_povezovanje.db_prekini_povezavo();

                    MessageBox.Show("Uspešno dodano");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ta uporabnik ne obstaja");
            }
        }


        public static List<string> Select_izposojene_vse()
        {
            string query = "SELECT id FROM knjige_knjiznice WHERE kolicina = kolicina_izp";

            List<string> knjige = new List<string>();

            if (baza_povezovanje.db_povezi() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, baza_povezovanje.connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                dataAdapter = new MySqlDataAdapter(query, baza_povezovanje.connection);

                while (dataReader.Read())
                {
                    knjige.Add(dataReader[0].ToString());
                }

                dataReader.Close();
                baza_povezovanje.db_prekini_povezavo();

                return knjige;
            }
            else
            {
                return knjige;
            }
        }


        public static bool izberi_uporabnika(int user_id)
        {
            string query = "izberi_uporabnika";

            int id;
            string ime;
            string priimek;

            if (baza_povezovanje.db_povezi() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, baza_povezovanje.connection);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@in_user_id", user_id);

                cmd.Parameters.Add(new MySqlParameter("?out_id", MySqlDbType.Int32));
                cmd.Parameters["?out_id"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add(new MySqlParameter("?out_ime", MySqlDbType.VarChar));
                cmd.Parameters["?out_ime"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add(new MySqlParameter("?out_priimek", MySqlDbType.VarChar));
                cmd.Parameters["?out_priimek"].Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();

                id = Convert.ToInt32(cmd.Parameters["?out_id"].Value);
                ime = cmd.Parameters["?out_ime"].Value.ToString();
                priimek = cmd.Parameters["?out_priimek"].Value.ToString();

                baza_povezovanje.db_prekini_povezavo();

                if (id == 0)
                {
                    MessageBox.Show("Ta uporabnik ne obstaja");

                    return false;
                }
                else
                {
                    Uporabnik.id = id;
                    Uporabnik.user_id = user_id;
                    Uporabnik.ime = ime;
                    Uporabnik.priimek = priimek;

                    return true;
                }
            }
            else
            {
                return false;
            }
        }


        public static MySqlDataAdapter Select_izposojene_knjige_od_uporabnika()
        {
            string query = "SELECT kk.id, z.ime AS zalozba, zv.ime AS zvrst, j.ime AS jezik, a.ime, a.priimek, k.naslov, k.leto, k.opombe, k.ISBN, k.UKD "
                            + "FROM knjige k "
                            + "INNER JOIN avtorji a ON k.avtor_id = a.id "
                            + "INNER JOIN jeziki j ON k.jezik_id = j.id "
                            + "INNER JOIN zvrsti zv ON k.vrsta_id = zv.id "
                            + "INNER JOIN zalozbe z ON k.zalozba_id = z.id "
                            + "INNER JOIN knjige_knjiznice kk ON kk.knjiga_id=k.id "
                            + "INNER JOIN izposojene_knjige iz ON iz.knjiga_knjiznica_id=kk.id "
                            + "INNER JOIN uporabniki u ON iz.uporabnik_id=u.id "
                            + "WHERE u.id=" + Uporabnik.id;


            if (baza_povezovanje.db_povezi() == true)
            {

                MySqlCommand cmd = new MySqlCommand(query, baza_povezovanje.connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                dataAdapter = new MySqlDataAdapter(query, baza_povezovanje.connection);

                dataReader.Close();
                baza_povezovanje.db_prekini_povezavo();

                return dataAdapter;
            }
            else
            {
                return null;
            }
        }


        public static bool predolga_izposoja(int id_knj)
        {
            string query = "predolga_izposoja";

            int izp;

            if (baza_povezovanje.db_povezi() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, baza_povezovanje.connection);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@in_kk_knjiga_id", id_knj);
                cmd.Parameters.AddWithValue("@in_user_id", Uporabnik.id);

                cmd.Parameters.Add(new MySqlParameter("?out_izp", MySqlDbType.Int32));
                cmd.Parameters["?out_izp"].Direction = ParameterDirection.Output;


                cmd.ExecuteNonQuery();

                izp = Convert.ToInt32(cmd.Parameters["?out_izp"].Value);

                baza_povezovanje.db_prekini_povezavo();

                if (izp == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }


        public static List<string> Select_izposojene_od_uporabnika(int id)
        {
            string query = "SELECT kk.id "
                            + "FROM knjige_knjiznice kk "
                            + "INNER JOIN izposojene_knjige iz ON iz.knjiga_knjiznica_id = kk.id "
                            + "INNER JOIN uporabniki u ON iz.uporabnik_id = u.id "
                            + "WHERE u.user_id = " + id;

            List<string> knjiga_id = new List<string>();

            if (baza_povezovanje.db_povezi() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, baza_povezovanje.connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                dataAdapter = new MySqlDataAdapter(query, baza_povezovanje.connection);

                while (dataReader.Read())
                {
                    knjiga_id.Add(dataReader[0].ToString());
                }

                dataReader.Close();
                baza_povezovanje.db_prekini_povezavo();

                return knjiga_id;
            }
            else
            {
                return knjiga_id;
            }
        }


        public static void Delete_izposojene_knjige(int id, List<int> za_izbris)
        {
            bool prvo=true;

            string query = "DELETE FROM izposojene_knjige "
                            + "WHERE uporabnik_id = " + id + " "
                            + "AND knjiga_knjiznica_id IN (";


            foreach (int i in za_izbris)
            {
                if (prvo == true)
                {
                    query = query + i;
                    prvo = false;
                }
                else
                {
                    query = query + ", " + i;
                }
            }

            query = query + ")";

            if (baza_povezovanje.db_povezi() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, baza_povezovanje.connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                dataAdapter = new MySqlDataAdapter(query, baza_povezovanje.connection);

                dataReader.Close();
                baza_povezovanje.db_prekini_povezavo();

                MessageBox.Show("Uspešno odstranjene knjige");
            }
        }


        public static MySqlDataAdapter Select_vse_knjige_iz_knjiznice()
        {
            string query = "SELECT kk.id, z.ime AS zalozba, zv.ime AS zvrst, j.ime AS jezik, a.ime, a.priimek, k.naslov, k.leto, k.opombe, k.ISBN, k.UKD "
                            + "FROM knjige k "
                            + "INNER JOIN avtorji a ON k.avtor_id = a.id "
                            + "INNER JOIN jeziki j ON k.jezik_id = j.id "
                            + "INNER JOIN zvrsti zv ON k.vrsta_id = zv.id "
                            + "INNER JOIN zalozbe z ON k.zalozba_id = z.id "
                            + "INNER JOIN knjige_knjiznice kk ON kk.knjiga_id=k.id";


            if (baza_povezovanje.db_povezi() == true)
            {

                MySqlCommand cmd = new MySqlCommand(query, baza_povezovanje.connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                dataAdapter = new MySqlDataAdapter(query, baza_povezovanje.connection);

                dataReader.Close();
                baza_povezovanje.db_prekini_povezavo();

                return dataAdapter;
            }
            else
            {
                return null;
            }
        }


        public static MySqlDataAdapter Select_vse_izposojene_knjige_iz_knjiznice()
        {
            string query = "SELECT u.ime AS Ime, u.priimek AS Priimkek, u.user_id AS Kartica, a.ime AS Avtor_ime, a.priimek, k.naslov, k.leto, k.ISBN, k.UKD "
                            + "FROM knjige k "
                            + "INNER JOIN avtorji a ON k.avtor_id = a.id "
                            + "INNER JOIN jeziki j ON k.jezik_id = j.id "
                            + "INNER JOIN zvrsti zv ON k.vrsta_id = zv.id "
                            + "INNER JOIN zalozbe z ON k.zalozba_id = z.id "
                            + "INNER JOIN knjige_knjiznice kk ON kk.knjiga_id=k.id "
                            + "INNER JOIN izposojene_knjige iz ON iz.knjiga_knjiznica_id=kk.id "
                            + "INNER JOIN uporabniki u ON iz.uporabnik_id=u.id "
                            + "WHERE kolicina_izp IS NOT NULL AND kolicina_izp != 0";


            if (baza_povezovanje.db_povezi() == true)
            {

                MySqlCommand cmd = new MySqlCommand(query, baza_povezovanje.connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                dataAdapter = new MySqlDataAdapter(query, baza_povezovanje.connection);

                dataReader.Close();
                baza_povezovanje.db_prekini_povezavo();

                return dataAdapter;
            }
            else
            {
                return null;
            }
        }
    }
}
