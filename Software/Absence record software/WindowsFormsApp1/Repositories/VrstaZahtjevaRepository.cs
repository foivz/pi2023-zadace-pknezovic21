using DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Repositories {
    public class VrstaZahtjevaRepository {

        public static VrstaZahtjeva DohvatiVrstu(int id) {
            VrstaZahtjeva vrsta = null;
            string sql = $"SELECT * FROM VrstaZahtjeva WHERE IdVrsteZahtjeva = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows) {
                reader.Read();
                vrsta = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();
            return vrsta;

        }

        public static List<VrstaZahtjeva> DohvatiVrste() {
            List<VrstaZahtjeva> vrste = new List<VrstaZahtjeva>();
            string sql = "SELECT * FROM VrstaZahtjeva";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read()) {
                VrstaZahtjeva vrsta = CreateObject(reader);
                vrste.Add(vrsta);
            }
            reader.Close();
            DB.CloseConnection();
            return vrste;
        }

        private static VrstaZahtjeva CreateObject(System.Data.SqlClient.SqlDataReader reader) {

            int id = int.Parse(reader["IdVrsteZahtjeva"].ToString());
            string naziv = reader["Naziv"].ToString();


            var vrsta = new VrstaZahtjeva {
                IdVrsteZahtjeva = id,
                Naziv = naziv
            };
            return vrsta;
        }

    }
}
