using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestione_Iscrizioni_e_Anagrafica {

    public partial class PasswordForget : Form {

        public PasswordForget() {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnResetPassword_Click(object sender, EventArgs e) {
            if (txtboxNewPassword.Text == txtboxConfirmPassword.Text) {
                try {
                    ConnectionFunc.ResetPassword(txtboxNewPassword.Text, lblLog);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); };
            }
            else {
                lblLog.Text = "La password non corrisponde. Riprovare.";
                lblLog.ForeColor = Color.Red;
            }
        }

        private void lblReturnBack_Click(object sender, EventArgs e) {
            this.Close();
            new Login().Show();
        }
    }
}