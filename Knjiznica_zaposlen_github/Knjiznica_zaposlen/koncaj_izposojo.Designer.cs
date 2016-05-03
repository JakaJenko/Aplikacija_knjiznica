namespace Knjiznica_zaposlen
{
    partial class koncaj_izposojo
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
            this.kon_izp_data = new System.Windows.Forms.DataGridView();
            this.izp_knj_potrdi = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kon_izp_odstrani_knj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.user_card_nuber = new System.Windows.Forms.TextBox();
            this.vrni_do = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kon_izp_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // kon_izp_data
            // 
            this.kon_izp_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kon_izp_data.Location = new System.Drawing.Point(12, 12);
            this.kon_izp_data.Name = "kon_izp_data";
            this.kon_izp_data.Size = new System.Drawing.Size(976, 332);
            this.kon_izp_data.TabIndex = 1;
            // 
            // izp_knj_potrdi
            // 
            this.izp_knj_potrdi.Location = new System.Drawing.Point(240, 373);
            this.izp_knj_potrdi.Name = "izp_knj_potrdi";
            this.izp_knj_potrdi.Size = new System.Drawing.Size(75, 23);
            this.izp_knj_potrdi.TabIndex = 2;
            this.izp_knj_potrdi.Text = "Potrdi";
            this.izp_knj_potrdi.UseVisualStyleBackColor = true;
            this.izp_knj_potrdi.Click += new System.EventHandler(this.izp_knj_potrdi_Click);
            // 
            // kon_izp_odstrani_knj
            // 
            this.kon_izp_odstrani_knj.Location = new System.Drawing.Point(390, 373);
            this.kon_izp_odstrani_knj.Name = "kon_izp_odstrani_knj";
            this.kon_izp_odstrani_knj.Size = new System.Drawing.Size(93, 23);
            this.kon_izp_odstrani_knj.TabIndex = 3;
            this.kon_izp_odstrani_knj.Text = "Odstrani knjigo";
            this.kon_izp_odstrani_knj.UseVisualStyleBackColor = true;
            this.kon_izp_odstrani_knj.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Številka kartice:";
            // 
            // user_card_nuber
            // 
            this.user_card_nuber.Location = new System.Drawing.Point(101, 350);
            this.user_card_nuber.Name = "user_card_nuber";
            this.user_card_nuber.Size = new System.Drawing.Size(100, 20);
            this.user_card_nuber.TabIndex = 5;
            // 
            // vrni_do
            // 
            this.vrni_do.CustomFormat = "yyyy.MM.dd";
            this.vrni_do.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.vrni_do.Location = new System.Drawing.Point(101, 376);
            this.vrni_do.Name = "vrni_do";
            this.vrni_do.Size = new System.Drawing.Size(100, 20);
            this.vrni_do.TabIndex = 6;
            this.vrni_do.Value = new System.DateTime(2016, 4, 24, 18, 53, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Izposojeno do:";
            // 
            // koncaj_izposojo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 407);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vrni_do);
            this.Controls.Add(this.user_card_nuber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kon_izp_odstrani_knj);
            this.Controls.Add(this.izp_knj_potrdi);
            this.Controls.Add(this.kon_izp_data);
            this.Name = "koncaj_izposojo";
            this.Text = "koncaj_izposojo";
            this.Load += new System.EventHandler(this.koncaj_izposojo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kon_izp_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView kon_izp_data;
        private System.Windows.Forms.Button izp_knj_potrdi;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button kon_izp_odstrani_knj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox user_card_nuber;
        private System.Windows.Forms.DateTimePicker vrni_do;
        private System.Windows.Forms.Label label2;
    }
}