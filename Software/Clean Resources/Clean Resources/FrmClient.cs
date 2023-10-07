using Clean_Resources.Models;
using Clean_Resources.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Clean_Resources {
    public partial class FrmClients : Form {
        public FrmClients() {
            InitializeComponent();
        }

        private void FrmClient_Load(object sender, EventArgs e) {
            string search = "";
            ShowSignletons(search);
            ShowOrganizations(search);
        }
        // Kada se otvori forma, definira se varijabla tipa string "search" koja ne sadržava niti jedan znak. To nam je bitno jer u funkcijama
        // ShowSignletons i ShowOrganizations postoji uvjet koji ovisi o proslijeđenoj varijabli search. Prikazat će se svi članovi obje tablice.


        public void ShowSignletons(string search) 
        {
            if (txtSearchSingleton.TextLength == 0) {
                List<Singleton> singletons = SingletonRepository.GetSingletons();
                dgvSingletons.DataSource = singletons;
                
                dgvSingletons.Columns["ID"].HeaderText = "ID";
                dgvSingletons.Columns["Email"].HeaderText = "Email";
                dgvSingletons.Columns["Number"].HeaderText = "Broj telefona";
                dgvSingletons.Columns["FirstName"].HeaderText = "Ime";
                dgvSingletons.Columns["LastName"].HeaderText = "Prezime";
                dgvSingletons.Columns["ID"].DisplayIndex = 0;
                dgvSingletons.Columns["Email"].DisplayIndex = 1;
                dgvSingletons.Columns["Number"].DisplayIndex = 2;
                dgvSingletons.Columns["FirstName"].DisplayIndex = 3;
                dgvSingletons.Columns["LastName"].DisplayIndex = 4;
            
            } 
            else 
            { 
                List<Singleton> singletons = SingletonRepository.GetSingletonsSearch(search);
                dgvSingletons.DataSource = singletons;
               
                dgvSingletons.Columns["ID"].HeaderText = "ID";
                dgvSingletons.Columns["Email"].HeaderText = "Email";
                dgvSingletons.Columns["Number"].HeaderText = "Broj telefona";
                dgvSingletons.Columns["FirstName"].HeaderText = "Ime";
                dgvSingletons.Columns["LastName"].HeaderText = "Prezime";
                dgvSingletons.Columns["ID"].DisplayIndex = 0;
                dgvSingletons.Columns["Email"].DisplayIndex = 1;
                dgvSingletons.Columns["Number"].DisplayIndex = 2;
                dgvSingletons.Columns["FirstName"].DisplayIndex = 3;
                dgvSingletons.Columns["LastName"].DisplayIndex = 4;
           
             }
            
        }
        // Varijabla search će se u metodama ResetForm(), FrmClient_Load(), txtSearchOrganizations_TextChanged(), txtSearchSingletons_TextChanged() proslijediti metodi.
        // Prikaz pojedinaca su metode repozitorija za pojedince, a biraju se ovisno o  duljin teksta u elementu txtSearchSingleton na FrmClient dizajnu.


        private void ShowOrganizations(string search) {
            if (txtSearchOrganizations.TextLength == 0) {
                List<Organization> organizations = OrganizationRepository.GetOrganizations();
                dgvOrganization.DataSource = organizations;
                
                dgvOrganization.Columns["ID"].HeaderText = "ID";
                dgvOrganization.Columns["Email"].HeaderText = "Email";
                dgvOrganization.Columns["Number"].HeaderText = "Broj telefona";
                dgvOrganization.Columns["Name"].HeaderText = "Naziv";
                dgvOrganization.Columns["IBAN"].HeaderText = "IBAN";
                dgvOrganization.Columns["ID"].DisplayIndex = 0;
                dgvOrganization.Columns["Email"].DisplayIndex = 1;
                dgvOrganization.Columns["Number"].DisplayIndex = 2;
                dgvOrganization.Columns["Name"].DisplayIndex = 3;
                dgvOrganization.Columns["IBAN"].DisplayIndex = 4;
                
            } 
            else 
            {
                List<Organization> organizations = OrganizationRepository.GetOrganizationsSearch(search);
                dgvOrganization.DataSource = organizations;

                dgvOrganization.Columns["ID"].HeaderText = "ID";
                dgvOrganization.Columns["Email"].HeaderText = "Email";
                dgvOrganization.Columns["Number"].HeaderText = "Broj telefona";
                dgvOrganization.Columns["Name"].HeaderText = "Naziv";
                dgvOrganization.Columns["IBAN"].HeaderText = "IBAN";
                dgvOrganization.Columns["ID"].DisplayIndex = 0;
                dgvOrganization.Columns["Email"].DisplayIndex = 1;
                dgvOrganization.Columns["Number"].DisplayIndex = 2;
                dgvOrganization.Columns["Name"].DisplayIndex = 3;
                dgvOrganization.Columns["IBAN"].DisplayIndex = 4;

            }
        }

        // Varijabla search će se u metodama ResetForm(), FrmClient_Load(), txtSearchOrganizations_TextChanged(), txtSearchSingletons_TextChanged() proslijediti metodi.
        // Prikaz tvrtki su metode repozitorija za tvrtke, a biraju se ovisno o  duljin teksta u elementu txtSearchOrganization na FrmClient dizajnu.


        public void ResetForm() 
        {
            string search = txtSearchOrganizations.Text.ToString();
            ShowSignletons(search);
            ShowOrganizations(search);
        }
        // Metoda koja ponovno učitava prikaz forme koristeći metode ShowSingleton() i ShowOrganization(). Prethodno je objašnjeno kako one funkcioniraju.


        private void btnAddClient_Click(object sender, EventArgs e) 
        {
            FrmAddClient frmAddClient = new FrmAddClient();
            frmAddClient.Show();
        }
        // Metoda se poziva klikom na gumb btnAddClient odnosno "Dodaj klijenta", te se otvara nova forma koja vodi na odabir tipa klijenta kojeg organizatorica želi dodati.


        private void btnResetFrmClient_Click(object sender, EventArgs e) 
        {
            ResetForm();
        }
        // Metoda se poziva klikom na gumb btnReset odnosno "Reset" osvježava se prikaz klijenata. Koristi se nakon dodavanja novog klijenta.


        private void txtSearchOrganizations_TextChanged(object sender, EventArgs e) 
        {
            string search = txtSearchOrganizations.Text.ToString();
            ShowOrganizations(search);
        }
        // Unosom ili bilo kakvom promjenom teksta u txtSearchOrganizations poziva se funkcija za osvježavanje prikaza tvrtki ovisno o unesenom tekstu u taj textbox.


        private void txtSearchSingleton_TextChanged(object sender, EventArgs e) 
        {
            string search = txtSearchSingleton.Text.ToString();
            ShowSignletons(search);
        }
        // Unosom ili bilo kakvom promjenom teksta u txtSearchSingleton poziva se funkcija za osvježavanje prikaza pojedinaca ovisno o unesenom tekstu u taj textbox.

        private void lblSignOut_Click(object sender, EventArgs e) 
        {
            Hide();
            MessageBox.Show("Odjavljeni ste", "Odjava", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
            Close();
        }

        private void btnEditClient_Click(object sender, EventArgs e) {

            FrmEditClient frmEditClient = new FrmEditClient();
            frmEditClient.Show();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void dgvSingletons_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        // Odjava iz sustava upravljanjem zatvarnjem i otvaranjem formi



    }
}
