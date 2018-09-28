using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestione_Iscrizioni_e_Anagrafica
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReduceIcons_Click(object sender, EventArgs e)
        {
            Console.WriteLine(panelMenu.Size.Width);
            if (panelMenu.Size.Width == 172)
            {
                //panelMenu.Size = new Size(60, panelMenu.Height);
                btnReduceIcons.Location = new Point(0, 15 );
                pictureBoxLogo.Hide();
            }

            else if(panelMenu.Size.Width == 60)
                panelMenu.Size = new Size(172, panelMenu.Height);
                btnReduceIcons.Location = new Point(176, 15);
                pictureBoxLogo.Show();
        }
    }
}
