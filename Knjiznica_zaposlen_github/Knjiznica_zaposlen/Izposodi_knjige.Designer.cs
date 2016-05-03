namespace Knjiznica_zaposlen
{
    partial class Izposodi_knjige
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.izp_knj_naslov = new System.Windows.Forms.TextBox();
            this.izp_isci_knj = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.izp_knj_data = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.izp_knj_izposodi = new System.Windows.Forms.Button();
            this.izp_knj_koncaj = new System.Windows.Forms.Button();
            this.moja_knj = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.izp_knj_avtor = new System.Windows.Forms.ComboBox();
            this.izp_knj_zalozba = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.izp_knj_jezik = new System.Windows.Forms.ComboBox();
            this.izp_knj_zvrst = new System.Windows.Forms.ComboBox();
            this.izp_knj_neizposodi = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.izp_knj_data)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naslov";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(706, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Zvrst";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(706, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Jezik";
            // 
            // izp_knj_naslov
            // 
            this.izp_knj_naslov.Location = new System.Drawing.Point(83, 53);
            this.izp_knj_naslov.Name = "izp_knj_naslov";
            this.izp_knj_naslov.Size = new System.Drawing.Size(214, 20);
            this.izp_knj_naslov.TabIndex = 8;
            // 
            // izp_isci_knj
            // 
            this.izp_isci_knj.Location = new System.Drawing.Point(417, 154);
            this.izp_isci_knj.Name = "izp_isci_knj";
            this.izp_isci_knj.Size = new System.Drawing.Size(214, 23);
            this.izp_isci_knj.TabIndex = 14;
            this.izp_isci_knj.Text = "Išči";
            this.izp_isci_knj.UseVisualStyleBackColor = true;
            this.izp_isci_knj.Click += new System.EventHandler(this.izp_isci_knj_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.izp_knj_data);
            this.groupBox2.Location = new System.Drawing.Point(31, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(932, 388);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Knjige";
            // 
            // izp_knj_data
            // 
            this.izp_knj_data.AllowUserToAddRows = false;
            this.izp_knj_data.AllowUserToDeleteRows = false;
            this.izp_knj_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.izp_knj_data.Location = new System.Drawing.Point(6, 19);
            this.izp_knj_data.Name = "izp_knj_data";
            this.izp_knj_data.Size = new System.Drawing.Size(920, 363);
            this.izp_knj_data.TabIndex = 0;
            this.izp_knj_data.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.izp_knj_data_ColumnHeaderMouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Knjižnica";
            // 
            // izp_knj_izposodi
            // 
            this.izp_knj_izposodi.Location = new System.Drawing.Point(37, 590);
            this.izp_knj_izposodi.Name = "izp_knj_izposodi";
            this.izp_knj_izposodi.Size = new System.Drawing.Size(75, 23);
            this.izp_knj_izposodi.TabIndex = 18;
            this.izp_knj_izposodi.Text = "Izposodi";
            this.izp_knj_izposodi.UseVisualStyleBackColor = true;
            this.izp_knj_izposodi.Click += new System.EventHandler(this.izp_knj_izposodi_Click);
            // 
            // izp_knj_koncaj
            // 
            this.izp_knj_koncaj.Location = new System.Drawing.Point(417, 590);
            this.izp_knj_koncaj.Name = "izp_knj_koncaj";
            this.izp_knj_koncaj.Size = new System.Drawing.Size(131, 23);
            this.izp_knj_koncaj.TabIndex = 19;
            this.izp_knj_koncaj.Text = "Končaj izposojo";
            this.izp_knj_koncaj.UseVisualStyleBackColor = true;
            this.izp_knj_koncaj.Click += new System.EventHandler(this.izp_knj_koncaj_Click);
            // 
            // moja_knj
            // 
            this.moja_knj.Enabled = false;
            this.moja_knj.Location = new System.Drawing.Point(83, 99);
            this.moja_knj.Name = "moja_knj";
            this.moja_knj.Size = new System.Drawing.Size(214, 20);
            this.moja_knj.TabIndex = 31;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.izp_knj_avtor);
            this.groupBox4.Location = new System.Drawing.Point(369, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(282, 78);
            this.groupBox4.TabIndex = 39;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Avtor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Ime in priimek";
            // 
            // izp_knj_avtor
            // 
            this.izp_knj_avtor.FormattingEnabled = true;
            this.izp_knj_avtor.Location = new System.Drawing.Point(48, 41);
            this.izp_knj_avtor.Name = "izp_knj_avtor";
            this.izp_knj_avtor.Size = new System.Drawing.Size(214, 21);
            this.izp_knj_avtor.TabIndex = 41;
            // 
            // izp_knj_zalozba
            // 
            this.izp_knj_zalozba.FormattingEnabled = true;
            this.izp_knj_zalozba.Location = new System.Drawing.Point(417, 99);
            this.izp_knj_zalozba.Name = "izp_knj_zalozba";
            this.izp_knj_zalozba.Size = new System.Drawing.Size(214, 21);
            this.izp_knj_zalozba.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(366, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Založba";
            // 
            // izp_knj_jezik
            // 
            this.izp_knj_jezik.FormattingEnabled = true;
            this.izp_knj_jezik.Location = new System.Drawing.Point(743, 52);
            this.izp_knj_jezik.Name = "izp_knj_jezik";
            this.izp_knj_jezik.Size = new System.Drawing.Size(214, 21);
            this.izp_knj_jezik.TabIndex = 45;
            // 
            // izp_knj_zvrst
            // 
            this.izp_knj_zvrst.FormattingEnabled = true;
            this.izp_knj_zvrst.Location = new System.Drawing.Point(743, 98);
            this.izp_knj_zvrst.Name = "izp_knj_zvrst";
            this.izp_knj_zvrst.Size = new System.Drawing.Size(214, 21);
            this.izp_knj_zvrst.TabIndex = 46;
            // 
            // izp_knj_neizposodi
            // 
            this.izp_knj_neizposodi.Location = new System.Drawing.Point(164, 590);
            this.izp_knj_neizposodi.Name = "izp_knj_neizposodi";
            this.izp_knj_neizposodi.Size = new System.Drawing.Size(75, 23);
            this.izp_knj_neizposodi.TabIndex = 47;
            this.izp_knj_neizposodi.Text = "Ne izposodi";
            this.izp_knj_neizposodi.UseVisualStyleBackColor = true;
            this.izp_knj_neizposodi.Click += new System.EventHandler(this.izp_knj_neizposodi_Click);
            // 
            // Izposodi_knjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 625);
            this.Controls.Add(this.izp_knj_neizposodi);
            this.Controls.Add(this.izp_knj_zvrst);
            this.Controls.Add(this.izp_knj_jezik);
            this.Controls.Add(this.izp_knj_zalozba);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.moja_knj);
            this.Controls.Add(this.izp_knj_koncaj);
            this.Controls.Add(this.izp_knj_izposodi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.izp_isci_knj);
            this.Controls.Add(this.izp_knj_naslov);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Izposodi_knjige";
            this.Text = "Izposodi_knjige";
            this.Activated += new System.EventHandler(this.Izposodi_knjige_Activated);
            this.Load += new System.EventHandler(this.Izposodi_knjige_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.izp_knj_data)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox izp_knj_naslov;
        private System.Windows.Forms.Button izp_isci_knj;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView izp_knj_data;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button izp_knj_izposodi;
        private System.Windows.Forms.Button izp_knj_koncaj;
        private System.Windows.Forms.TextBox moja_knj;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox izp_knj_avtor;
        private System.Windows.Forms.ComboBox izp_knj_zalozba;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox izp_knj_jezik;
        private System.Windows.Forms.ComboBox izp_knj_zvrst;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button izp_knj_neizposodi;
    }
}