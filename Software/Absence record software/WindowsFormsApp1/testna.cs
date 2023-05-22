using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Repositories;

namespace WindowsFormsApp1 {
    public partial class testna : Form {
        public testna() {
            InitializeComponent();
        }

        private void testna_Load(object sender, EventArgs e) {
            var zahtjevi = ZahtjevRepository.DohvatiZahtjeve();
            dataGridView1.DataSource = zahtjevi;
        }
    }
}
