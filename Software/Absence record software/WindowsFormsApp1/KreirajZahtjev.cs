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
    public partial class KreirajZahtjev : Form {

        public Korisnik ulogiraniKorisnik { get; set; }
        public KreirajZahtjev(Korisnik korisnik) {
            ulogiraniKorisnik = korisnik;
            InitializeComponent();
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
            var datumPocetka = dtpPocetak.Value;
            var datumZavrsetka = dtpZavrsetak.Value;
            var idPodnositelja = ulogiraniKorisnik;
            var idOdgovornog = KorisnikRepository.DohvatiKorisnika(2);
            var idStatusa  = StatusZahtjevaRepository.DohvatiStatus(1);
            Console.WriteLine(cmbVrsta.SelectedValue);
            var idVrste = cmbVrsta.SelectedValue as VrstaZahtjeva;
            if(idVrste.IdVrsteZahtjeva == 5) {
                idStatusa = StatusZahtjevaRepository.DohvatiStatus(2);
            } 

            Zahtjev noviZahtjev = new Zahtjev {
                VrijemeKreiranja = DateTime.UtcNow,
                DatumPocetka = datumPocetka,
                DatumZavrsetka = datumZavrsetka,
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
