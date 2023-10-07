using Clean_Resources.Models;
using Clean_Resources.Repositories;
using DBLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Clean_Resources {
    public partial class FrmAddOrganization : Form {
        public FrmAddOrganization() {
            InitializeComponent();
        }


        private void txtEmailOrganization_TextChanged(object sender, EventArgs e) {

        }

        private void FrmAddOrganization_Load(object sender, EventArgs e) {

        }

        public static Client SearchedClientID { get; set; }
        public static Client SearchedClientEmail { get; set; }
        public static Client SearchedClientNumber { get; set; }

        private bool writeOrganization(Organization organization) {
            string pattern = @"^\d+$";
            Regex regex = new Regex(pattern);

            if (txtEmailOrganization.TextLength == 0 | !regex.IsMatch(txtID_Organization.Text.ToString()) | txtIBAN.TextLength == 0 | txtID_Organization.TextLength == 0 | txtName.TextLength == 0 | txtNumberOrganization.TextLength == 0) {
                MessageBox.Show("Niste unijeli sve podatke ispravno!", "Neuspješan unos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Metoda je napravljena kao dvije velike grane, od kojih je druga podijeljena u još grana.
            // Provjera gornjih uvjeta omogućava sustavu da ne upisuje nepotpune podatke o klijentu prilikom unosa.
            // Koristi property TextLength od elemenata kako bi orderila je li išta upisano u prozore za unos.
            // Vraća false što se koristi u idućoj metodi.
            // Donja grana provjerava ostale uvjete.

            else {
                int id = int.Parse(txtID_Organization.Text);
                string email = txtEmailOrganization.Text.ToString();
                string number = txtNumberOrganization.Text.ToString();
                SearchedClientID = ClientRepository.GetClient(id);
                SearchedClientEmail = ClientRepository.GetClient(email);
                SearchedClientNumber = ClientRepository.GetClientNumber(number);

                // Prvo se definiraju varijable koje su kopija varijabli klase Client.
                // Definirane su metode koje vraćaju sve redove tablice koji imaju jedan od ta tri zapisa isti kao i željeni unos u tablicu.
                // Vraća false što se koristi u idućoj metodi.
                // Koriste se kako bi se postavila iduća grananja.

                if (SearchedClientEmail != null) {
                    MessageBox.Show("Klijent s tim email-om već postoji!", "Neuspješan unos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmailOrganization.BackColor = Color.Red;
                    return false;
                }

                // Provjera uvjeta za različitost email-a.
                // Ako se email podudara, izbacuje se poruka pogreške.
                // Vraća false što se koristi u idućoj metodi.

                else if (SearchedClientNumber != null) {
                    txtEmailOrganization.BackColor = Color.White;
                    MessageBox.Show("Klijent s tim brojem već postoji!", "Neuspješan unos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNumberOrganization.BackColor = Color.Red;
                    return false;
                }

                // Provjera uvjeta za različitost broja.
                // Ako se broj podudara, izbacuje se poruka pogreške.
                // Vraća false što se koristi u idućoj metodi.

                else if (SearchedClientID != null) {
                    txtEmailOrganization.BackColor = Color.White;
                    txtNumberOrganization.BackColor = Color.White;
                    MessageBox.Show("Klijent s tim ID-jem već postoji!", "Neuspješan unos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtID_Organization.BackColor = Color.Red;
                    return false;
                }

                // Provjera uvjeta za različitost ID-a.
                // Ako se ID podudara, izbacuje se poruka pogreške.
                // Vraća false što se koristi u idućoj metodi.

                else {
                    string name = txtName.Text.ToString();
                    string iban = txtIBAN.Text.ToString();
                    string sqlClient = $"INSERT INTO dbo.Client (Id_Client, Email, Cellphone) VALUES ('{id}','{email}', '{number}')";
                    string sqlOrganization = $"INSERT INTO dbo.Organization (Id_Organization, Name, IBAN) VALUES ('{id}','{name}','{iban}')";
                    DB.OpenConnection();
                    DB.ExecuteCommand(sqlClient);
                    DB.ExecuteCommand(sqlOrganization);
                    DB.CloseConnection();
                    return true;
                }

                // Ako je unos prošao sve uvjete, zapisuju se i podaci iz txtName i txtIBAN zapisa u varijable name i iban.
                // Preko SQL upita u tablicu se unosi novi redak tablice s unikatnim email-om, id-jem i brojem.
                // Vrše se dva upisa, jedan u tablicu Client, a drugi u tablicu Organization
                // Vraća true što se koristi u idućoj metodi.

            }
        }


        private void button1_Click(object sender, EventArgs e) {
            txtEmailOrganization.BackColor = Color.White;
            txtID_Organization.BackColor = Color.White;
            txtNumberOrganization.BackColor = Color.White;
            var organization = new Organization();
            if (writeOrganization(organization)) {
                MessageBox.Show("Dodali ste novog klijenta!", "Uspješan unos!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        // Klikom na 


        private void txtID_Organization_TextChanged(object sender, EventArgs e) {

        }
    }
}