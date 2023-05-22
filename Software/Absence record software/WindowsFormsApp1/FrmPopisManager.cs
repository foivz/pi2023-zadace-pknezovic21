using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Repositories;

namespace WindowsFormsApp1 {
    public partial class FrmPopisManager : Form {

        public Korisnik ulogiraniKorisnik { get; set; }
        public FrmPopisManager(Korisnik korisnik) {
            InitializeComponent();
            ulogiraniKorisnik = korisnik;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void btnOdbij_Click(object sender, EventArgs e) {
            var zahtjev = DohvatiZahtjev();
            ZahtjevRepository.OdbijZahtjev(zahtjev.IdZahtjeva);
            DohvatiPopisZahtjeva();
        }

        private Zahtjev DohvatiZahtjev() {
            if (dgvZahtjevi.SelectedRows.Count > 0) {

                int selektiraniIndex = dgvZahtjevi.SelectedCells[0].RowIndex;
                DataGridViewRow red = dgvZahtjevi.Rows[selektiraniIndex];
                int vrijednostIda = (int)red.Cells["Broj zahtjeva"].Value;

                Zahtjev selektirani = ZahtjevRepository.DohvatiZahtjevPremaId(vrijednostIda);

                return selektirani;

           
            } else {
                MessageBox.Show("Niste izabrali zahtjev", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; 
            }
        }

        private void btnOdobri_Click(object sender, EventArgs e) {
            var zahtjev = DohvatiZahtjev();
            ZahtjevRepository.OdobriZahtjev(zahtjev.IdZahtjeva);
            DohvatiPopisZahtjeva();
        }

        private void FrmPopisManager_Load(object sender, EventArgs e) {
            DohvatiPopisZahtjeva();
        }

        private void DohvatiPopisZahtjeva() {
            var zahtjevi = ZahtjevRepository.DohvatiZahtjevePremaManageru(ulogiraniKorisnik.IdKorisnika);


            DataTable tablica = new DataTable();


            tablica.Columns.Add("Broj zahtjeva", typeof(int));
            tablica.Columns.Add("Zahtjev podnio", typeof(string));
            tablica.Columns.Add("Vrijeme kreiranja zahtjeva", typeof(DateTime));
            tablica.Columns.Add("Opis zahtjeva", typeof(string));
            tablica.Columns.Add("Odgovorna osoba", typeof(string));
            tablica.Columns.Add("Status zahtjeva", typeof(string));



            foreach (Zahtjev zahtjev in zahtjevi) {
                string datumPocetka = zahtjev.DatumPocetka;
                DateTime parsiraniDatum = DateTime.ParseExact(datumPocetka, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                string formatiranPocetak = parsiraniDatum.ToString("dd.MM.yyyy");

                string datumZavrsetka = zahtjev.DatumZavrsetka;
                DateTime parsiraniZavrsetak = DateTime.ParseExact(datumZavrsetka, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                string formatiranZavrsetak = parsiraniZavrsetak.ToString("dd.MM.yyyy");




                tablica.Rows.Add(zahtjev.IdZahtjeva, zahtjev.IdPodnositelja.Ime + " " + zahtjev.IdPodnositelja.Prezime, zahtjev.VrijemeKreiranja, zahtjev.IdVrsteZahtjeva.Naziv + " od " + formatiranPocetak + " do " + formatiranZavrsetak, zahtjev.IdOdgovornog.Ime + " " + zahtjev.IdOdgovornog.Prezime, zahtjev.IdStatusaZahtjeva.Naziv);
            }

            dgvZahtjevi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dgvZahtjevi.DataSource = tablica;

            dgvZahtjevi.Rows[0].Selected = true;
        }
    }
}
