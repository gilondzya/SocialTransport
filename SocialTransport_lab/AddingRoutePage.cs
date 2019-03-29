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
    public partial class AddingRoutePage : UserControl
    {
        public delegate void Added();
        public event Added RouteWasAdded;

        SocialTransportDB socialtransportDB = new SocialTransportDB();
        private string login;
        private string password;
        private int routeId;
        public AddingRoutePage()
        {
            InitializeComponent();
        }

        public void loadAddingRoutePage(int routeId, string routeName, int numOfStops, string nameOfStart, string nameOfFinish, float distance, int fare, string login, string password)
        {
            startComboBox.Items.Clear();
            finishComboBox.Items.Clear();
            startComboBox.ResetText();
            finishComboBox.ResetText();
            startComboBox.SelectedIndex = -1;
            finishComboBox.SelectedIndex = -1;
            routeNameTextBox.Text = routeName;

            if (numOfStops != 0)
                numOfStopsTextBox.Text = numOfStops.ToString();
            else
                numOfStopsTextBox.Text = "";

            if (distance != 0)
                distanceTextBox.Text = distance.ToString();
            else
                distanceTextBox.Text = "";

            if (fare != 0)
                fareTextBox.Text = fare.ToString();
            else
                fareTextBox.Text = "";

            if (routeName == "" && numOfStops == 0 && nameOfStart == "" && nameOfFinish == "" && distance == 0 && fare == 0)
                addingRecordToRouteTable.Text = "Добавить";
            else
                addingRecordToRouteTable.Text = "Сохранить";

            emptyTextBoxLabel.Visible = false;
            this.login = login;
            this.password = password;
            this.routeId = routeId;

            List<List<string>> stlist = socialtransportDB.stopDataTableConnection(login, password);

            int i = 0;
            while (i < stlist.Count)
            {
                startComboBox.Items.Add(stlist[i].ElementAt(1));
                if (stlist[i].ElementAt(1) == nameOfStart)
                    startComboBox.SelectedIndex = startComboBox.FindString(nameOfStart);

                finishComboBox.Items.Add(stlist[i].ElementAt(1));
                if (stlist[i].ElementAt(1) == nameOfFinish)
                    finishComboBox.SelectedIndex = finishComboBox.FindString(nameOfFinish);
                i++;
            }
        }

        private void addingRecordToRouteTable_MouseClick(object sender, MouseEventArgs e)
        {
            if (routeNameTextBox.Text != "" && numOfStopsTextBox.Text != "" && startComboBox.SelectedText != null && finishComboBox.SelectedText != null && distanceTextBox.Text != "" && fareTextBox.Text != "")
            {
                string routeName = routeNameTextBox.Text;
                while (routeName[0] == ' ')
                {
                    routeName = routeName.Remove(0, 1);
                }

                while (routeName[routeName.Length - 1] == ' ')
                {
                    routeName = routeName.Remove(routeName.Length - 1, 1);
                }

                if (routeName == "")
                {
                    emptyTextBoxLabel.Text = "ВВЕДЕНО НЕВЕРНОЕ ИМЯ МАРШРУТА!";
                    emptyTextBoxLabel.Visible = true;
                    return;
                }

                if (Int32.Parse(numOfStopsTextBox.Text) < 3)
                {
                    emptyTextBoxLabel.Text = "ЧИСЛО ОСТАНОВОК НЕ МОЖЕТ БЫТЬ МЕНЬШЕ 3!";
                    emptyTextBoxLabel.Visible = true;
                    return;
                }

                if (float.Parse(distanceTextBox.Text) < 10.0)
                {
                    emptyTextBoxLabel.Text = "ДЛИНА МАРШРУТА НЕ МОЖЕТ БЫТЬ МЕНЬШЕ 10!";
                    emptyTextBoxLabel.Visible = true;
                    return;
                }

                if (float.Parse(fareTextBox.Text) < 17.0)
                {
                    emptyTextBoxLabel.Text = "СТОИМОСТЬ ПРОЕЗДА НЕ МОЖЕТ БЫТЬ МЕНЬШЕ 17!";
                    emptyTextBoxLabel.Visible = true;
                    return;
                }

                if (addingRecordToRouteTable.Text == "Добавить")
                {
                    if (!socialtransportDB.doesRouteExist(routeName, login, password))
                    {
                        socialtransportDB.addNewRecordToRouteTable(Int32.Parse(numOfStopsTextBox.Text), startComboBox.SelectedItem.ToString(), finishComboBox.SelectedItem.ToString(), float.Parse(distanceTextBox.Text), float.Parse(fareTextBox.Text), routeName, login, password);
                        RouteWasAdded();
                    }
                }

                if (addingRecordToRouteTable.Text == "Сохранить")
                {
                    if (socialtransportDB.updateRecordFromRouteTable(routeId, Int32.Parse(numOfStopsTextBox.Text), startComboBox.SelectedItem.ToString(), finishComboBox.SelectedItem.ToString(), float.Parse(distanceTextBox.Text), float.Parse(fareTextBox.Text), routeNameTextBox.Text, login, password))
                        RouteWasAdded();
                    else
                    {
                        emptyTextBoxLabel.Text = "МАРШРУТ С ТАКИМ ИМЕНЕМ УЖЕ СУЩЕСТВУЕТ!";
                        emptyTextBoxLabel.Visible = true;
                    }
                }

                emptyTextBoxLabel.Text = "МАРШРУТ С ТАКИМ ИМЕНЕМ УЖЕ СУЩЕСТВУЕТ!";
                emptyTextBoxLabel.Visible = true;
            }
            else
            {
                emptyTextBoxLabel.Text = "ВСЕ ПОЛЯ ДОЛЖНЫ БЫТЬ ЗАПОЛНЕНЫ!";
                emptyTextBoxLabel.Visible = true;
            }
        }

        private void numOfStopsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void distanceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void fareTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
