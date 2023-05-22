using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace WindowsFormsApp1.Models {
    public class VrstaZahtjeva {
        public int IdVrsteZahtjeva { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }

        public override string ToString() {
            return Naziv;
        }
    }
}
