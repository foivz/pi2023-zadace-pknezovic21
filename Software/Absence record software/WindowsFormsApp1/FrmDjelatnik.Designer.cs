namespace WindowsFormsApp1 {
    partial class FrmDjelatnik {
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
            this.btnZahtjevi = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnZahtjevi
            // 
            this.btnZahtjevi.Location = new System.Drawing.Point(130, 27);
            this.btnZahtjevi.Name = "btnZahtjevi";
            this.btnZahtjevi.Size = new System.Drawing.Size(182, 32);
            this.btnZahtjevi.TabIndex = 2;
            this.btnZahtjevi.Text = "Moji zahtjevi";
            this.btnZahtjevi.UseVisualStyleBackColor = true;
            this.btnZahtjevi.Click += new System.EventHandler(this.btnZahtjevi_Click);
            // 
            // btnOdjava
            // 
            this.btnOdjava.Location = new System.Drawing.Point(130, 85);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(182, 32);
            this.btnOdjava.TabIndex = 3;
            this.btnOdjava.Text = "Odjavi se";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // FrmDjelatnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 264);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.btnZahtjevi);
            this.Name = "FrmDjelatnik";
            this.Text = "Početna forma";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnZahtjevi;
        private System.Windows.Forms.Button btnOdjava;
    }
}