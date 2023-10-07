using Clean_Resources.Models;
using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_Resources.Repositories {
    internal class ClientRepository {

        private static Client FetchClient(string sql) 
        {
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Client client = null;
            if (reader.HasRows) {
                reader.Read();
                client = CreateClientObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return client;
        }
        // Metodi se proslieđuje varijabla sql koja će sadržavati SQL upit.
        // Definira se varijabla reader kao DataReader od baze podataka i u njega se upisuje varijabla sql.
        // Kreira se objekt u dolje objašnjenoj metodi.
        // Zapisuje se sve u objekt client klase Client.


        public static Client GetClient(string email) 
        {
            string sql = $"SELECT * FROM dbo.Client WHERE Email = '{email}'";
            return FetchClient(sql);
        }
        // Get Client (string) koristi metodu FetchClient(), odnosno proslijeđuje joj string sql koji ovisi o proslijeđenoj varijabli email tipa string.


        public static Client GetClient(int id) 
        {
            string sql = $"SELECT * FROM dbo.Client WHERE Id_Client = '{id}'";
            return FetchClient(sql);
        }
        // Metoda GetClient(int) preopterećuje metodu GetClient jer obje koriste isti naziv, ali koriste različite parametre.


        public static Client GetClientNumber(string number) 
        {
            string sql = $"SELECT * FROM dbo.Client WHERE Cellphone = '{number}'";
            return FetchClient(sql);
        }
        // Metoda koja je slična metodi GetClient(string), ali ova se ne može isto zvati jer onda bi postojale dvije metode istog naziva i s istim parametrima.


        private static Client CreateClientObject(SqlDataReader reader) 
        {
                int id = int.Parse(reader["ID_Client"].ToString());
                string email = reader["Email"].ToString();
                string number = reader["Cellphone"].ToString();

                var client = new Client {
                    ID = id,
                    Email = email,
                    Number = number
                };

                return client;
        }
        // Opisano u SingletonRepository.cs kodu, samo se koriste različiti nazivi za tablicu i kolumne tablice.
    
    
    }
}
