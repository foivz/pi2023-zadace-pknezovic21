namespace WindowsFormsApp1 {
    partial class FrmKreirajZahtjev {
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
            this.dtpPocetak = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpZavrsetak = new System.Windows.Forms.DateTimePicker();
            this.cmbVrsta = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPodnesi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpPocetak
            // 
            this.dtpPocetak.Location = new System.Drawing.Point(43, 49);
            this.dtpPocetak.Name = "dtpPocetak";
            this.dtpPocetak.Size = new System.Drawing.Size(200, 22);
            this.dtpPocetak.TabIndex = 0;
            this.dtpPocetak.ValueChanged += new System.EventHandler(this.dtpPocetak_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Datum početka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Datum završetka";
            // 
            // dtpZavrsetak
            // 
            this.dtpZavrsetak.Location = new System.Drawing.Point(265, 49);
            this.dtpZavrsetak.Name = "dtpZavrsetak";
            this.dtpZavrsetak.Size = new System.Drawing.Size(200, 22);
            this.dtpZavrsetak.TabIndex = 2;
            this.dtpZavrsetak.ValueChanged += new System.EventHandler(this.dtpZavrsetak_ValueChanged);
            // 
            // cmbVrsta
            // 
            this.cmbVrsta.FormattingEnabled = true;
            this.cmbVrsta.Location = new System.Drawing.Point(498, 46);
            this.cmbVrsta.Name = "cmbVrsta";
            this.cmbVrsta.Size = new System.Drawing.Size(121, 24);
            this.cmbVrsta.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(504, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vrsta zahtjeva";
            // 
            // btnPodnesi
            // 
            this.btnPodnesi.Location = new System.Drawing.Point(498, 110);
            this.btnPodnesi.Name = "btnPodnesi";
            this.btnPodnesi.Size = new System.Drawing.Size(121, 23);
            this.btnPodnesi.TabIndex = 6;
            this.btnPodnesi.Text = "Podnesi zahtjev";
            this.btnPodnesi.UseVisualStyleBackColor = true;
            this.btnPodnesi.Click += new System.EventHandler(this.btnPodnesi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(344, 110);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(121, 23);
            this.btnOdustani.TabIndex = 7;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            // 
            // FrmKreirajZahtjev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 145);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPodnesi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbVrsta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpZavrsetak);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpPocetak);
            this.Name = "FrmKreirajZahtjev";
            this.Text = "Kreiraj novi zahtjev";
            this.Load += new System.EventHandler(this.testna_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpPocetak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpZavrsetak;
        private System.Windows.Forms.ComboBox cmbVrsta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPodnesi;
        private System.Windows.Forms.Button btnOdustani;
    }
}