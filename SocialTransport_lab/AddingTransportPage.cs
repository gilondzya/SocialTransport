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
    public partial class AddingTransportPage : UserControl
    {
        public delegate void Added();
        public event Added TransportWasAdded;

        SocialTransportDB socialtransportDB = new SocialTransportDB();
        private string login;
        private string password;
        private int transportId;

        public AddingTransportPage()
        {
            InitializeComponent();
        }

        public void loadAddingTransportPage(int transportId, string typeOfTransport, float averageSpeed, int numOfPasswngersPerTrip, string login, string password)
        {
            errorLabel.Visible = false;
            typeOfTransportTextBox.Text = typeOfTransport;

            if (averageSpeed != 0)
                averageSpeedTextBox.Text = averageSpeed.ToString();
            else
                averageSpeedTextBox.Text = "";

            if (numOfPasswngersPerTrip != 0)
                numOfPassengersPerTripTextBox.Text = numOfPasswngersPerTrip.ToString();
            else
                numOfPassengersPerTripTextBox.Text = "";

            if (typeOfTransport == "" && averageSpeed == 0 && numOfPasswngersPerTrip == 0)
                addingRecordToTransportTable.Text = "Добавить";
            else
                addingRecordToTransportTable.Text = "Сохранить";

            this.login = login;
            this.password = password;
            this.transportId = transportId;
        }

        private void addingRecordToTransportTable_MouseClick(object sender, MouseEventArgs e)
        {
            if (typeOfTransportTextBox.Text != "" && averageSpeedTextBox.Text != "" && numOfPassengersPerTripTextBox.Text != "")
            {
                string typeOfTransport = typeOfTransportTextBox.Text;
                while (typeOfTransport[0] == ' ')
                {
                    typeOfTransport = typeOfTransport.Remove(0, 1);
                }

                while (typeOfTransport[typeOfTransport.Length - 1] == ' ')
                {
                    typeOfTransport = typeOfTransport.Remove(typeOfTransport.Length - 1, 1);
                }

                if (typeOfTransport == "")
                {
                    errorLabel.Text = "ВВЕДЕН НЕВЕРНЫЙ ВИД ТРАНСПОРТА!";
                    errorLabel.Visible = true;
                    return;
                }

                if (Int32.Parse(averageSpeedTextBox.Text) < 10)
                {
                    errorLabel.Text = "СРЕДНЯЯ СКОРОСТЬ НЕ МОЖЕТ БЫТЬ НИЖЕ 10!";
                    errorLabel.Visible = true;
                    return;
                }

                if (float.Parse(numOfPassengersPerTripTextBox.Text) < 15)
                {
                    errorLabel.Text = "ВМЕСТИМОСТЬ НЕ МОЖЕТ БЫТЬ МЕНЬШЕ 15!";
                    errorLabel.Visible = true;
                    return;
                }

                if (addingRecordToTransportTable.Text == "Добавить")
                {
                    if (!socialtransportDB.doesTransportExist(typeOfTransport, login, password))
                    {
                        socialtransportDB.addNewRecordToTransportTable(typeOfTransport, float.Parse(averageSpeedTextBox.Text), Int32.Parse(numOfPassengersPerTripTextBox.Text), login, password);
                        TransportWasAdded();
                    }
                    else
                    {
                        errorLabel.Text = "ТАКОЙ ВИД ТРАНСПОРТА УЖЕ СУЩЕСТВУЕТ!";
                        errorLabel.Visible = true;
                    }
                }
                else
                {
                    if (socialtransportDB.updateRecordFromTransportTable(transportId, typeOfTransport, float.Parse(averageSpeedTextBox.Text), Int32.Parse(numOfPassengersPerTripTextBox.Text), login, password))
                        TransportWasAdded();
                    else
                    {
                        errorLabel.Text = "ТАКОЙ ВИД ТРАНСПОРТА УЖЕ СУЩЕСТВУЕТ!";
                        errorLabel.Visible = true;
                    }
                }
            }
            else
            {
                errorLabel.Text = "ВСЕ ПОЛЯ ДОЛЖНЫ БЫТЬ ЗАПОЛНЕНЫ!";
                errorLabel.Visible = true;
            }
        }

        private void averageSpeedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void numOfPassengersPerTripTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
