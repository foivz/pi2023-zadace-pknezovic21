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
            this.label1 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZahtjevi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZahtjevi
            // 
            this.dgvZahtjevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZahtjevi.Location = new System.Drawing.Point(12, 45);
            this.dgvZahtjevi.Name = "dgvZahtjevi";
            this.dgvZahtjevi.RowTemplate.Height = 24;
            this.dgvZahtjevi.Size = new System.Drawing.Size(1090, 536);
            this.dgvZahtjevi.TabIndex = 0;
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.Location = new System.Drawing.Point(691, 587);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(133, 34);
            this.btnKreiraj.TabIndex = 1;
            this.btnKreiraj.Text = "Kreiraj zahtjev";
            this.btnKreiraj.UseVisualStyleBackColor = true;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // btnIzbriši
            // 
            this.btnIzbriši.Location = new System.Drawing.Point(969, 587);
            this.btnIzbriši.Name = "btnIzbriši";
            this.btnIzbriši.Size = new System.Drawing.Size(133, 34);
            this.btnIzbriši.TabIndex = 2;
            this.btnIzbriši.Text = "Izbriši zahtjev";
            this.btnIzbriši.UseVisualStyleBackColor = true;
            this.btnIzbriši.Click += new System.EventHandler(this.btnIzbriši_Click);
            // 
            // btnAžuriraj
            // 
            this.btnAžuriraj.Location = new System.Drawing.Point(830, 587);
            this.btnAžuriraj.Name = "btnAžuriraj";
            this.btnAžuriraj.Size = new System.Drawing.Size(133, 34);
            this.btnAžuriraj.TabIndex = 3;
            this.btnAžuriraj.Text = "Ažuriraj zahtjev";
            this.btnAžuriraj.UseVisualStyleBackColor = true;
            this.btnAžuriraj.Click += new System.EventHandler(this.btnAžuriraj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Prikaži prema opisu zahtjeva: ";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(203, 13);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(190, 22);
            this.txtOpis.TabIndex = 5;
            this.txtOpis.TextChanged += new System.EventHandler(this.txtOpis_TextChanged);
            // 
            // FrmPopisZahtjeva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 633);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAžuriraj);
            this.Controls.Add(this.btnIzbriši);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.dgvZahtjevi);
            this.Name = "FrmPopisZahtjeva";
            this.Text = "Popis zahtjeva";
            this.Load += new System.EventHandler(this.FrmPopisZahtjeva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZahtjevi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZahtjevi;
        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.Button btnIzbriši;
        private System.Windows.Forms.Button btnAžuriraj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOpis;
    }
}