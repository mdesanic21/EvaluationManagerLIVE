using Clean_Resources.Models;
using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_Resources.Repositories {
    public class ManagerRepository {
        public static Manager GetManager(string username) {
            string sql = $"SELECT * FROM dbo.Manager WHERE Username = '{username}'";
            return FetchManager(sql);
        }
        // Ova funkcija traži upravitelja poslovanja prema username-u pa pokreće funkciju FetchManager
        
        
        public static Manager GetManager(int id) {
            string sql = $"SELECT * FROM dbo.Manager WHERE ID_Manager = {id}";
            return FetchManager(sql);
        }
        // Ova funkcija traži upravitelja po ID-u pa pokreće funkciju FetchManager
        
        
        private static Manager FetchManager(string sql) {
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Manager manager = null;
            if (reader.HasRows == true) {
                reader.Read();
                manager = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return manager;
        }
        // Funkcija nam omogućuje da u varijablu manager upisujemo sve podatke o manager-u iz baze podatak


        private static Manager CreateObject(SqlDataReader reader) {
            int id = int.Parse(reader["ID_Manager"].ToString());
            //string firstName = reader["FirstName"].ToString();
            //string lastName = reader["LastName"].ToString();
            string username = reader["Username"].ToString();
            string password = reader["Password"].ToString();
            var manager = new Manager {
                ID = id,
                //FirstName = firstName,
                //LastName = lastName,
                Username = username,
                Password = password
            };
            return manager;
        }
        // Ova funkcija mapira objekat iz baze u objekt klase Manager
        // Služi kako bi se u drugim formama i klasama mogao instancirat objekat iz ove sa svim ovim podatcima


    }
    
}
