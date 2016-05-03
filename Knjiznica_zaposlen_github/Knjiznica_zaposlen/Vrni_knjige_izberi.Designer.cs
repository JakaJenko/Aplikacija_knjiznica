namespace Knjiznica_zaposlen
{
    partial class Vrni_knjige_izberi
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
            this.knj_vrn_data = new System.Windows.Forms.DataGridView();
            this.vrni_knj = new System.Windows.Forms.Button();
            this.vrni_knj_koncaj = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.knj_vrn_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // knj_vrn_data
            // 
            this.knj_vrn_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.knj_vrn_data.Location = new System.Drawing.Point(12, 12);
            this.knj_vrn_data.Name = "knj_vrn_data";
            this.knj_vrn_data.Size = new System.Drawing.Size(976, 332);
            this.knj_vrn_data.TabIndex = 0;
            // 
            // vrni_knj
            // 
            this.vrni_knj.Location = new System.Drawing.Point(13, 351);
            this.vrni_knj.Name = "vrni_knj";
            this.vrni_knj.Size = new System.Drawing.Size(75, 23);
            this.vrni_knj.TabIndex = 1;
            this.vrni_knj.Text = "Vrni";
            this.vrni_knj.UseVisualStyleBackColor = true;
            this.vrni_knj.Click += new System.EventHandler(this.button1_Click);
            // 
            // vrni_knj_koncaj
            // 
            this.vrni_knj_koncaj.Location = new System.Drawing.Point(133, 351);
            this.vrni_knj_koncaj.Name = "vrni_knj_koncaj";
            this.vrni_knj_koncaj.Size = new System.Drawing.Size(120, 23);
            this.vrni_knj_koncaj.TabIndex = 2;
            this.vrni_knj_koncaj.Text = "Končaj vračanje";
            this.vrni_knj_koncaj.UseVisualStyleBackColor = true;
            this.vrni_knj_koncaj.Click += new System.EventHandler(this.vrni_knj_koncaj_Click);
            // 
            // Vrni_knjige_izberi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 396);
            this.Controls.Add(this.vrni_knj_koncaj);
            this.Controls.Add(this.vrni_knj);
            this.Controls.Add(this.knj_vrn_data);
            this.Name = "Vrni_knjige_izberi";
            this.Text = "Vrni_knjige_izberi";
            this.Load += new System.EventHandler(this.Vrni_knjige_izberi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.knj_vrn_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView knj_vrn_data;
        private System.Windows.Forms.Button vrni_knj;
        private System.Windows.Forms.Button vrni_knj_koncaj;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}