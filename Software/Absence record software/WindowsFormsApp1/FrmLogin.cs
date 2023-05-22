using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Repositories;

namespace WindowsFormsApp1 {
    public partial class FrmLogin : Form {

        public static Korisnik ulogiraniKorisnik { get; set; }
        public FrmLogin() {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e) {
            if (txtEmail.Text == "") {
                MessageBox.Show("Email nije uneseno!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (txtLozinka.Text == "") {
                MessageBox.Show("Lozinka nije unesena!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {

                ulogiraniKorisnik = KorisnikRepository.DohvatiKorisnika(txtEmail.Text);
                if (ulogiraniKorisnik != null && ulogiraniKorisnik.Lozinka == txtLozinka.Text) {
                    if(ulogiraniKorisnik.IdUloge == 1) {
                        FrmManager frm = new FrmManager(ulogiraniKorisnik);
                        Hide();
                        frm.ShowDialog();
                        Close();
                    } else {
                        FrmManager frm = new FrmManager(ulogiraniKorisnik);
                        Hide();
                        frm.ShowDialog();
                        Close();
                    }
                  
                } else {
                    MessageBox.Show("Krivi podaci!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
