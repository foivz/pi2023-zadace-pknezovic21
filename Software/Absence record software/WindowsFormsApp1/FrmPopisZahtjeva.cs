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
using System.Xml.Linq;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Repositories;

namespace WindowsFormsApp1 {
    public partial class FrmPopisZahtjeva : Form {
        public Korisnik ulogiraniKorisnik { get; set; }
        public FrmPopisZahtjeva(Korisnik korisnik) {
            InitializeComponent();
            ulogiraniKorisnik = korisnik;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void FrmPopisZahtjeva_Load(object sender, EventArgs e) {
            OsvjeziZahtjeve();
        }



        private void OsvjeziZahtjeve() {
            
            var zahtjevi = ZahtjevRepository.DohvatiZahtjevePremaKorisniku(ulogiraniKorisnik.IdKorisnika);

       
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




                tablica.Rows.Add(zahtjev.IdZahtjeva+".", zahtjev.IdPodnositelja.Ime +" "+ zahtjev.IdPodnositelja.Prezime, zahtjev.VrijemeKreiranja, zahtjev.IdVrsteZahtjeva.Naziv + " od "+ formatiranPocetak+" do "+ formatiranZavrsetak, zahtjev.IdOdgovornog.Ime + " " + zahtjev.IdOdgovornog.Prezime, zahtjev.IdStatusaZahtjeva.Naziv);
            }

            dgvZahtjevi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvZahtjevi.DataSource = tablica;
        }

        private void btnKreiraj_Click(object sender, EventArgs e) {
            FrmKreirajZahtjev form = new FrmKreirajZahtjev(ulogiraniKorisnik);
            Hide();
            form.ShowDialog();
            Close();

          
        }

     
    }
}
