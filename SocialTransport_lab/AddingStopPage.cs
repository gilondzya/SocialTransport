using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialTransport_lab
{
    public partial class AddingStopPage : UserControl
    {
        public delegate void Added();
        public event Added StopWasAdded;

        SocialTransportDB socialtransportDB = new SocialTransportDB();
        private string login;
        private string password;
        private int stopId;
        public AddingStopPage()
        {
            InitializeComponent();
        }

        public void loadAddingStopPage(int stopId, string stopName, string login, string password)
        {
            stopNameTextBox.Text = stopName;
            emptyLine.Visible = false;

            if (stopName == "")
                addRecordToStopTable.Text = "Добавить";
            else
                addRecordToStopTable.Text = "Сохранить";

            this.login = login;
            this.password = password;
            this.stopId = stopId;
        }

        private void addRecordToStopTable_MouseClick(object sender, MouseEventArgs e)
        {
            emptyLine.Visible = false;

            if (stopNameTextBox.Text != "")
            {
                string stopName = stopNameTextBox.Text;
                while (stopName[0] == ' ')
                {
                    stopName = stopName.Remove(0, 1);
                }

                while (stopName[stopName.Length - 1] == ' ')
                {
                    stopName = stopName.Remove(stopName.Length - 1, 1);
                }

                if (stopName == "")
                {
                    emptyLine.Text = "ВВЕДЕНО НЕВЕРНОЕ НАЗВАНИЕ ОСТАНОВКИ!!";
                    emptyLine.Visible = true;
                    return;
                }

                if (addRecordToStopTable.Text == "Добавить")
                {
                    if (!socialtransportDB.doesStopExist(stopName, login, password))
                    {
                        socialtransportDB.addNewRecordToStopTable(stopName, login, password);
                        StopWasAdded();
                    }
                    else
                    {
                        emptyLine.Text = "ТАКАЯ ЗАПИСЬ УЖЕ СУЩЕСТВУЕТ!";
                        emptyLine.Visible = true;
                    }
                }
                else
                {
                    if (socialtransportDB.updateRecordFromStopTable(stopId, stopName, login, password))
                        StopWasAdded();
                    else
                    {
                        emptyLine.Text = "ТАКАЯ ЗАПИСЬ УЖЕ СУЩЕСТВУЕТ!";
                        emptyLine.Visible = true;
                    }
                }
            }
            else
            {
                emptyLine.Text = "ВВЕДИТЕ НЕПУСТУЮ СТРОКУ!";
                emptyLine.Visible = true;
            }
        }
    }
}
