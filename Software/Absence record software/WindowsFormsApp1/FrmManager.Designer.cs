namespace WindowsFormsApp1 {
    partial class FrmManager {
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
            this.btnOdjava = new System.Windows.Forms.Button();
            this.btnZahtjevi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOdjava
            // 
            this.btnOdjava.Location = new System.Drawing.Point(131, 82);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(182, 32);
            this.btnOdjava.TabIndex = 5;
            this.btnOdjava.Text = "Odjavi se";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // btnZahtjevi
            // 
            this.btnZahtjevi.Location = new System.Drawing.Point(131, 24);
            this.btnZahtjevi.Name = "btnZahtjevi";
            this.btnZahtjevi.Size = new System.Drawing.Size(182, 32);
            this.btnZahtjevi.TabIndex = 4;
            this.btnZahtjevi.Text = "Moji zahtjevi";
            this.btnZahtjevi.UseVisualStyleBackColor = true;
            this.btnZahtjevi.Click += new System.EventHandler(this.btnZahtjevi_Click);
            // 
            // FrmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 264);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.btnZahtjevi);
            this.Name = "FrmManager";
            this.Text = "Početna forma";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Button btnZahtjevi;
    }
}