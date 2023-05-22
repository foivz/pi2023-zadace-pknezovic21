using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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


        public static List<Zahtjev> DohvatiZahtjevePremaKorisniku(int id) {
            List<Zahtjev> zahtjevi = new List<Zahtjev>();
            string sql = $"SELECT * FROM Zahtjev WHERE IdPodnositelja = '{id}'";
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

        public static Zahtjev DohvatiZahtjevPremaId(int id) {
         
            string sql = $"SELECT * FROM Zahtjev WHERE IdZahtjeva = '{id}'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Zahtjev zahtjev = null;
            if (reader.HasRows == true) {
                reader.Read();
                zahtjev = CreateObject(reader);
                reader.Close();
            }
       
            return zahtjev;
        }

        private static Zahtjev CreateObject(SqlDataReader reader) {
            int id = int.Parse(reader["IdZahtjeva"].ToString());
           

            int idPodnositelja = int.Parse(reader["IdPodnositelja"].ToString());
            var podnositelj = KorisnikRepository.DohvatiKorisnika(idPodnositelja);
          

            int idOdgovornog = int.Parse(reader["IdOdgovornog"].ToString());
            var odgovorni = KorisnikRepository.DohvatiKorisnika(idOdgovornog); 


         
            DateTime vrijemeKreiranja = DateTime.Parse(reader["VrijemeKreiranja"].ToString());
            string formatiranoVrijemeKreiranja = vrijemeKreiranja.ToString("yyyy-MM-dd");


            DateTime datumPocetka = DateTime.Parse(reader["DatumPocetka"].ToString());
            string formatiranoVrijemePocetka = datumPocetka.ToString("yyyy-MM-dd");

            DateTime datumZavrsetka = DateTime.Parse(reader["DatumZavrsetka"].ToString());
            string formatiranoVrijemeZavrsetak = datumZavrsetka.ToString("yyyy-MM-dd");


          
            

            int idVrsteZahtjeva = int.Parse(reader["IdVrsteZahtjeva"].ToString());
            var vrsta = VrstaZahtjevaRepository.DohvatiVrstu(idVrsteZahtjeva);

            int idStatusaZahtjeva = int.Parse(reader["IdStatusaZahtjeva"].ToString());
            var status = StatusZahtjevaRepository.DohvatiStatus(idStatusaZahtjeva);



            var zahtjev = new Zahtjev {
                IdZahtjeva = id,
                VrijemeKreiranja = formatiranoVrijemeKreiranja,
                DatumPocetka = formatiranoVrijemePocetka,
                DatumZavrsetka = formatiranoVrijemeZavrsetak,
                IdPodnositelja = podnositelj,
                IdOdgovornog = odgovorni,
                IdVrsteZahtjeva = vrsta,
                IdStatusaZahtjeva = status
            };

            return zahtjev;
        }

        public static void KreirajZahtjev(Zahtjev zahtjev) {
            string sql = $"INSERT INTO Zahtjev (VrijemeKreiranja, DatumPocetka, DatumZavrsetka, IdPodnositelja, IdOdgovornog, IdVrsteZahtjeva, IdStatusaZahtjeva) " +
                $"VALUES ('{zahtjev.VrijemeKreiranja}', '{zahtjev.DatumPocetka}', '{zahtjev.DatumZavrsetka}', {zahtjev.IdPodnositelja.IdKorisnika}, {zahtjev.IdOdgovornog.IdKorisnika}, {zahtjev.IdVrsteZahtjeva.IdVrsteZahtjeva}, {zahtjev.IdStatusaZahtjeva.IdStatusaZahtjeva})";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void UpdateajZahtjev(Zahtjev zahtjev) {
            string sql = $"Update Zahtjev SET VrijemeKreiranja = '{zahtjev.VrijemeKreiranja}',DatumPocetka = '{zahtjev.DatumPocetka}', DatumZavrsetka = '{zahtjev.DatumZavrsetka}', IdVrsteZahtjeva = '{zahtjev.IdVrsteZahtjeva.IdVrsteZahtjeva}', IdStatusaZahtjeva = '{zahtjev.IdStatusaZahtjeva.IdStatusaZahtjeva}' WHERE IdZahtjeva = '{zahtjev.IdZahtjeva}'";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

    }
}
