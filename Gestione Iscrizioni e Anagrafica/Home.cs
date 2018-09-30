using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gestione_Iscrizioni_e_Anagrafica {

    public partial class Home : Form {

        public Home() {
            InitializeComponent();
            panelLayout.Height = btnDashboard.Height;
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        #region Animation

        private void btnReduceIcons_Click(object sender, EventArgs e) {
            if (panelMenu.Size.Width == 172) {
                panelMenu.Size = new Size(57, panelMenu.Height);
                btnReduceIconsClone.Visible = true;
                pictureBoxLogo.Hide();
            }
            else if (panelMenu.Size.Width == 57) {
                btnReduceIconsClone.Visible = false;
                panelMenu.Size = new Size(172, panelMenu.Height);
                pictureBoxLogo.Show();
            }
        }

        #endregion Animation

        private void btnEsci_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnDashboard_Click(object sender, EventArgs e) {
            // Lateral Panel Movement
            panelLayout.Height = btnDashboard.Height;
            panelLayout.Top = btnDashboard.Top;
        }

        private void btnEventi_Click(object sender, EventArgs e) {
            // Lateral Panel Movement
            panelLayout.Height = btnEventi.Height;
            panelLayout.Top = btnEventi.Top;
        }

        private void btnAnagrafiche_Click(object sender, EventArgs e) {
            // Lateral Panel Movement
            panelLayout.Height = btnAnagrafiche.Height;
            panelLayout.Top = btnAnagrafiche.Top;
        }

        private void btnImpostazioni_Click(object sender, EventArgs e) {
            // Lateral Panel Movement
            panelLayout.Height = btnImpostazioni.Height;
            panelLayout.Top = btnImpostazioni.Top;
        }
    }
}