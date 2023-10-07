using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clean_Resources {
    public partial class FrmAddClient : Form {
        public FrmAddClient() {
            InitializeComponent();
        }
        
        private void btnOrganization_Click(object sender, EventArgs e) 
        {
            FrmAddOrganization frmAddOrganization = new FrmAddOrganization();
            Hide();
            frmAddOrganization.Show();
            frmAddOrganization.BringToFront();
            Close();
        }
        // Klikom na gumb btnOrganization odnosno "Tvrtka", kreira se nova forma FrmAddOrganization, sakriva se trenutna forma, te se prikazuje nova forma ispred ostalih elemenata. 
        // Sakriva se ova forma.


        private void btnSingleton_Click(object sender, EventArgs e) 
        {
            FrmAddSingleton frmAddSingleton = new FrmAddSingleton();
            Hide();
            frmAddSingleton.Show();
            Close();
        }
        // Klikom na gumb btnSingleton odnosno "Pojedinac", kreira se nova forma FrmAddSingleton, sakriva se trenutna forma, te se prikazuje nova forma ispred ostalih elemenata. 
        // Sakriva se ova forma.


        private void FrmAddClient_Load(object sender, EventArgs e) 
        {

        }
    }
}
