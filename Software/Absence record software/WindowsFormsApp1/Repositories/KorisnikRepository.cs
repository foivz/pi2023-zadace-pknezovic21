using DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Repositories {
    public class KorisnikRepository {

        public static Korisnik DohvatiKorisnika(string email) {
            string sql = $"SELECT * FROM Korisnik WHERE Email = '{email}'";
            return Dohvati(sql);
        }
        public static Korisnik DohvatiKorisnika(int id) {
            string sql = $"SELECT * FROM Korisnik WHERE IdKorisnika = {id}";
            return Dohvati(sql);
        }

        public static Korisnik DohvatiId(string email) {
            string sql = $"SELECT IdKorisnika FROM Korisnik WHERE Email = '{email}'";
            return Dohvati(sql);
        }

        private static Korisnik Dohvati(string sql) {

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Korisnik korisnik = null;
            if (reader.HasRows == true) {
                reader.Read();
                korisnik = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return korisnik;
        }

        public static List<Korisnik> DohvatiKorisnike() {
            var korisnici = new List<Korisnik>();

            string sql = "SELECT * FROM Korisnik";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read()) {
                Korisnik korisnik = CreateObject(reader);
                korisnici.Add(korisnik);
            }

            reader.Close();
            DB.CloseConnection();

            return korisnici;
        }

        private static Korisnik CreateObject(System.Data.SqlClient.SqlDataReader reader) {
            int id = int.Parse(reader["IdKorisnika"].ToString());
            string ime = reader["Ime"].ToString();
            string prezime = reader["Prezime"].ToString();
            string lozinka = reader["Lozinka"].ToString();
            string mail = reader["Email"].ToString();
            int idUloge = Convert.ToInt32(reader["IdUloge"]);
            var korisnik = new Korisnik {
                IdKorisnika = id,
                Ime = ime,
                Prezime = prezime,
                Lozinka = lozinka,
                Email = mail,
                IdUloge = idUloge
            };

            return korisnik;
        }
    }
}
