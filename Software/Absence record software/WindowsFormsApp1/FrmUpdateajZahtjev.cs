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
    public partial class FrmUpdateajZahtjev : Form {
        public Korisnik ulogiraniKorisnik { get; set; }
        public Zahtjev StvarniZahtjev { get; set; }
        public int IdZahtjeva { get; set; }
        public FrmUpdateajZahtjev(Korisnik korisnik, int idZahtjeva) {
            ulogiraniKorisnik = korisnik;
            IdZahtjeva = idZahtjeva;
           StvarniZahtjev = ZahtjevRepository.DohvatiZahtjevPremaId(IdZahtjeva);
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void UpdateajZahtjev_Load(object sender, EventArgs e) {
            PopuniVrstu();
            OdaberiVrstu(StvarniZahtjev.IdVrsteZahtjeva);
            IspuniZahtjev();
        }

        private void OdaberiVrstu(VrstaZahtjeva idVrsteZahtjeva) {
            int id = idVrsteZahtjeva.IdVrsteZahtjeva;
            for (int i = 0; i < cmbVrsta.Items.Count; i++) {
                VrstaZahtjeva vrsta = cmbVrsta.Items[i] as VrstaZahtjeva;
                if (vrsta.IdVrsteZahtjeva == id) {
                    cmbVrsta.SelectedIndex = i;
                    break;
                }
            }
        }


        private void PopuniVrstu() {
            var vrste = VrstaZahtjevaRepository.DohvatiVrste();
            cmbVrsta.DataSource = vrste;
         
        }



        private void IspuniZahtjev() {
            
            var formatiranPocetak = Convert.ToDateTime(StvarniZahtjev.DatumPocetka);
            dtpPocetak.Value = formatiranPocetak;

            var formatiranKraj = Convert.ToDateTime(StvarniZahtjev.DatumZavrsetka);
            dtpZavrsetak.Value = formatiranKraj;


        }

        private void VratiPopis() {
            FrmPopisZahtjeva form = new FrmPopisZahtjeva(ulogiraniKorisnik);
            Hide();
            form.ShowDialog();
            Close();
        }
    

        private void btnPodnesi_Click(object sender, EventArgs e) {


            DateTime vrijemePocetka = dtpPocetak.Value;
            string formatiranoVrijemePocetka = vrijemePocetka.ToString("yyyy-MM-dd");



            DateTime vrijemeZavrsetka = dtpZavrsetak.Value;
            string formatiranoVrijemeZavrsetak = vrijemeZavrsetka.ToString("yyyy-MM-dd");



            var idStatusa = StvarniZahtjev.IdStatusaZahtjeva;

            var idVrste = cmbVrsta.SelectedValue as VrstaZahtjeva;
            if (idVrste.IdVrsteZahtjeva == 5) {
                idStatusa = StatusZahtjevaRepository.DohvatiStatus(2);
            }
            DateTime vrijemeKreiranja = DateTime.Now;
            string formatiranoVrijemeKreiranja = vrijemeKreiranja.ToString("yyyy-MM-dd");
            Zahtjev noviZahtjev = new Zahtjev {
                IdZahtjeva = StvarniZahtjev.IdZahtjeva,
                VrijemeKreiranja = formatiranoVrijemeKreiranja,
                DatumPocetka = formatiranoVrijemePocetka,
                DatumZavrsetka = formatiranoVrijemeZavrsetak,
                IdVrsteZahtjeva = idVrste,
                IdStatusaZahtjeva = idStatusa
            };
            ZahtjevRepository.UpdateajZahtjev(noviZahtjev);
            Close();
            VratiPopis();

        }

        private void btnOdustani_Click_1(object sender, EventArgs e) {
            Close();
            VratiPopis();
        }

        private void dtpPocetak_ValueChanged_1(object sender, EventArgs e) {
            if (dtpZavrsetak.Value < dtpPocetak.Value) {
                dtpZavrsetak.Value = dtpPocetak.Value;
            }
        }

        private void dtpZavrsetak_ValueChanged_1(object sender, EventArgs e) {
            if (dtpZavrsetak.Value < dtpPocetak.Value) {
                dtpZavrsetak.Value = dtpPocetak.Value;
            }
        }
    }
}
