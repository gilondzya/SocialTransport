using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace SocialTransport_lab
{
    public partial class LoginPage : UserControl
    {
        private string login = "";
        private string password = "";

        public delegate void LoggedIn();
        public event LoggedIn UserLoggedIn;

        public LoginPage()
        {
            InitializeComponent();
        }

        public string Password { get => password; set => password = value; }

        public string Login { get => login; set => login = value; }

        public bool isLoggedIn(string login, string password)
        {
            try
            {
                string connstring = "Server=127.0.0.1; Port=5432; User Id=" + login + "; Password=" + password + "; Database = SocialTransport;";
                NpgsqlConnection connection = new NpgsqlConnection(connstring);
                connection.Open();
                connection.Close();
            }
            catch
            {
                return false;
            }

            return true;
        }

        private void loginButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (loginTextBox.Text != "" && passwordTextBox.Text != "")
            {
                Login = loginTextBox.Text;
                Password = passwordTextBox.Text;

                if (isLoggedIn(login, password))
                {
                    wrongLoginInput.Visible = false;
                    loginTextBox.Text = "";
                    passwordTextBox.Text = "";

                    if (UserLoggedIn != null)
                        UserLoggedIn();
                }

                return;
            }

            wrongLoginInput.Visible = true;
        }
    }
}
