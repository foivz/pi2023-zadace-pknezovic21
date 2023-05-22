using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models {
    public class Zahtjev {
        public int IdZahtjeva { get; set; }
        public DateTime VrijemeKreiranja { get; set; }
        public DateTime DatumPocetka { get; set; }
        public DateTime DatumZavrsetka { get; set; }
        public Korisnik IdPodnositelja { get; set; }
        public Korisnik IdOdgovornog { get; set; }
        public VrstaZahtjeva IdVrsteZahtjeva { get; set; }
        public StatusZahtjeva IdStatusaZahtjeva { get; set; }

    }
}
