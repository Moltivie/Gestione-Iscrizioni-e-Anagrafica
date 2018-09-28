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

    public partial class Login : Form {

        public Login() {
            InitializeComponent();
        }

        Home home = new Home();

        private void bunifuThinButton21_Click(object sender, EventArgs e) {
            if (textboxUsername.Text == "" && textboxPassword.Text == "")
            {
                this.Hide();
                home.Show();
            }
               
            else
            {
                lblLog.ForeColor = Color.Red;
                lblLog.Text = "Le credenziali sono errate. Riprova.";
            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}