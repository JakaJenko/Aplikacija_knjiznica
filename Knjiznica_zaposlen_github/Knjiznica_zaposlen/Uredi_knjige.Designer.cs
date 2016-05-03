namespace Knjiznica_zaposlen
{
    partial class Uredi_knjige
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dodaj_avtorja = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dodaj_avtor_ime = new System.Windows.Forms.TextBox();
            this.dodaj_avtor_priimek = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dodaj_nov_knj_zalozba = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.dodaj_nov_knj_leto = new System.Windows.Forms.TextBox();
            this.dodaj_nov_knj_opombe = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.dodaj_nov_knj_UKD = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.dodaj_nov_knj_ISBN = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dodaj_nov_knj_zvrst = new System.Windows.Forms.ComboBox();
            this.dodaj_nov_knj_jezik = new System.Windows.Forms.ComboBox();
            this.dodaj_novo_knjigo = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dodaj_nov_knj_avtor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dodaj_nov_knj_naslov = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dodaj_knj = new System.Windows.Forms.GroupBox();
            this.dodaj_obs_knj_krat = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dodaj_obs_knj = new System.Windows.Forms.Button();
            this.dodaj_obs_knj_data = new System.Windows.Forms.DataGridView();
            this.odstrani_knj = new System.Windows.Forms.GroupBox();
            this.ods_vse_obs_knj = new System.Windows.Forms.Button();
            this.ods_ons_knj_krat = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ods_obs_knj = new System.Windows.Forms.Button();
            this.ods_obs_knj_data = new System.Windows.Forms.DataGridView();
            this.izvedi = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.isci_knjige = new System.Windows.Forms.Button();
            this.obs_knj_naslov = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.moja_knj2 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.obs_knj_avtor = new System.Windows.Forms.ComboBox();
            this.obs_knj_jezik = new System.Windows.Forms.ComboBox();
            this.obs_knj_zvrst = new System.Windows.Forms.ComboBox();
            this.obs_knj_zalozba = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.dodaj_knj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dodaj_obs_knj_data)).BeginInit();
            this.odstrani_knj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ods_obs_knj_data)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dodaj_avtorja);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dodaj_avtor_ime);
            this.groupBox1.Controls.Add(this.dodaj_avtor_priimek);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 152);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj avtorja";
            // 
            // dodaj_avtorja
            // 
            this.dodaj_avtorja.Location = new System.Drawing.Point(61, 114);
            this.dodaj_avtorja.Name = "dodaj_avtorja";
            this.dodaj_avtorja.Size = new System.Drawing.Size(75, 23);
            this.dodaj_avtorja.TabIndex = 15;
            this.dodaj_avtorja.Text = "Dodaj avtorja";
            this.dodaj_avtorja.UseVisualStyleBackColor = true;
            this.dodaj_avtorja.Click += new System.EventHandler(this.dodaj_avtorja_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Priimek";
            // 
            // dodaj_avtor_ime
            // 
            this.dodaj_avtor_ime.Location = new System.Drawing.Point(61, 32);
            this.dodaj_avtor_ime.Name = "dodaj_avtor_ime";
            this.dodaj_avtor_ime.Size = new System.Drawing.Size(214, 20);
            this.dodaj_avtor_ime.TabIndex = 13;
            // 
            // dodaj_avtor_priimek
            // 
            this.dodaj_avtor_priimek.Location = new System.Drawing.Point(61, 75);
            this.dodaj_avtor_priimek.Name = "dodaj_avtor_priimek";
            this.dodaj_avtor_priimek.Size = new System.Drawing.Size(214, 20);
            this.dodaj_avtor_priimek.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dodaj_nov_knj_zalozba);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.dodaj_nov_knj_leto);
            this.groupBox2.Controls.Add(this.dodaj_nov_knj_opombe);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.dodaj_nov_knj_UKD);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.dodaj_nov_knj_ISBN);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.dodaj_nov_knj_zvrst);
            this.groupBox2.Controls.Add(this.dodaj_nov_knj_jezik);
            this.groupBox2.Controls.Add(this.dodaj_novo_knjigo);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dodaj_nov_knj_naslov);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 454);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dodaj novo knjigo";
            // 
            // dodaj_nov_knj_zalozba
            // 
            this.dodaj_nov_knj_zalozba.FormattingEnabled = true;
            this.dodaj_nov_knj_zalozba.Location = new System.Drawing.Point(70, 135);
            this.dodaj_nov_knj_zalozba.Name = "dodaj_nov_knj_zalozba";
            this.dodaj_nov_knj_zalozba.Size = new System.Drawing.Size(214, 21);
            this.dodaj_nov_knj_zalozba.TabIndex = 40;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(19, 138);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(45, 13);
            this.label20.TabIndex = 39;
            this.label20.Text = "Založba";
            // 
            // dodaj_nov_knj_leto
            // 
            this.dodaj_nov_knj_leto.Location = new System.Drawing.Point(70, 109);
            this.dodaj_nov_knj_leto.Name = "dodaj_nov_knj_leto";
            this.dodaj_nov_knj_leto.Size = new System.Drawing.Size(214, 20);
            this.dodaj_nov_knj_leto.TabIndex = 38;
            // 
            // dodaj_nov_knj_opombe
            // 
            this.dodaj_nov_knj_opombe.Location = new System.Drawing.Point(70, 162);
            this.dodaj_nov_knj_opombe.Multiline = true;
            this.dodaj_nov_knj_opombe.Name = "dodaj_nov_knj_opombe";
            this.dodaj_nov_knj_opombe.Size = new System.Drawing.Size(214, 93);
            this.dodaj_nov_knj_opombe.TabIndex = 37;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(17, 162);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 13);
            this.label19.TabIndex = 36;
            this.label19.Text = "Opombe";
            // 
            // dodaj_nov_knj_UKD
            // 
            this.dodaj_nov_knj_UKD.Location = new System.Drawing.Point(70, 287);
            this.dodaj_nov_knj_UKD.Name = "dodaj_nov_knj_UKD";
            this.dodaj_nov_knj_UKD.Size = new System.Drawing.Size(214, 20);
            this.dodaj_nov_knj_UKD.TabIndex = 35;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(34, 290);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(30, 13);
            this.label18.TabIndex = 34;
            this.label18.Text = "UKD";
            // 
            // dodaj_nov_knj_ISBN
            // 
            this.dodaj_nov_knj_ISBN.Location = new System.Drawing.Point(70, 261);
            this.dodaj_nov_knj_ISBN.Name = "dodaj_nov_knj_ISBN";
            this.dodaj_nov_knj_ISBN.Size = new System.Drawing.Size(214, 20);
            this.dodaj_nov_knj_ISBN.TabIndex = 33;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(31, 264);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 13);
            this.label17.TabIndex = 32;
            this.label17.Text = "ISBN";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 112);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Leto izdaje";
            // 
            // dodaj_nov_knj_zvrst
            // 
            this.dodaj_nov_knj_zvrst.FormattingEnabled = true;
            this.dodaj_nov_knj_zvrst.Location = new System.Drawing.Point(70, 82);
            this.dodaj_nov_knj_zvrst.Name = "dodaj_nov_knj_zvrst";
            this.dodaj_nov_knj_zvrst.Size = new System.Drawing.Size(214, 21);
            this.dodaj_nov_knj_zvrst.TabIndex = 29;
            // 
            // dodaj_nov_knj_jezik
            // 
            this.dodaj_nov_knj_jezik.FormattingEnabled = true;
            this.dodaj_nov_knj_jezik.Location = new System.Drawing.Point(70, 55);
            this.dodaj_nov_knj_jezik.Name = "dodaj_nov_knj_jezik";
            this.dodaj_nov_knj_jezik.Size = new System.Drawing.Size(214, 21);
            this.dodaj_nov_knj_jezik.TabIndex = 28;
            // 
            // dodaj_novo_knjigo
            // 
            this.dodaj_novo_knjigo.Location = new System.Drawing.Point(61, 425);
            this.dodaj_novo_knjigo.Name = "dodaj_novo_knjigo";
            this.dodaj_novo_knjigo.Size = new System.Drawing.Size(75, 23);
            this.dodaj_novo_knjigo.TabIndex = 16;
            this.dodaj_novo_knjigo.Text = "Dodaj knjigo";
            this.dodaj_novo_knjigo.UseVisualStyleBackColor = true;
            this.dodaj_novo_knjigo.Click += new System.EventHandler(this.dodaj_novo_knjigo_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.dodaj_nov_knj_avtor);
            this.groupBox3.Location = new System.Drawing.Point(17, 327);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(282, 78);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Avtor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Ime in priimek";
            // 
            // dodaj_nov_knj_avtor
            // 
            this.dodaj_nov_knj_avtor.FormattingEnabled = true;
            this.dodaj_nov_knj_avtor.Location = new System.Drawing.Point(53, 38);
            this.dodaj_nov_knj_avtor.Name = "dodaj_nov_knj_avtor";
            this.dodaj_nov_knj_avtor.Size = new System.Drawing.Size(214, 21);
            this.dodaj_nov_knj_avtor.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Jezik";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Zvrst";
            // 
            // dodaj_nov_knj_naslov
            // 
            this.dodaj_nov_knj_naslov.Location = new System.Drawing.Point(70, 29);
            this.dodaj_nov_knj_naslov.Name = "dodaj_nov_knj_naslov";
            this.dodaj_nov_knj_naslov.Size = new System.Drawing.Size(214, 20);
            this.dodaj_nov_knj_naslov.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Naslov";
            // 
            // dodaj_knj
            // 
            this.dodaj_knj.Controls.Add(this.dodaj_obs_knj_krat);
            this.dodaj_knj.Controls.Add(this.label11);
            this.dodaj_knj.Controls.Add(this.dodaj_obs_knj);
            this.dodaj_knj.Controls.Add(this.dodaj_obs_knj_data);
            this.dodaj_knj.Location = new System.Drawing.Point(376, 225);
            this.dodaj_knj.Name = "dodaj_knj";
            this.dodaj_knj.Size = new System.Drawing.Size(761, 399);
            this.dodaj_knj.TabIndex = 2;
            this.dodaj_knj.TabStop = false;
            this.dodaj_knj.Text = "Dodaj obstoječo knjigo";
            this.dodaj_knj.Visible = false;
            // 
            // dodaj_obs_knj_krat
            // 
            this.dodaj_obs_knj_krat.Location = new System.Drawing.Point(88, 371);
            this.dodaj_obs_knj_krat.Name = "dodaj_obs_knj_krat";
            this.dodaj_obs_knj_krat.Size = new System.Drawing.Size(24, 20);
            this.dodaj_obs_knj_krat.TabIndex = 3;
            this.dodaj_obs_knj_krat.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(118, 375);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "krat";
            // 
            // dodaj_obs_knj
            // 
            this.dodaj_obs_knj.Location = new System.Drawing.Point(7, 369);
            this.dodaj_obs_knj.Name = "dodaj_obs_knj";
            this.dodaj_obs_knj.Size = new System.Drawing.Size(75, 23);
            this.dodaj_obs_knj.TabIndex = 1;
            this.dodaj_obs_knj.Text = "Dodaj";
            this.dodaj_obs_knj.UseVisualStyleBackColor = true;
            this.dodaj_obs_knj.Click += new System.EventHandler(this.dodaj_obs_knj_Click);
            // 
            // dodaj_obs_knj_data
            // 
            this.dodaj_obs_knj_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dodaj_obs_knj_data.Location = new System.Drawing.Point(7, 20);
            this.dodaj_obs_knj_data.Name = "dodaj_obs_knj_data";
            this.dodaj_obs_knj_data.Size = new System.Drawing.Size(748, 341);
            this.dodaj_obs_knj_data.TabIndex = 0;
            // 
            // odstrani_knj
            // 
            this.odstrani_knj.Controls.Add(this.ods_vse_obs_knj);
            this.odstrani_knj.Controls.Add(this.ods_ons_knj_krat);
            this.odstrani_knj.Controls.Add(this.label12);
            this.odstrani_knj.Controls.Add(this.ods_obs_knj);
            this.odstrani_knj.Controls.Add(this.ods_obs_knj_data);
            this.odstrani_knj.Location = new System.Drawing.Point(376, 225);
            this.odstrani_knj.Name = "odstrani_knj";
            this.odstrani_knj.Size = new System.Drawing.Size(761, 399);
            this.odstrani_knj.TabIndex = 3;
            this.odstrani_knj.TabStop = false;
            this.odstrani_knj.Text = "Odstrani knjigo";
            this.odstrani_knj.Visible = false;
            // 
            // ods_vse_obs_knj
            // 
            this.ods_vse_obs_knj.Location = new System.Drawing.Point(222, 369);
            this.ods_vse_obs_knj.Name = "ods_vse_obs_knj";
            this.ods_vse_obs_knj.Size = new System.Drawing.Size(75, 23);
            this.ods_vse_obs_knj.TabIndex = 8;
            this.ods_vse_obs_knj.Text = "Odstrani vse";
            this.ods_vse_obs_knj.UseVisualStyleBackColor = true;
            this.ods_vse_obs_knj.Click += new System.EventHandler(this.ods_vse_obs_knj_Click);
            // 
            // ods_ons_knj_krat
            // 
            this.ods_ons_knj_krat.Location = new System.Drawing.Point(87, 370);
            this.ods_ons_knj_krat.Name = "ods_ons_knj_krat";
            this.ods_ons_knj_krat.Size = new System.Drawing.Size(24, 20);
            this.ods_ons_knj_krat.TabIndex = 7;
            this.ods_ons_knj_krat.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(117, 374);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "krat";
            // 
            // ods_obs_knj
            // 
            this.ods_obs_knj.Location = new System.Drawing.Point(6, 368);
            this.ods_obs_knj.Name = "ods_obs_knj";
            this.ods_obs_knj.Size = new System.Drawing.Size(75, 23);
            this.ods_obs_knj.TabIndex = 5;
            this.ods_obs_knj.Text = "Odstrani";
            this.ods_obs_knj.UseVisualStyleBackColor = true;
            this.ods_obs_knj.Click += new System.EventHandler(this.ods_obs_knj_Click);
            // 
            // ods_obs_knj_data
            // 
            this.ods_obs_knj_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ods_obs_knj_data.Location = new System.Drawing.Point(6, 19);
            this.ods_obs_knj_data.Name = "ods_obs_knj_data";
            this.ods_obs_knj_data.Size = new System.Drawing.Size(748, 341);
            this.ods_obs_knj_data.TabIndex = 4;
            // 
            // izvedi
            // 
            this.izvedi.FormattingEnabled = true;
            this.izvedi.Items.AddRange(new object[] {
            "Dodaj obstoječo knjigo",
            "Odstrani obstoječo knjigo"});
            this.izvedi.Location = new System.Drawing.Point(443, 183);
            this.izvedi.Name = "izvedi";
            this.izvedi.Size = new System.Drawing.Size(214, 21);
            this.izvedi.TabIndex = 27;
            this.izvedi.SelectedIndexChanged += new System.EventHandler(this.izvedi_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(402, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Izvedi";
            // 
            // isci_knjige
            // 
            this.isci_knjige.Location = new System.Drawing.Point(842, 186);
            this.isci_knjige.Name = "isci_knjige";
            this.isci_knjige.Size = new System.Drawing.Size(214, 23);
            this.isci_knjige.TabIndex = 35;
            this.isci_knjige.Text = "Išči";
            this.isci_knjige.UseVisualStyleBackColor = true;
            this.isci_knjige.Click += new System.EventHandler(this.isci_knjige_Click);
            // 
            // obs_knj_naslov
            // 
            this.obs_knj_naslov.Location = new System.Drawing.Point(443, 9);
            this.obs_knj_naslov.Name = "obs_knj_naslov";
            this.obs_knj_naslov.Size = new System.Drawing.Size(214, 20);
            this.obs_knj_naslov.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(805, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Jezik";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(805, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Zvrst";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(397, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "Naslov";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(388, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Knjižnica";
            // 
            // moja_knj2
            // 
            this.moja_knj2.Enabled = false;
            this.moja_knj2.Location = new System.Drawing.Point(443, 53);
            this.moja_knj2.Name = "moja_knj2";
            this.moja_knj2.Size = new System.Drawing.Size(214, 20);
            this.moja_knj2.TabIndex = 30;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.obs_knj_avtor);
            this.groupBox4.Location = new System.Drawing.Point(391, 90);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(282, 78);
            this.groupBox4.TabIndex = 38;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Avtor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Ime in priimek";
            // 
            // obs_knj_avtor
            // 
            this.obs_knj_avtor.FormattingEnabled = true;
            this.obs_knj_avtor.Location = new System.Drawing.Point(53, 38);
            this.obs_knj_avtor.Name = "obs_knj_avtor";
            this.obs_knj_avtor.Size = new System.Drawing.Size(214, 21);
            this.obs_knj_avtor.TabIndex = 41;
            // 
            // obs_knj_jezik
            // 
            this.obs_knj_jezik.FormattingEnabled = true;
            this.obs_knj_jezik.Location = new System.Drawing.Point(842, 8);
            this.obs_knj_jezik.Name = "obs_knj_jezik";
            this.obs_knj_jezik.Size = new System.Drawing.Size(214, 21);
            this.obs_knj_jezik.TabIndex = 41;
            // 
            // obs_knj_zvrst
            // 
            this.obs_knj_zvrst.FormattingEnabled = true;
            this.obs_knj_zvrst.Location = new System.Drawing.Point(842, 52);
            this.obs_knj_zvrst.Name = "obs_knj_zvrst";
            this.obs_knj_zvrst.Size = new System.Drawing.Size(214, 21);
            this.obs_knj_zvrst.TabIndex = 42;
            // 
            // obs_knj_zalozba
            // 
            this.obs_knj_zalozba.FormattingEnabled = true;
            this.obs_knj_zalozba.Location = new System.Drawing.Point(842, 109);
            this.obs_knj_zalozba.Name = "obs_knj_zalozba";
            this.obs_knj_zalozba.Size = new System.Drawing.Size(214, 21);
            this.obs_knj_zalozba.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(791, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Založba";
            // 
            // Uredi_knjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 635);
            this.Controls.Add(this.obs_knj_zalozba);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.obs_knj_zvrst);
            this.Controls.Add(this.obs_knj_jezik);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.moja_knj2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.izvedi);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.isci_knjige);
            this.Controls.Add(this.odstrani_knj);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.obs_knj_naslov);
            this.Controls.Add(this.dodaj_knj);
            this.Name = "Uredi_knjige";
            this.Text = "Uredi_knjige";
            this.Load += new System.EventHandler(this.Uredi_knjige_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.dodaj_knj.ResumeLayout(false);
            this.dodaj_knj.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dodaj_obs_knj_data)).EndInit();
            this.odstrani_knj.ResumeLayout(false);
            this.odstrani_knj.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ods_obs_knj_data)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dodaj_avtor_ime;
        private System.Windows.Forms.TextBox dodaj_avtor_priimek;
        private System.Windows.Forms.TextBox dodaj_nov_knj_naslov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button dodaj_avtorja;
        private System.Windows.Forms.Button dodaj_novo_knjigo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox dodaj_knj;
        private System.Windows.Forms.GroupBox odstrani_knj;
        private System.Windows.Forms.ComboBox izvedi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button isci_knjige;
        private System.Windows.Forms.TextBox obs_knj_naslov;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox dodaj_nov_knj_zvrst;
        private System.Windows.Forms.ComboBox dodaj_nov_knj_jezik;
        private System.Windows.Forms.TextBox moja_knj2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox dodaj_nov_knj_UKD;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox dodaj_nov_knj_ISBN;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox dodaj_nov_knj_opombe;
        private System.Windows.Forms.TextBox dodaj_nov_knj_leto;
        private System.Windows.Forms.ComboBox dodaj_nov_knj_zalozba;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox dodaj_nov_knj_avtor;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox obs_knj_avtor;
        private System.Windows.Forms.ComboBox obs_knj_jezik;
        private System.Windows.Forms.ComboBox obs_knj_zvrst;
        private System.Windows.Forms.ComboBox obs_knj_zalozba;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox dodaj_obs_knj_krat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button dodaj_obs_knj;
        private System.Windows.Forms.DataGridView dodaj_obs_knj_data;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox ods_ons_knj_krat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button ods_obs_knj;
        private System.Windows.Forms.DataGridView ods_obs_knj_data;
        private System.Windows.Forms.Button ods_vse_obs_knj;
    }
}