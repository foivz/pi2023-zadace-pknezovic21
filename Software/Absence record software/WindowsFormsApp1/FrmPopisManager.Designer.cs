namespace WindowsFormsApp1 {
    partial class FrmPopisManager {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dgvZahtjevi = new System.Windows.Forms.DataGridView();
            this.btnOdbij = new System.Windows.Forms.Button();
            this.btnOdobri = new System.Windows.Forms.Button();
            this.btnPocetna = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZahtjevi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZahtjevi
            // 
            this.dgvZahtjevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZahtjevi.Location = new System.Drawing.Point(12, 49);
            this.dgvZahtjevi.Name = "dgvZahtjevi";
            this.dgvZahtjevi.RowTemplate.Height = 24;
            this.dgvZahtjevi.Size = new System.Drawing.Size(1090, 536);
            this.dgvZahtjevi.TabIndex = 6;
            // 
            // btnOdbij
            // 
            this.btnOdbij.Location = new System.Drawing.Point(830, 591);
            this.btnOdbij.Name = "btnOdbij";
            this.btnOdbij.Size = new System.Drawing.Size(133, 34);
            this.btnOdbij.TabIndex = 7;
            this.btnOdbij.Text = "Odbij zahtjev";
            this.btnOdbij.UseVisualStyleBackColor = true;
            this.btnOdbij.Click += new System.EventHandler(this.btnOdbij_Click);
            // 
            // btnOdobri
            // 
            this.btnOdobri.Location = new System.Drawing.Point(969, 591);
            this.btnOdobri.Name = "btnOdobri";
            this.btnOdobri.Size = new System.Drawing.Size(133, 34);
            this.btnOdobri.TabIndex = 9;
            this.btnOdobri.Text = "Odobri zahtjev";
            this.btnOdobri.UseVisualStyleBackColor = true;
            this.btnOdobri.Click += new System.EventHandler(this.btnOdobri_Click);
            // 
            // btnPocetna
            // 
            this.btnPocetna.Location = new System.Drawing.Point(12, 591);
            this.btnPocetna.Name = "btnPocetna";
            this.btnPocetna.Size = new System.Drawing.Size(133, 34);
            this.btnPocetna.TabIndex = 10;
            this.btnPocetna.Text = "Natrag";
            this.btnPocetna.UseVisualStyleBackColor = true;
            this.btnPocetna.Click += new System.EventHandler(this.btnPocetna_Click);
            // 
            // FrmPopisManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 662);
            this.Controls.Add(this.btnPocetna);
            this.Controls.Add(this.btnOdobri);
            this.Controls.Add(this.btnOdbij);
            this.Controls.Add(this.dgvZahtjevi);
            this.Name = "FrmPopisManager";
            this.Text = "Popis zahtjeva ";
            this.Load += new System.EventHandler(this.FrmPopisManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZahtjevi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZahtjevi;
        private System.Windows.Forms.Button btnOdbij;
        private System.Windows.Forms.Button btnOdobri;
        private System.Windows.Forms.Button btnPocetna;
    }
}