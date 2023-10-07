using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Clean_Resources.Models;
using Clean_Resources.Repositories;
using DBLayer;
using System.Drawing;
using System;

namespace Clean_Resources {
    public partial class FrmAddSingleton : Form {
        public FrmAddSingleton() {
            InitializeComponent();
        }

        private void FrmAddSingleton_Load(object sender, EventArgs e) {

        }

        public static Client SearchedClientID { get; set; }
        public static Client SearchedClientEmail { get; set; }
        public static Client SearchedClientNumber { get; set; }

        private bool writeSingleton(Singleton singleton) {
            string pattern = @"^\d+$";
            Regex regex = new Regex(pattern);

            if (txtID_Singleton.TextLength == 0 | !regex.IsMatch(txtID_Singleton.Text.ToString()) | txtEmailSingleton.TextLength == 0 | txtFirstName.TextLength == 0 | txtLastName.TextLength == 0 | txtNumberSingleton.TextLength == 0) {
                MessageBox.Show("Niste unijeli sve podatke ispravno!", "Neuspješan unos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Isto kao i u FrmAddOrganization se vrše provjere i ovdje, samo što se korste elementi ove forme.

            else {
                int id = int.Parse(txtID_Singleton.Text.ToString());
                string email = txtEmailSingleton.Text.ToString();
                string number = txtNumberSingleton.Text.ToString();
                string firstName = txtFirstName.Text.ToString();
                string lastName = txtLastName.Text.ToString();
                SearchedClientID = ClientRepository.GetClient(id);
                SearchedClientEmail = ClientRepository.GetClient(email);
                SearchedClientNumber = ClientRepository.GetClientNumber(number);

                // Isti princip kao i u FrmAddOrganization formi

                if (SearchedClientEmail != null) {
                    MessageBox.Show("Klijent s tim email-om već postoji!", "Neuspješan unos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmailSingleton.BackColor = Color.Red;
                    return false;

                }

                // Provjera postoji li klijent s istim email-om.
                // Isto kao i u FrmAddOrganization

                else if (SearchedClientNumber != null) {
                    txtEmailSingleton.BackColor = Color.White;
                    MessageBox.Show("Klijent s tim brojem već postoji!", "Neuspješan unos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNumberSingleton.BackColor = Color.Red;
                    return false;

                }

                // Provjera postoji li klijent s istim brojem.
                // Isto kao i u FrmAddOrganization

                else if (SearchedClientID != null) {
                    txtEmailSingleton.BackColor = Color.White;
                    txtNumberSingleton.BackColor = Color.White;
                    MessageBox.Show("Klijent s tim ID-jem već postoji!", "Neuspješan unos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtID_Singleton.BackColor = Color.Red;
                    return false;
                }

                // Provjera postoji li klijent s istim ID-jem.
                // Isto kao i u FrmAddOrganization

                else {
                    string sqlClient = $"INSERT INTO dbo.Client (Id_Client, Email, Cellphone) VALUES ('{id}','{email}', '{number}')";
                    string sqlSingleton = $"INSERT INTO dbo.Singleton (Id_Singleton, FirstName, LastName) VALUES ('{id}','{firstName}','{lastName}')";
                    DB.OpenConnection();
                    DB.ExecuteCommand(sqlClient);
                    DB.ExecuteCommand(sqlSingleton);
                    DB.CloseConnection();
                    return true;
                }

                // Unos sličan kao i u FrmAddOrganization.
                // Promjena SQL upita kako bi se prilagodio ovoj tablici i situaciji.

            }

        }

        private void btnAddSingleton_Click(object sender, EventArgs e) {
            txtEmailSingleton.BackColor = Color.White;
            txtID_Singleton.BackColor = Color.White;
            txtNumberSingleton.BackColor = Color.White;
            var singleton = new Singleton();
            if (writeSingleton(singleton)) {
                MessageBox.Show("Dodali ste novog klijenta!", "Uspješan unos!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        // Slično kao i u FrmAddOrganization 
    }
}