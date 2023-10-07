using Clean_Resources.Models;
using Clean_Resources.Repositories;
using DBLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clean_Resources {
    public partial class FrmEditClient : Form {
        public FrmEditClient() {
            InitializeComponent();
        }

        private void FrmEditClient_Load(object sender, EventArgs e) {
            txtFirstNameEdit.Enabled = false;
            txtLastNameEdit.Enabled = false;
            txtNameEdit.Enabled = false;
            txtIBANEdit.Enabled = false;
            txtEmailEdit.Enabled = false;
            txtNumberEdit.Enabled = false;
        }

        public static Client ClientID { get; set; }
        public static Client ClientEmail { get; set; }
        public static Client ClientNumber { get; set; }
        public static Organization OrganizationID { get; set; }
        public static Singleton SingletonID { get; set; }


        private void txtIDClienEdit_TextChanged(object sender, EventArgs e) {
            string pattern = @"^\d+$";
            Regex regex = new Regex(pattern);

            if (!regex.IsMatch(txtIDClienEdit.Text.ToString()) | txtIDClienEdit.TextLength == 0) {
                txtIDClienEdit.BackColor = Color.Red;
                btnSave.Enabled = false;
                btnSave.BackColor = Color.Gray;
                btnDeleteClient.Enabled = false;
                btnDeleteClient.BackColor = Color.Gray;
                txtFirstNameEdit.Enabled = false;
                txtLastNameEdit.Enabled = false;
                txtNameEdit.Enabled = false;
                txtIBANEdit.Enabled = false;
                txtEmailEdit.Enabled = false;
                txtNumberEdit.Enabled = false;
                txtFirstNameEdit.Text = "";
                txtLastNameEdit.Text = "";
                txtNameEdit.Text = "";
                txtIBANEdit.Text = "";
                txtEmailEdit.Text = "";
                txtNumberEdit.Text = "";
            } else {
                int id = int.Parse(txtIDClienEdit.Text);
                ClientID = ClientRepository.GetClient(id);
                txtIDClienEdit.BackColor = Color.FromArgb(249, 245, 246);
                btnSave.Enabled = true;
                btnSave.BackColor = Color.FromArgb(242, 190, 209);
                btnDeleteClient.Enabled = true;
                btnDeleteClient.BackColor = Color.FromArgb(242, 190, 209);
                ClientID = ClientRepository.GetClient(id);
                OrganizationID = OrganizationRepository.GetOrganization(id);
                SingletonID = SingletonRepository.GetSingleton(id);
                if (ClientID == null) {
                    txtIDClienEdit.BackColor = Color.Red;
                    btnSave.Enabled = false;
                    btnSave.BackColor = Color.Gray;
                    btnDeleteClient.Enabled = false;
                    btnDeleteClient.BackColor = Color.Gray;
                    txtFirstNameEdit.Enabled = false;
                    txtLastNameEdit.Enabled = false;
                    txtNameEdit.Enabled = false;
                    txtIBANEdit.Enabled = false;
                    txtEmailEdit.Enabled = false;
                    txtNumberEdit.Enabled = false;
                    txtFirstNameEdit.Text = "";
                    txtLastNameEdit.Text = "";
                    txtNameEdit.Text = "";
                    txtIBANEdit.Text = "";
                    txtEmailEdit.Text = "";
                    txtNumberEdit.Text = "";
                } else {
                    if (OrganizationID != null) {
                        txtNameEdit.Enabled = true;
                        txtIBANEdit.Enabled = true;
                        txtEmailEdit.Enabled = true;
                        txtNumberEdit.Enabled = true;
                        txtEmailEdit.Text = OrganizationID.Email;
                        txtNumberEdit.Text = OrganizationID.Number;
                        txtNameEdit.Text = OrganizationID.Name;
                        txtIBANEdit.Text = OrganizationID.IBAN;
                        txtFirstNameEdit.Enabled = false;
                        txtLastNameEdit.Enabled = false;

                    } else if (SingletonID != null) {
                        txtFirstNameEdit.Enabled = true;
                        txtLastNameEdit.Enabled = true;
                        txtEmailEdit.Enabled = true;
                        txtNumberEdit.Enabled = true;
                        txtEmailEdit.Text = SingletonID.Email;
                        txtNumberEdit.Text = SingletonID.Number;
                        txtFirstNameEdit.Text = SingletonID.FirstName;
                        txtLastNameEdit.Text = SingletonID.LastName;
                        txtNameEdit.Enabled = false;
                        txtIBANEdit.Enabled = false;
                    }
                }
            }
        }

        // Metoda koja prikazuje podatke koji pripadaju unešenom ID-u
        // Zapisuje ih u textbox elemente
        // Onemogućava klik na gumbe ako je unešen ID koji ne postoji
        public bool updateSingleton() {

            int id = int.Parse(txtIDClienEdit.Text.ToString());
            string email = txtEmailEdit.Text.ToString();
            string number = txtNumberEdit.Text.ToString();
            string firstName = txtFirstNameEdit.Text.ToString();
            string lastName = txtLastNameEdit.Text.ToString();
            ClientID = ClientRepository.GetClient(id);
            /*ClientEmail = ClientRepository.GetClient(email);
            ClientNumber = ClientRepository.GetClientNumber(number);
            if (ClientEmail != null | ClientNumber != null) {
                MessageBox.Show("Upisujete podatke koji već postoje u bazi za email ili broj telefona!", "Neuspješan unos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            } 
            else 
            {*/
            string sqlClient = $"UPDATE dbo.Client SET Cellphone = '{number}', Email = '{email}' WHERE ID_Client = {id}";
            string sqlSingleton = $"UPDATE dbo.Singleton SET FirstName = '{firstName}', LastName = '{lastName}' WHERE ID_Singleton = {id}";
            DB.OpenConnection();
            DB.ExecuteCommand(sqlClient);
            DB.ExecuteCommand(sqlSingleton);
            DB.CloseConnection();
            return true;
            //} 
        }


        public void deleteSingleton() {
            int id = int.Parse(txtIDClienEdit.Text.ToString());
            string email = txtEmailEdit.Text.ToString();
            string number = txtNumberEdit.Text.ToString();
            string firstName = txtFirstNameEdit.Text.ToString();
            string lastName = txtLastNameEdit.Text.ToString();
            string sqlClient = $"DELETE FROM dbo.Client WHERE ID_Client = {id}";
            string sqlSingleton = $"DELETE FROM dbo.Singleton WHERE ID_Singleton = {id}";
            DB.OpenConnection();
            DB.ExecuteCommand(sqlSingleton);
            DB.ExecuteCommand(sqlClient);
            DB.CloseConnection();

        }


        public bool updateOrganization() {
            int id = int.Parse(txtIDClienEdit.Text.ToString());
            string email = txtEmailEdit.Text.ToString();
            string number = txtNumberEdit.Text.ToString();
            string name = txtNameEdit.Text.ToString();
            string iban = txtIBANEdit.Text.ToString();
            /*ClientEmail = ClientRepository.GetClient(email);
            ClientNumber = ClientRepository.GetClientNumber(number);
            if (ClientEmail != null | ClientNumber != null) {
                MessageBox.Show("Upisujete podatke koji već postoje u bazi za email ili broj telefona!", "Neuspješan unos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else 
            {*/
            string sqlClient = $"UPDATE dbo.Client SET Cellphone = '{number}', Email = '{email}' WHERE ID_Client = {id}";
            string sqlSingleton = $"UPDATE dbo.Organization SET Name = '{name}', IBAN = '{iban}' WHERE ID_Organization = {id}";
            DB.OpenConnection();
            DB.ExecuteCommand(sqlClient);
            DB.ExecuteCommand(sqlSingleton);
            DB.CloseConnection();
            return true;
            //}          
        }

        public void deleteOrganization() {
            int id = int.Parse(txtIDClienEdit.Text.ToString());
            string email = txtEmailEdit.Text.ToString();
            string number = txtNumberEdit.Text.ToString();
            string name = txtNameEdit.Text.ToString();
            string iban = txtIBANEdit.Text.ToString();
            string sqlClient = $"DELETE FROM dbo.Client WHERE ID_Client = {id}";
            string sqlOrganization = $"DELETE FROM dbo.Organization WHERE ID_Organization = {id}";
            DB.OpenConnection();
            DB.ExecuteCommand(sqlOrganization);
            DB.ExecuteCommand(sqlClient);
            DB.CloseConnection();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            int id = int.Parse(txtIDClienEdit.Text.ToString());
            OrganizationID = OrganizationRepository.GetOrganization(id);
            SingletonID = SingletonRepository.GetSingleton(id);
            if (SingletonID != null) {
                if (updateSingleton()) {
                    MessageBox.Show("Uredili ste klijenta!", "Uspješna promjena!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            } else if (OrganizationID != null) {
                if (updateOrganization()) {
                    MessageBox.Show("Uredili ste klijenta!", "Uspješna promjena!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void btnDeleteClient_Click(object sender, EventArgs e) {
            int id = int.Parse(txtIDClienEdit.Text.ToString());
            OrganizationID = OrganizationRepository.GetOrganization(id);
            SingletonID = SingletonRepository.GetSingleton(id);
            if (SingletonID != null) {
                deleteSingleton();
                MessageBox.Show("Uspješno obrisan klijent!", "Uspješna promjena!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            } else if (OrganizationID != null) {
                deleteOrganization();
                MessageBox.Show("Uspješno obrisan klijent!", "Uspješna promjena!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}