using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models {
    public class Zahtjev {
        public int IdZahtjeva { get; set; }
        public string VrijemeKreiranja { get; set; }
        public string DatumPocetka { get; set; }
        public string DatumZavrsetka { get; set; }
        public Korisnik IdPodnositelja { get; set; }
        public Korisnik IdOdgovornog { get; set; }
        public VrstaZahtjeva IdVrsteZahtjeva { get; set; }
        public StatusZahtjeva IdStatusaZahtjeva { get; set; }

       
    }
}
