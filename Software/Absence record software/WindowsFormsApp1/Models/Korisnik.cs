﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models {
    public class Korisnik {
        public int IdKorisnika { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Lozinka { get; set; }
        public string Email { get; set; }
        public int IdUloge { get; set; }

        public override string ToString() {
            return Ime + " " + Prezime;
        }

      
    }
}
