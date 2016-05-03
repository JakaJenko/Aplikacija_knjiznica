namespace Knjiznica_zaposlen
{
    partial class Izpis_podatkov
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
            this.izpisi_vse = new System.Windows.Forms.Button();
            this.izpisi_izp = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // izpisi_vse
            // 
            this.izpisi_vse.Location = new System.Drawing.Point(80, 34);
            this.izpisi_vse.Name = "izpisi_vse";
            this.izpisi_vse.Size = new System.Drawing.Size(110, 70);
            this.izpisi_vse.TabIndex = 0;
            this.izpisi_vse.Text = "Izpiši vse knjige, ki so v knjižnici";
            this.izpisi_vse.UseVisualStyleBackColor = true;
            this.izpisi_vse.Click += new System.EventHandler(this.izpisi_vse_Click);
            // 
            // izpisi_izp
            // 
            this.izpisi_izp.Location = new System.Drawing.Point(80, 132);
            this.izpisi_izp.Name = "izpisi_izp";
            this.izpisi_izp.Size = new System.Drawing.Size(110, 85);
            this.izpisi_izp.TabIndex = 1;
            this.izpisi_izp.Text = "Izpiši vse izposojene knjige in osebe, ki so jih izposodile";
            this.izpisi_izp.UseVisualStyleBackColor = true;
            this.izpisi_izp.Click += new System.EventHandler(this.izpisi_izp_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(263, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(533, 183);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.Visible = false;
            // 
            // Izpis_podatkov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 324);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.izpisi_izp);
            this.Controls.Add(this.izpisi_vse);
            this.Name = "Izpis_podatkov";
            this.Text = "Izpis_podatkov";
            this.Load += new System.EventHandler(this.Izpis_podatkov_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button izpisi_vse;
        private System.Windows.Forms.Button izpisi_izp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}