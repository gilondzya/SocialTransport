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
    public partial class AddingTransportToRoutePage : UserControl
    {
        public delegate void Added();
        public event Added TransportToRouteWasAdded;

        SocialTransportDB socialtransportDB = new SocialTransportDB();
        private string login;
        private string password;
        private int transportToRouteId;
        public AddingTransportToRoutePage()
        {
            InitializeComponent();
        }

        public void loadAddingTransportToRoutePage(int transportToRouteId, string typeOfTransport, string routeName, string login, string password)
        {
            typeOfTransportComboBox.Items.Clear();
            routeNameComboBox.Items.Clear();

            typeOfTransportComboBox.ResetText();
            typeOfTransportComboBox.SelectedIndex = -1;

            routeNameComboBox.ResetText();
            routeNameComboBox.SelectedIndex = -1;

            emptyInput.Visible = false;

            if (typeOfTransport == "" && routeName == "")
                addingRecordToTransportToRouteTable.Text = "Добавить";
            else
                addingRecordToTransportToRouteTable.Text = "Сохранить";

            this.login = login;
            this.password = password;
            this.transportToRouteId = transportToRouteId;

            List<List<string>> tlist = socialtransportDB.transportDataTableConnection(login, password);
            List<List<string>> rlist = socialtransportDB.routeDataTableConnection(login, password); 

            int i = 0;
            while (i < tlist.Count)
            {
                typeOfTransportComboBox.Items.Add(tlist[i].ElementAt(1));
                if (tlist[i].ElementAt(1) == typeOfTransport)
                    typeOfTransportComboBox.SelectedIndex = typeOfTransportComboBox.FindString(typeOfTransport);
                i++;
            }
            i = 0;
            while (i < rlist.Count)
            {
                routeNameComboBox.Items.Add(rlist[i].ElementAt(1));
                if (rlist[i].ElementAt(1) == routeName)
                    routeNameComboBox.SelectedIndex = routeNameComboBox.FindString(routeName);
                i++;
            }
        }

        private void addingRecordToTransportToRouteTable_MouseClick(object sender, MouseEventArgs e)
        {
            emptyInput.Visible = false;

            if (typeOfTransportComboBox.SelectedText != null && routeNameComboBox.SelectedText != null)
            {
                if (addingRecordToTransportToRouteTable.Text == "Добавить")
                {
                    if (!socialtransportDB.doesTransportToRouteExist(typeOfTransportComboBox.SelectedItem.ToString(), routeNameComboBox.SelectedItem.ToString(), login, password))
                    {
                        socialtransportDB.addNewRecordToTransportToRouteTable(typeOfTransportComboBox.SelectedItem.ToString(), routeNameComboBox.SelectedItem.ToString(), login, password);
                        TransportToRouteWasAdded();
                    }
                    else
                    {
                        emptyInput.Text = "ТАКАЯ ЗАПИСЬ УЖЕ СУЩЕСТВУЕТ!";
                        emptyInput.Visible = true;
                    }
                }
                else
                {
                    if (socialtransportDB.updateRecordFromTransportToRouteTable(transportToRouteId, typeOfTransportComboBox.SelectedItem.ToString(), routeNameComboBox.SelectedItem.ToString(), login, password))
                        TransportToRouteWasAdded();
                    else
                    {
                        emptyInput.Text = "ТАКАЯ ЗАПИСЬ УЖЕ СУЩЕСТВУЕТ!";
                        emptyInput.Visible = true;
                    }
                }
            }
            else
            {
                emptyInput.Text = "ВСЕ ПОЛЯ ДОЛЖНЫ БЫТЬ ЗАПОЛНЕНЫ!";
                emptyInput.Visible = true;
            }
        }
    }
}
