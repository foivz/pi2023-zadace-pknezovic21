using DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Repositories {
    public class StatusZahtjevaRepository {

        public static StatusZahtjeva DohvatiStatus(int id) {
            StatusZahtjeva status = null;
            string sql = $"SELECT * FROM StatusZahtjeva WHERE IdStatusaZahtjeva = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows) {
                reader.Read();
                status = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();
            return status;

        }

        public static List<StatusZahtjeva> DohvatiStatuse() {
            List<StatusZahtjeva> statusi = new List<StatusZahtjeva>();
            string sql = "SELECT * FROM StatusZahtjeva";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read()) {
                StatusZahtjeva status = CreateObject(reader);
                statusi.Add(status);
            }
            reader.Close();
            DB.CloseConnection();
            return statusi;
        }

        private static StatusZahtjeva CreateObject(System.Data.SqlClient.SqlDataReader reader) {

            int id = int.Parse(reader["IdStatusaZahtjeva"].ToString());
            string naziv = reader["Naziv"].ToString();


            var status = new StatusZahtjeva {
                IdStatusaZahtjeva = id,
                Naziv = naziv
            };

            return status;
        }
    }
}
