using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Gestione_Iscrizioni_e_Anagrafica {

    public partial class Login : Form {

        public Login() {
            InitializeComponent();
        }

        #region GlobalVariablesDatabase

        private OleDbConnection con = new OleDbConnection(ConnectionFunc.connString);
        private OleDbCommand cmd = new OleDbCommand();
        private int i = 0;

        #endregion GlobalVariablesDatabase

        // Login Database
        private void bunifuThinButton21_Click(object sender, EventArgs e) {
            if (ConnectionFunc.TryLogin(textboxUsername.Text, textboxPassword.Text, lblLog)) {
                this.Hide();
                new Home().Show();
            }
            else {
                lblLog.Text = "Credenziali errate. Riprovare.";
                lblLog.ForeColor = Color.Red;
            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        // Forgot Password
        private void lblForgetPassword_Click(object sender, EventArgs e) {
            new PasswordForget().Show();
            this.Hide();
        }

        private void textboxUsername_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                bunifuThinButton21_Click(this, new EventArgs());
            }
        }

        private void textboxPassword_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                bunifuThinButton21_Click(this, new EventArgs());
            }
        }
    }
}