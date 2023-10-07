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
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Clean_Resources {
    
    public partial class FrmLogin : Form {
        
        public FrmLogin() 
        {
            InitializeComponent();
        }
        private void FrmLogin_Load(object sender, EventArgs e) 
        {

        }
        public static Manager LoggedManager { get; set; }

        // Deklaracija objekta iz klasa koje se koriste pri prijavi.

        public void btnLogin_Click(object sender, EventArgs e) 
        {
            LoggedManager = ManagerRepository.GetManager(txtUsername.Text);
            if (LoggedManager != null && LoggedManager.CheckPassword(txtPassword.Text))
            { 
                MessageBox.Show("Dobrodošli upraviteljice!", "Uspješna prijava!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmClients frmClient = new FrmClients();
                Hide();
                frmClient.ShowDialog();
                Close();
            } 
            else
            {
                MessageBox.Show("GREŠKA!", "Neuspješna prijava!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Klikom na btnLogin započinje metoda.
        // Definira se objekt baziran na metodi GetManager(username) prema kojoj se iz repozitorija organizatora posla vadi organizator s odgovarajućim imenom
        // Ako se kreirao objekt, odnosno ako je SQL upit vratio barem jedan redak tablice, prijava je uspješna.
        // Otvara se prozor sa porukom, kreira se nova forma, sakriva se trenutna, te se ulazi u dijalog s novom formom, odnosno otvara se sučelje aplikacije.
        // Ako nije postojao niti jedan kreiran objekt, sustav izbacuje prozor s porukom pogreške. 
        // Nastavlja se pokušaj prijave.


    }
}
