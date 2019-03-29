using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialTransport_lab
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private string login = "";
        private string password = "";
        private bool userIsLogged = false;

        public Form1()
        {
            InitializeComponent();
            loginPage.UserLoggedIn += getLoginData;
        }

        public void getLoginData()
        {
            login = loginPage.Login;
            password = loginPage.Password;
            dataGridViewPage1.getLoginData(login, password);
            userIsLogged = true;
            loginPage.Visible = false;
            openLoginPage.Text = "Выйти";
            getRoute.Visible = true;
            getStop.Visible = true;
            getTransport.Visible = true;
            getTransportToRoute.Visible = true;
        }

        private void exitButton_MouseClick(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void openLoginPage_MouseClick(object sender, MouseEventArgs e)
        {
            sideBtnPanel.Height = openLoginPage.Height;
            sideBtnPanel.Top = openLoginPage.Top;

            loginPage.Visible = true;
            loginPage.BringToFront();
            dataGridViewPage1.SendToBack();
            openLoginPage.Text = "Войти";
            dataGridViewPage1.AdminPanel(false);

            if (userIsLogged)
            {
                getRoute.Visible = false;
                getStop.Visible = false;
                getTransport.Visible = false;
                getTransportToRoute.Visible = false;
            }
        }

        private void getRoute_MouseClick(object sender, MouseEventArgs e)
        {
            if (login == "administrator" || login == "route_manager" || login == "stop_manager")
                dataGridViewPage1.AdminPanel(true);
            else
                dataGridViewPage1.AdminPanel(false);

            sideBtnPanel.Height = getRoute.Height;
            sideBtnPanel.Top = getRoute.Top;
            dataGridViewPage1.GetRouteData();
            dataGridViewPage1.BringTableToFront();
            dataGridViewPage1.BringToFront();
        }

        private void getStop_MouseClick(object sender, MouseEventArgs e)
        {
            if (login == "administrator" || login == "stop_manager")
                dataGridViewPage1.AdminPanel(true);
            else
                dataGridViewPage1.AdminPanel(false);

            sideBtnPanel.Height = getStop.Height;
            sideBtnPanel.Top = getStop.Top;
            dataGridViewPage1.GetStopData();
            dataGridViewPage1.BringTableToFront();
            dataGridViewPage1.BringToFront();
        }

        private void getTransport_MouseClick(object sender, MouseEventArgs e)
        {
            if (login == "administrator" || login == "transport_manager")
                dataGridViewPage1.AdminPanel(true);
            else
                dataGridViewPage1.AdminPanel(false);

            sideBtnPanel.Height = getTransport.Height;
            sideBtnPanel.Top = getTransport.Top;
            dataGridViewPage1.GetTransportData();
            dataGridViewPage1.BringTableToFront();
            dataGridViewPage1.BringToFront();
        }

        private void getTransportToRoute_MouseClick(object sender, MouseEventArgs e)
        {
            if (login == "administrator" || login == "transport_manager" || login == "route_manager")
                dataGridViewPage1.AdminPanel(true);
            else
                dataGridViewPage1.AdminPanel(false);

            sideBtnPanel.Height = getTransportToRoute.Height;
            sideBtnPanel.Top = getTransportToRoute.Top;
            dataGridViewPage1.GetTransportToRouteData();
            dataGridViewPage1.BringTableToFront();
            dataGridViewPage1.BringToFront();
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
