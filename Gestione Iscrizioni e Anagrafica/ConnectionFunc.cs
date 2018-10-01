using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Gestione_Iscrizioni_e_Anagrafica {

    internal class ConnectionFunc {
        public static string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\database.mdb";

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

        #region ResetPassword

        public static void ResetPassword(string new_password, Bunifu.Framework.UI.BunifuCustomLabel label) {
            //string query = "update logins set password='" + Crypter.Encrypt(new_password) + "' where username=admin";
            string query = "UPDATE logins SET [password]='" + Crypter.Encrypt(new_password) + "' WHERE username='admin'";
            cmd.CommandType = System.Data.CommandType.Text;

            cmd = new OleDbCommand(query, con);
            con.Open();
            try {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Errore");
                label.Text = "Errore! Password non modificata.";
                label.ForeColor = Color.Red;
            }
            finally {
                label.Text = "Password modificata! Accedere con la nuova password.";
                label.ForeColor = Color.Green;
            }

            con.Close();
        }

        #endregion ResetPassword
    }
}