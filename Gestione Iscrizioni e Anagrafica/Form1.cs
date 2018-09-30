using System;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Drawing;

namespace Gestione_Iscrizioni_e_Anagrafica {

    public partial class Login : Form {

        public Login() {
            InitializeComponent();
        }

        // Login Database
        private void bunifuThinButton21_Click(object sender, EventArgs e) {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\database.mdb");
            OleDbCommand cmd = new OleDbCommand();
            int i = 0;

            try {
                if ((textboxUsername.Text == string.Empty) || (textboxPassword.Text == string.Empty)) {
                    lblLog.Text = "Credenziali errate. Riprovare.";
                    lblLog.ForeColor = Color.Red;
                }

                cmd = new OleDbCommand("select count(*) from logins where username='" + textboxUsername.Text + "' AND password='" + textboxPassword.Text + "'", con);
                if (con.State == System.Data.ConnectionState.Closed) {
                    con.Open();
                    i = (int)cmd.ExecuteScalar();
                }
                con.Close();
                if (i > 0) {
                    Home home = new Home();
                    this.Hide();
                    home.Show();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            };
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        // Forgot Password
        private void lblForgetPassword_Click(object sender, EventArgs e) {
        }

        private void bunifuGradientPanel_Paint(object sender, PaintEventArgs e) {
            // NULL DO NOT DELETE
        }
    }
}