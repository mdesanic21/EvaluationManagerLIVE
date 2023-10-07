using Clean_Resources.Models;
using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Clean_Resources.Repositories {
    internal class OrganizationRepository {

        public static Organization GetOrganization(int id) {
            string sql = $"SELECT * FROM dbo.Organization JOIN dbo.Client ON dbo.Organization.Id_Organization = dbo.Client.Id_Client WHERE ID_Organization = {id}";
            return FetchOrganization(sql);
        }
        // Dohvaća tvrtku po ID-u preko upita.

        private static Organization FetchOrganization(string sql) {
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Organization organization = null;
            if (reader.HasRows == true) {
                reader.Read();
                organization = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return organization;
        }
        // Dohvaća tvrtku povezivanjem s bazom i provjerom uvjeta zadanog u sql parametru.

        public static List<Organization> GetOrganizations() 
        {
            List<Organization> organization = new List<Organization>();
            string sql = "SELECT * FROM dbo.Organization JOIN dbo.Client ON dbo.Organization.Id_Organization = dbo.Client.Id_Client";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read()) {
                Organization organizations = CreateObject(reader);
                organization.Add(organizations);
            }
            reader.Close();
            DB.CloseConnection();
            return organization;
        }
        // Opis jako slične metode gdje su promijenjeni samo naziv tablice i nazivi atributa u tablici je već opisan u SingletonRepository.cs kodu


        public static List<Organization> GetOrganizationsSearch(string search) 
        {
            List<Organization> organization = new List<Organization>();
            string sql = $"SELECT * FROM dbo.Organization JOIN dbo.Client ON dbo.Organization.Id_Organization = dbo.Client.Id_Client WHERE dbo.Client.Id_Client LIKE '%{search}%' OR dbo.Client.Email LIKE '%{search}%' OR dbo.Client.Cellphone LIKE '%{search}%' OR dbo.Organization.Name LIKE '%{search}%' OR dbo.Organization.IBAN LIKE '%{search}%' OR dbo.Organization.Id_Organization LIKE '%{search}%'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read()) {
                Organization organizations = CreateObject(reader);
                organization.Add(organizations);
            }
            reader.Close();
            DB.CloseConnection();
            return organization;
        }
        // Opis jako slične metode gdje su promijenjeni samo naziv tablice i nazivi atributa u tablici je već opisan u SingletonRepository.cs kodu


        private static Organization CreateObject(SqlDataReader reader) 
        {
            int id = int.Parse(reader["Id_Organization"].ToString());
            string email = reader["Email"].ToString();
            string number = reader["Cellphone"].ToString();
            string name = reader["Name"].ToString();
            string iban = reader["IBAN"].ToString();
            
            var organization = new Organization {
                ID = id,
                Name = name,
                IBAN = iban,
                Email = email,
                Number = number
            };
            return organization;
        }
        // Opis jako slične metode gdje su promijenjeni samo naziv tablice i nazivi atributa u tablici je već opisan u SingletonRepository.cs kodu


    }
}
