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
    public partial class FrmKreirajZahtjev : Form {

        public Korisnik ulogiraniKorisnik { get; set; }
        public FrmKreirajZahtjev(Korisnik korisnik) {
            ulogiraniKorisnik = korisnik;
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void testna_Load(object sender, EventArgs e) {
            PopuniVrstu();
            OgraniciDatume();
        }

        private void OgraniciDatume() {     
            dtpPocetak.MinDate = DateTime.Today;
            dtpZavrsetak.MinDate = DateTime.Today;
        
        }

        private void PopuniVrstu() {
            var vrste = VrstaZahtjevaRepository.DohvatiVrste();
            cmbVrsta.DataSource = vrste;
        }



        private void btnPodnesi_Click(object sender, EventArgs e) {
            KreirajNoviZahtjev();
        }



        private void KreirajNoviZahtjev() {

         

            DateTime vrijemePocetka = dtpPocetak.Value;
            string formatiranoVrijemePocetka = vrijemePocetka.ToString("yyyy-MM-dd");



            DateTime vrijemeZavrsetka = dtpZavrsetak.Value;
            string formatiranoVrijemeZavrsetak = vrijemeZavrsetka.ToString("yyyy-MM-dd");
     

            var idPodnositelja = ulogiraniKorisnik;
            var idOdgovornog = KorisnikRepository.DohvatiKorisnika(2);
            var idStatusa = StatusZahtjevaRepository.DohvatiStatus(1);
            Console.WriteLine(cmbVrsta.SelectedValue);
            var idVrste = cmbVrsta.SelectedValue as VrstaZahtjeva;
            if (idVrste.IdVrsteZahtjeva == 5) {
                idStatusa = StatusZahtjevaRepository.DohvatiStatus(2);
            }
            DateTime vrijemeKreiranja = DateTime.Now;
            string formatiranoVrijemeKreiranja = vrijemeKreiranja.ToString("yyyy-MM-dd");
            Zahtjev noviZahtjev = new Zahtjev {
                VrijemeKreiranja = formatiranoVrijemeKreiranja,
                DatumPocetka = formatiranoVrijemePocetka,
                DatumZavrsetka = formatiranoVrijemeZavrsetak,
                IdPodnositelja = idPodnositelja,
                IdOdgovornog = idOdgovornog,
                IdVrsteZahtjeva = idVrste,
                IdStatusaZahtjeva = idStatusa
            };
            ZahtjevRepository.KreirajZahtjev(noviZahtjev);
        }



        private void dtpPocetak_ValueChanged(object sender, EventArgs e) {                
            if (dtpZavrsetak.Value < dtpPocetak.Value) {
                dtpZavrsetak.Value = dtpPocetak.Value;
            }
        }

        private void dtpZavrsetak_ValueChanged(object sender, EventArgs e) {
            if (dtpZavrsetak.Value < dtpPocetak.Value) {
                dtpZavrsetak.Value = dtpPocetak.Value;
            }
        }
    }
}
