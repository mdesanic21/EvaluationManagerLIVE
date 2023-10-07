using Clean_Resources.Models;
using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clean_Resources.Repositories {

    internal class SingletonRepository 
    {
        public static Singleton GetSingleton(int id) {
            string sql = $"SELECT * FROM dbo.Singleton  JOIN dbo.Client ON dbo.Singleton.Id_Singleton = dbo.Client.Id_Client WHERE ID_Singleton = {id}";
            return FetchSingleton(sql);
        }
        // Dohvaća singleton po ID-u preko upita.

        private static Singleton FetchSingleton(string sql) {
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Singleton singleton = null;
            if (reader.HasRows == true) {
                reader.Read();
                singleton= CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return singleton;
        }
        // Dohvaća singleton povezivanjem s bazom i provjerom uvjeta zadanog u sql parametru.

        public static List<Singleton> GetSingletons() 
        {
            List<Singleton> singleton = new List<Singleton>();
            string sql = "SELECT * FROM dbo.Singleton JOIN dbo.Client ON dbo.Singleton.Id_Singleton = dbo.Client.Id_Client";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read()) {
                Singleton singletons = CreateObject(reader);
                singleton.Add(singletons);
            }
            reader.Close();
            DB.CloseConnection();
            return singleton;
        }
        // Metoda koja se koristi za prikaz svih pojedinaca u tablici.
        // Funkcionira na temelju SQL upita, koji prikazuje sve članove tablice Singleton i tablice Client bazirano na vanjskom ključu
        // tablice Singleton, koja je primarni ključ tablice Client.
        // Stvara se konekcija sa bazom podataka i preko varijable reader se upisuje u bazu podataka prethodno opisani SQL upit.
        // Dolje je definirana funkcija CreateObject() koja, preko onoga što je zapisano u readeru nakon primjene SQL upita, kreira
        // objekte koji se upisuju u našu listu.
        // U listu pojedinaca koju smo prethodno definirali se upisuju redak po redak redovi iz tablice bez ikakvog filtera.
        // Nakon što se svi redovi upišu, prekida se veza i metoda vraća listu singleton.


        public static List<Singleton> GetSingletonsSearch(string search) 
        {
            List<Singleton> singleton = new List<Singleton>();
            string sql = $"SELECT * FROM dbo.Singleton JOIN dbo.Client ON dbo.Singleton.Id_Singleton = dbo.Client.Id_Client WHERE dbo.Client.Id_Client LIKE '%{search}%' OR dbo.Client.Email LIKE '%{search}%' OR dbo.Client.Cellphone LIKE '%{search}%' OR dbo.Singleton.FirstName LIKE '%{search}%' OR dbo.Singleton.LastName LIKE '%{search}%' OR dbo.Singleton.Id_Singleton LIKE '%{search}%'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read()) {
                Singleton singletons = CreateObject(reader);
                singleton.Add(singletons);
            }
            reader.Close();
            DB.CloseConnection();
            return singleton;
        }
        // Razlikuje se od prethodne metode samo po SQL upitu. 
        // Ovdje je upit puno kompleksniji nego u prethodnoj metodi, a bazira se na tome da se definira uvjet prikazivanja retka za svaku
        // kolumnu tog retka.
        // Sintaksa '%{search}' mi omogućuje da definiram uvjet prema varijabli search, kojoj se u formi prikaza podataka određuje
        // vrijednost i proslijeđuje ovoj metodi. Znak '%' postavljen s obje strane definira upit da bira sve retke koji u bilo kojoj
        // svojoj kolumni u bilo kojem dijelu riječi imaju ono što je zapisano u search varijablu.
        // Ostatak postupka je isti kao i u prethodnoj metodi


        private static Singleton CreateObject(SqlDataReader reader) 
        {
            int id = int.Parse(reader["Id_Singleton"].ToString());
            string firstName = reader["FirstName"].ToString();
            string lastName = reader["LastName"].ToString();
            string email = reader["Email"].ToString();
            string number = reader["Cellphone"].ToString();
            var singleton = new Singleton {
                ID = id,
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Number = number
            };
            return singleton;
        }
        // Metoda definira varijable i u njih upisuje podatke preko reader-a. 
        // Definira se varijabla singleton koja predstavlja novu instancu klase Singleton i u nju se upisuju podaci iz baze.
        // Vraća pojedinca kao objekt koji se dalje koristi za upis u neku strukturu koju koristimo.


    }
}
