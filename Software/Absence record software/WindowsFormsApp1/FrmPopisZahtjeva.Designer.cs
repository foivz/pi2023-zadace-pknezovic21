namespace WindowsFormsApp1 {
    partial class FrmPopisZahtjeva {
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
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.btnIzbriši = new System.Windows.Forms.Button();
            this.btnAžuriraj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZahtjevi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZahtjevi
            // 
            this.dgvZahtjevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZahtjevi.Location = new System.Drawing.Point(12, 45);
            this.dgvZahtjevi.Name = "dgvZahtjevi";
            this.dgvZahtjevi.RowTemplate.Height = 24;
            this.dgvZahtjevi.Size = new System.Drawing.Size(1038, 506);
            this.dgvZahtjevi.TabIndex = 0;
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.Location = new System.Drawing.Point(639, 558);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(133, 34);
            this.btnKreiraj.TabIndex = 1;
            this.btnKreiraj.Text = "Kreiraj zahtjev";
            this.btnKreiraj.UseVisualStyleBackColor = true;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // btnIzbriši
            // 
            this.btnIzbriši.Location = new System.Drawing.Point(917, 558);
            this.btnIzbriši.Name = "btnIzbriši";
            this.btnIzbriši.Size = new System.Drawing.Size(133, 34);
            this.btnIzbriši.TabIndex = 2;
            this.btnIzbriši.Text = "Izbriši zahtjev";
            this.btnIzbriši.UseVisualStyleBackColor = true;
            // 
            // btnAžuriraj
            // 
            this.btnAžuriraj.Location = new System.Drawing.Point(778, 557);
            this.btnAžuriraj.Name = "btnAžuriraj";
            this.btnAžuriraj.Size = new System.Drawing.Size(133, 34);
            this.btnAžuriraj.TabIndex = 3;
            this.btnAžuriraj.Text = "Ažuriraj zahtjev";
            this.btnAžuriraj.UseVisualStyleBackColor = true;
            this.btnAžuriraj.Click += new System.EventHandler(this.btnAžuriraj_Click);
            // 
            // FrmPopisZahtjeva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 604);
            this.Controls.Add(this.btnAžuriraj);
            this.Controls.Add(this.btnIzbriši);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.dgvZahtjevi);
            this.Name = "FrmPopisZahtjeva";
            this.Text = "Popis zahtjeva";
            this.Load += new System.EventHandler(this.FrmPopisZahtjeva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZahtjevi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZahtjevi;
        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.Button btnIzbriši;
        private System.Windows.Forms.Button btnAžuriraj;
    }
}