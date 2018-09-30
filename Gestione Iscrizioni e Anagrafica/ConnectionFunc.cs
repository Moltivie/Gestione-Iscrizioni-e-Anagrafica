using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Gestione_Iscrizioni_e_Anagrafica {

    internal class ConnectionFunc {
        public static string connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\database.mdb";

        #region GlobalVariablesDatabase

        private static OleDbConnection con = new OleDbConnection(connString);

        private static OleDbCommand cmd = new OleDbCommand();

        private static int i = 0;

        #endregion GlobalVariablesDatabase

        #region TryLogin

        public static bool TryLogin(string username, string password, Bunifu.Framework.UI.BunifuCustomLabel label) {
            try {
                if ((username == string.Empty) || (password == string.Empty)) {
                    label.Text = "Credenziali errate. Riprovare.";
                    label.ForeColor = Color.Red;
                }

                cmd = new OleDbCommand("select count(*) from logins where username='" + username + "' AND password='" + Crypter.Encrypt(password) + "'", con);
                if (con.State == System.Data.ConnectionState.Closed) {
                    con.Open();
                    i = (int)cmd.ExecuteScalar();
                }
                con.Close();
                if (i > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
                return false;
            };
        }

        #endregion TryLogin
    }
}