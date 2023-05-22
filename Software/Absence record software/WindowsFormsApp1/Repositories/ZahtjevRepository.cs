using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Repositories {
    public class ZahtjevRepository {

        public static List<Zahtjev> DohvatiZahtjeve() {
            List<Zahtjev> zahtjevi = new List<Zahtjev>();
            string sql = $"SELECT * FROM Zahtjev";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read()) {
                Zahtjev zahtjev = CreateObject(reader);
                zahtjevi.Add(zahtjev);
            }

            reader.Close();
            DB.CloseConnection();

            return zahtjevi;
        }

        private static Zahtjev CreateObject(SqlDataReader reader) {
            int id = int.Parse(reader["IdZahtjeva"].ToString());
           

            int idPodnositelja = int.Parse(reader["IdPodnositelja"].ToString());
            var podnositelj = KorisnikRepository.DohvatiKorisnika(idPodnositelja); 

            int idOdgovornog = int.Parse(reader["IdOdgovornog"].ToString());
            var odgovorni = KorisnikRepository.DohvatiKorisnika(idOdgovornog); 


            DateTime vrijemeKreiranja = DateTime.Parse(reader["VrijemeKreiranja"].ToString()); 

            DateTime datumPocetka = DateTime.Parse(reader["DatumPocetka"].ToString());

            DateTime datumZavrsetka = DateTime.Parse(reader["DatumZavrsetka"].ToString());

            int idVrsteZahtjeva = int.Parse(reader["IdVrsteZahtjeva"].ToString());
            var vrsta = VrstaZahtjevaRepository.DohvatiVrstu(idVrsteZahtjeva);

            int idStatusaZahtjeva = int.Parse(reader["IdStatusaZahtjeva"].ToString());
            var status = StatusZahtjevaRepository.DohvatiStatus(idStatusaZahtjeva);





            var zahtjev = new Zahtjev {
                IdZahtjeva = id,
                VrijemeKreiranja = vrijemeKreiranja,
                DatumPocetka = datumPocetka,
                DatumZavrsetka = datumZavrsetka,
                IdPodnositelja = podnositelj,
                IdOdgovornog = odgovorni,
                IdVrsteZahtjeva = vrsta,
                IdStatusaZahtjeva = status
            };

            return zahtjev;
        }
    }
}
