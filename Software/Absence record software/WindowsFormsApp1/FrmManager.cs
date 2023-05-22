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

namespace WindowsFormsApp1 {
    public partial class FrmManager : Form {

        public Korisnik ulogiraniKorisnik { get; set; }
        public FrmManager(Korisnik korisnik) {
            InitializeComponent();
            ulogiraniKorisnik = korisnik;
        }
    }
}
