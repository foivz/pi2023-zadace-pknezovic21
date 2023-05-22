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
            DateTime formatiranoVrijeme = Convert.ToDateTime(vrijemeKreiranja.ToString("yyyy-MM-dd hh:mm:ss tt"));


            DateTime datumPocetka = DateTime.Parse(reader["DatumPocetka"].ToString());

            DateTime datumZavrsetka = DateTime.Parse(reader["DatumZavrsetka"].ToString());

            int idVrsteZahtjeva = int.Parse(reader["IdVrsteZahtjeva"].ToString());
            var vrsta = VrstaZahtjevaRepository.DohvatiVrstu(idVrsteZahtjeva);

            int idStatusaZahtjeva = int.Parse(reader["IdStatusaZahtjeva"].ToString());
            var status = StatusZahtjevaRepository.DohvatiStatus(idStatusaZahtjeva);





            var zahtjev = new Zahtjev {
                IdZahtjeva = id,
                VrijemeKreiranja = formatiranoVrijeme,
                DatumPocetka = datumPocetka,
                DatumZavrsetka = datumZavrsetka,
                IdPodnositelja = podnositelj,
                IdOdgovornog = odgovorni,
                IdVrsteZahtjeva = vrsta,
                IdStatusaZahtjeva = status
            };

            return zahtjev;
        }

        public static void KreirajZahtjev(Zahtjev zahtjev) {
            string sql = $"INSERT INTO Zajev (VrijemeKreiranja, DatumPocetka, DatumZavrsetka, IdPodnositelja, IdOdgovornog, IdVrsteZahtjeva, IdStatusaZahtjeva) " +
                $"VALUES ('{zahtjev.VrijemeKreiranja}', '{zahtjev.DatumPocetka}', '{zahtjev.DatumZavrsetka}', {zahtjev.IdPodnositelja}, {zahtjev.IdOdgovornog}, {zahtjev.IdVrsteZahtjeva}, {zahtjev.IdStatusaZahtjeva})";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

    }
}
