using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace SocialTransport_lab
{
    public partial class DataGridViewPage : UserControl
    {
        List<List<string>> dataItems = new List<List<string>>();
        SocialTransportDB socialtransportDB = new SocialTransportDB();
        DataGridViewRow selectedRow;
        private string login = "";
        private string password = "";
        private int currentPage = 0;
        private int index = -1;

        public DataGridViewPage()
        {
            InitializeComponent();
            addingRoutePage1.RouteWasAdded += this.GetRouteData;
            addingStopPage1.StopWasAdded += this.GetStopData;
            addingTransportPage1.TransportWasAdded += this.GetTransportData;
            addingTransportToRoutePage1.TransportToRouteWasAdded += this.GetTransportToRouteData;
        }

        public void getLoginData(string login, string password)
        {
            this.login = login;
            this.password = password;
        }

        public void AdminPanel(bool state)
        {
            Add.Visible = state;
            Edit.Visible = state;
            Delete.Visible = state;
        }

        public void GetRouteData()
        {
            currentPage = 1;
            BringTableToFront();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridViewDesignCells();
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[3].Width = 190;
            dataGridView1.Columns[4].Width = 190;
            dataGridView1.Columns[0].Name = "id";
            dataGridView1.Columns[1].Name = "Название маршрута";
            dataGridView1.Columns[2].Name = "Количество остановок";
            dataGridView1.Columns[3].Name = "Начальная остановка";
            dataGridView1.Columns[4].Name = "Конечная остановка";
            dataGridView1.Columns[5].Name = "Длина маршрута";
            dataGridView1.Columns[6].Name = "Стоимость проезда";

            dataItems = socialtransportDB.routeDataTableConnection(login, password);
            for (int i = 0; i < dataItems.Count; i++)
            {
                dataGridView1.Rows.Add(dataItems[i].ToArray());
            }
        }

        public void GetStopData()
        {
            currentPage = 2;
            BringTableToFront();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridViewDesignCells();
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Width = 190;
            dataGridView1.Columns[0].Name = "id";
            dataGridView1.Columns[1].Name = "Название остановки";

            dataItems = socialtransportDB.stopDataTableConnection(login, password);
            for (int i = 0; i < dataItems.Count; i++)
            {
                dataGridView1.Rows.Add(dataItems[i].ToArray());
            }
        }

        public void GetTransportData()
        {
            currentPage = 3;
            BringTableToFront();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridViewDesignCells();
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[0].Name = "id";
            dataGridView1.Columns[1].Name = "Вид транспорта";
            dataGridView1.Columns[2].Name = "Средняя скорость";
            dataGridView1.Columns[3].Name = "Вместимость";

            dataItems = socialtransportDB.transportDataTableConnection(login, password);
            for (int i = 0; i < dataItems.Count; i++)
            {
                dataGridView1.Rows.Add(dataItems[i].ToArray());
            }
        }

        public void GetTransportToRouteData()
        {
            currentPage = 4;
            BringTableToFront();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridViewDesignCells();
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Width = 190;
            dataGridView1.Columns[0].Name = "id";
            dataGridView1.Columns[1].Name = "Вид транспорта";
            dataGridView1.Columns[2].Name = "Номер маршрута";

            dataItems = socialtransportDB.transporttorouteDataTableConnection(login, password);
            for (int i = 0; i < dataItems.Count; i++)
            {
                dataGridView1.Rows.Add(dataItems[i].ToArray());
            }
        }

        private void dataGridViewDesignCells()
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(179, 121, 163);
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(179, 121, 163);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(179, 121, 163);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Regular);

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersHeight = 50;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(179, 121, 163);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(41, 39, 40);
        }

        private void Add_MouseClick(object sender, MouseEventArgs e)
        {
            inputError.Visible = false;
            inputError.SendToBack();

            if (currentPage == 1)
            {
                addingRoutePage1.loadAddingRoutePage(0, "", 0, "", "", 0, 0, login, password);
                addingRoutePage1.BringToFront();
            }
            else
                if (currentPage == 2)
                {
                    addingStopPage1.loadAddingStopPage(0, "", login, password);
                    addingStopPage1.BringToFront();
                }
                else
                    if (currentPage == 3)
                    {
                        addingTransportPage1.loadAddingTransportPage(0, "", 0, 0, login, password);
                        addingTransportPage1.BringToFront();
                    }
                    else
                        if (currentPage == 4)
                        {
                            addingTransportToRoutePage1.loadAddingTransportToRoutePage(0, "", "", login, password);
                            addingTransportToRoutePage1.BringToFront();
                        }
        }

        public void BringTableToFront()
        {
            dataGridView1.BringToFront();
            Add.BringToFront();
            Edit.BringToFront();
            Delete.BringToFront();
        }

        private void Edit_MouseClick(object sender, MouseEventArgs e)
        {
            inputError.Visible = false;
            inputError.SendToBack();

            if (index > -1 && selectedRow.Cells.Count > 0)
            {
                if (currentPage == 1)
                {
                    addingRoutePage1.loadAddingRoutePage(Int32.Parse(selectedRow.Cells[0].Value.ToString()), selectedRow.Cells[1].Value.ToString(), Int32.Parse(selectedRow.Cells[2].Value.ToString()), selectedRow.Cells[3].Value.ToString(), selectedRow.Cells[4].Value.ToString(), float.Parse(selectedRow.Cells[5].Value.ToString()), Int32.Parse(selectedRow.Cells[6].Value.ToString()), login, password);
                    addingRoutePage1.BringToFront();
                }

                if (currentPage == 2)
                {
                    addingStopPage1.loadAddingStopPage(Int32.Parse(selectedRow.Cells[0].Value.ToString()), selectedRow.Cells[1].Value.ToString(), login, password);
                    addingStopPage1.BringToFront();
                }

                if (currentPage == 3)
                {
                    addingTransportPage1.loadAddingTransportPage(Int32.Parse(selectedRow.Cells[0].Value.ToString()), selectedRow.Cells[1].Value.ToString(), float.Parse(selectedRow.Cells[2].Value.ToString()), Int32.Parse(selectedRow.Cells[3].Value.ToString()), login, password);
                    addingTransportPage1.BringToFront();
                }

                if (currentPage == 4)
                {
                    addingTransportToRoutePage1.loadAddingTransportToRoutePage(Int32.Parse(selectedRow.Cells[0].Value.ToString()), selectedRow.Cells[1].Value.ToString(), selectedRow.Cells[2].Value.ToString(), login, password);
                    addingTransportToRoutePage1.BringToFront();
                }

                index = -1;
                selectedRow = null;
            }
            else
            {
                inputError.Text = "ВЫБЕРИТЕ СТРОКУ!";
                inputError.Visible = true;
                inputError.BringToFront();
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.index = e.RowIndex;
            selectedRow = dataGridView1.Rows[index];
        }

        private void Delete_MouseClick(object sender, MouseEventArgs e)
        {
            inputError.Visible = false;
            inputError.SendToBack();

            if (index > -1 && selectedRow.Cells.Count > 0)
            {
                if (currentPage == 1)
                {
                    socialtransportDB.deleteRecordFromRouteTable(Int32.Parse(selectedRow.Cells[0].Value.ToString()), login, password);
                    GetRouteData();
                }

                if (currentPage == 2)
                {
                    socialtransportDB.deleteRecordFromStopTable(Int32.Parse(selectedRow.Cells[0].Value.ToString()), login, password);
                    GetStopData();
                }

                if (currentPage == 3)
                {
                    socialtransportDB.deleteRecordFromTransportTable(Int32.Parse(selectedRow.Cells[0].Value.ToString()), login, password);
                    GetTransportData();
                }

                if (currentPage == 4)
                {
                    socialtransportDB.deleteRecordFromTransportToRouteTable(Int32.Parse(selectedRow.Cells[0].Value.ToString()), login, password);
                    GetTransportToRouteData();
                }

                index = -1;
                selectedRow = null;
            }
            else
            {
                inputError.Text = "ВЫБЕРИТЕ СТРОКУ!";
                inputError.Visible = true;
                inputError.BringToFront();
            }
        }
    }
}
