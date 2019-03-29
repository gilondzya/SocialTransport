using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace SocialTransport_lab
{
    class SocialTransportDB
    {
        public List<List<string>> transportDataTableConnection(string login, string password)
        {
            try
            {
                string connstring = "Server=127.0.0.1; Port=5432; User Id=" + login + "; Password=" + password + "; Database = SocialTransport;";
                NpgsqlConnection connection = new NpgsqlConnection(connstring);
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM public.transport", connection);
                NpgsqlDataReader dataReader = command.ExecuteReader();

                List<List<string>> dataItems = new List<List<string>>();
                for (int i = 0; dataReader.Read(); i++)
                {
                    List<string> row = new List<string>();
                    row.Add(dataReader[0].ToString());
                    row.Add(dataReader[1].ToString());
                    row.Add(dataReader[2].ToString());
                    row.Add(dataReader[3].ToString());
                    dataItems.Add(row);
                }
                connection.Close();
                return dataItems;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        public List<List<string>> routeDataTableConnection(string login, string password)
        {
            try
            {
                string connstring = "Server=127.0.0.1; Port=5432; User Id=" + login + "; Password=" + password + "; Database = SocialTransport;";
                NpgsqlConnection connection = new NpgsqlConnection(connstring);
                connection.Open();
                NpgsqlCommand getRoute = new NpgsqlCommand("SELECT \"idRoute\", \"numOfStops\", st.\"stopName\", fin.\"stopName\", distance, fare, \"routeName\" FROM public.route INNER JOIN public.stop AS st ON \"idStart\" = st.\"idStop\" INNER JOIN public.stop AS fin ON \"idFinish\" = fin.\"idStop\"", connection);
                NpgsqlDataReader dataReader = getRoute.ExecuteReader();

                List<List<string>> dataItems = new List<List<string>>();
                for (int i = 0; dataReader.Read(); i++)
                {
                    List<string> row = new List<string>();
                    row.Add(dataReader[0].ToString());
                    row.Add(dataReader[6].ToString());
                    row.Add(dataReader[1].ToString());
                    row.Add(dataReader[2].ToString());
                    row.Add(dataReader[3].ToString());
                    row.Add(dataReader[4].ToString());
                    row.Add(dataReader[5].ToString());
                    dataItems.Add(row);
                }

                connection.Close();
                return dataItems;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        public List<List<string>> stopDataTableConnection(string login, string password)
        {
            try
            {
                string connstring = "Server=127.0.0.1; Port=5432; User Id=" + login + "; Password=" + password + "; Database = SocialTransport;";
                NpgsqlConnection connection = new NpgsqlConnection(connstring);
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM public.stop", connection);
                NpgsqlDataReader dataReader = command.ExecuteReader();

                List<List<string>> dataItems = new List<List<string>>();
                for (int i = 0; dataReader.Read(); i++)
                {
                    List<string> row = new List<string>();
                    row.Add(dataReader[0].ToString());
                    row.Add(dataReader[1].ToString());
                    dataItems.Add(row);
                }
                connection.Close();
                return dataItems;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        public List<List<string>> transporttorouteDataTableConnection(string login, string password)
        {
            try
            {
                string connstring = "Server=127.0.0.1; Port=5432; User Id=" + login + "; Password=" + password + "; Database = SocialTransport;";
                NpgsqlConnection connection = new NpgsqlConnection(connstring);
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("SELECT \"idTransportToRoute\", tr.\"typeOfTransport\", r.\"routeName\" FROM public.transporttoroute INNER JOIN public.transport AS tr ON transporttoroute.\"idTransport\" = tr.\"idTransport\" INNER JOIN public.route AS r ON transporttoroute.\"idRoute\" = r.\"idRoute\"", connection);
                NpgsqlDataReader dataReader = command.ExecuteReader();

                List<List<string>> dataItems = new List<List<string>>();
                for (int i = 0; dataReader.Read(); i++)
                {
                    List<string> row = new List<string>();
                    row.Add(dataReader[0].ToString());
                    row.Add(dataReader[1].ToString());
                    row.Add(dataReader[2].ToString());
                    dataItems.Add(row);
                }
                connection.Close();
                return dataItems;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        public void addNewRecordToRouteTable(int numOfStops, string startName, string finishName, float distance, float fare, string routeName, string login, string password)
        {
            try
            {
                int idStart = getStopIdByName(startName, login, password);
                int idFinish = getStopIdByName(finishName, login, password);

                string connstring = "Server=127.0.0.1; Port=5432; User Id=" + login + "; Password=" + password + "; Database = SocialTransport;";
                NpgsqlConnection connection = new NpgsqlConnection(connstring);
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM public.route", connection);
                NpgsqlDataReader dataReader = command.ExecuteReader();

                List<int> ids = new List<int>();
                for (int i = 0; dataReader.Read(); i++)
                {
                    ids.Add(Int32.Parse(dataReader[0].ToString()));
                }

                int id = 1;
                while (ids.Contains(id))
                {
                    id++;
                }

                connection.Close();

                NpgsqlConnection conn = new NpgsqlConnection(connstring);
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO public.route(\"idRoute\", \"numOfStops\", \"idStart\", \"idFinish\", distance, fare, \"routeName\") VALUES (" + id + ", " + numOfStops + ", " + idStart + ", " + idFinish + ", " + distance + ", " + fare + ", '" + routeName + "')", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        public void addNewRecordToStopTable(string stopName, string login, string password)
        {
            try
            {
                string connstring = "Server=127.0.0.1; Port=5432; User Id=" + login + "; Password=" + password + "; Database = SocialTransport;";
                NpgsqlConnection connection = new NpgsqlConnection(connstring);
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM public.stop", connection);
                NpgsqlDataReader dataReader = command.ExecuteReader();


                List<int> ids = new List<int>();
                for (int i = 0; dataReader.Read(); i++)
                {
                    ids.Add(Int32.Parse(dataReader[0].ToString()));
                }

                int id = 1;
                while (ids.Contains(id))
                {
                    id++;
                }

                connection.Close();

                if (id > 0)
                {
                    connection = new NpgsqlConnection(connstring);
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO public.stop(\"idStop\", \"stopName\") VALUES(" + id + ", '" + stopName + "');", connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        public void addNewRecordToTransportTable(string typeOfTransport, float averageSpeed, int numOfPassengers, string login, string password)
        {
            try
            {
                string connstring = "Server=127.0.0.1; Port=5432; User Id=" + login + "; Password=" + password + "; Database = SocialTransport;";
                NpgsqlConnection connection = new NpgsqlConnection(connstring);
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM public.transport", connection);
                NpgsqlDataReader dataReader = command.ExecuteReader();


                List<int> ids = new List<int>();
                for (int i = 0; dataReader.Read(); i++)
                {
                    ids.Add(Int32.Parse(dataReader[0].ToString()));
                }

                int id = 1;
                while (ids.Contains(id))
                {
                    id++;
                }

                connection.Close();

                if (id > 0)
                {
                    connection = new NpgsqlConnection(connstring);
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO public.transport(\"idTransport\", \"typeOfTransport\", \"averageSpeed\", \"numOfPassengersPerTrip\") VALUES(" + id + ", '" + typeOfTransport + "', " + averageSpeed + ", " + numOfPassengers + ");", connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        public void addNewRecordToTransportToRouteTable(string typeOfTransport, string routeName, string login, string password)
        {
            try
            {
                int idTransport = getTransportIdByName(typeOfTransport, login, password);
                int idRoute = getRouteIdByName(routeName, login, password);

                string connstring = "Server=127.0.0.1; Port=5432; User Id=" + login + "; Password=" + password + "; Database = SocialTransport;";
                NpgsqlConnection connection = new NpgsqlConnection(connstring);
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM public.transporttoroute", connection);
                NpgsqlDataReader dataReader = command.ExecuteReader();

                List<int> ids = new List<int>();
                for (int i = 0; dataReader.Read(); i++)
                {
                    ids.Add(Int32.Parse(dataReader[0].ToString()));
                }

                int id = 1;
                while (ids.Contains(id))
                {
                    id++;
                }

                connection.Close();

                NpgsqlConnection conn = new NpgsqlConnection(connstring);
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO public.transporttoroute(\"idTransportToRoute\", \"idTransport\", \"idRoute\") VALUES (" + id + ", " + idTransport + ", " + idRoute + ")", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        public bool updateRecordFromRouteTable(int routeId, int numOfStops, string startName, string finishName, float distance, float fare, string routeName, string login, string password)
        {
            try
            {
                int idStart = getStopIdByName(startName, login, password);
                int idFinish = getStopIdByName(finishName, login, password);
                if (getRouteIdByName(routeName, login, password) == routeId || !doesRouteExist(routeName, login, password))
                {
                    string connstring = "Server=127.0.0.1; Port=5432; User Id=" + login + "; Password=" + password + "; Database = SocialTransport;";
                    NpgsqlConnection conn = new NpgsqlConnection(connstring);
                    conn.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand("UPDATE public.route SET \"numOfStops\" = " + numOfStops + ", \"idStart\" = " + idStart + ", \"idFinish\" = " + idFinish + ", distance = " + distance + ", fare = " + fare + ", \"routeName\" = '" + routeName + "' WHERE \"idRoute\" = " + routeId, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                return false;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        public bool updateRecordFromStopTable(int stopId, string stopName, string login, string password)
        {
            try
            {
                if (getStopIdByName(stopName, login, password) == stopId || !doesStopExist(stopName, login, password))
                {
                    string connstring = "Server=127.0.0.1; Port=5432; User Id=" + login + "; Password=" + password + "; Database = SocialTransport;";
                    NpgsqlConnection conn = new NpgsqlConnection(connstring);
                    conn.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand("UPDATE public.stop SET \"stopName\" = '" + stopName + "' WHERE \"idStop\" = " + stopId, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                return false;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        public bool updateRecordFromTransportTable(int transportId, string typeOfTransport, float averageSpeed, int numOfPassengersPerTrip, string login, string password)
        {
            try
            {
                if (getTransportIdByName(typeOfTransport, login, password) == transportId || !doesTransportExist(typeOfTransport, login, password))
                {
                    string connstring = "Server=127.0.0.1; Port=5432; User Id=" + login + "; Password=" + password + "; Database = SocialTransport;";
                    NpgsqlConnection conn = new NpgsqlConnection(connstring);
                    conn.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand("UPDATE public.transport SET \"typeOfTransport\" = '" + typeOfTransport + "', \"averageSpeed\" = " + averageSpeed + ", \"numOfPassengersPerTrip\" = " + numOfPassengersPerTrip + " WHERE \"idTransport\" = " + transportId, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                return false;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        public bool updateRecordFromTransportToRouteTable(int transportToRouteId, string typeOfTransport, string routeName, string login, string password)
        {
            try
            {
                int transportId = getTransportIdByName(typeOfTransport, login, password);
                int routeId = getRouteIdByName(routeName, login, password);
                if (doesTransportToRouteExist(typeOfTransport, routeName, login, password))
                {
                    string connstring = "Server=127.0.0.1; Port=5432; User Id=" + login + "; Password=" + password + "; Database = SocialTransport;";
                    NpgsqlConnection conn = new NpgsqlConnection(connstring);
                    conn.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand("UPDATE public.transporttoroute SET \"idTransport\" = '" + transportId + "', \"idRoute\" = " + routeId + " WHERE \"idTransportToRoute\" = " + transportToRouteId, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                return false;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        public void deleteRecordFromRouteTable(int routeId, string login, string password)
        {
            try
            {
                string connstring = "Server=127.0.0.1; Port=5432; User Id=" + login + "; Password=" + password + "; Database = SocialTransport;";
                NpgsqlConnection conn = new NpgsqlConnection(connstring);
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM public.route WHERE \"idRoute\" = " + routeId, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        public void deleteRecordFromStopTable(int stopId, string login, string password)
        {
            try
            {
                string connstring = "Server=127.0.0.1; Port=5432; User Id=" + login + "; Password=" + password + "; Database = SocialTransport;";
                NpgsqlConnection conn = new NpgsqlConnection(connstring);
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM public.stop WHERE \"idStop\" = " + stopId, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        public void deleteRecordFromTransportTable(int transportId, string login, string password)
        {
            try
            {
                string connstring = "Server=127.0.0.1; Port=5432; User Id=" + login + "; Password=" + password + "; Database = SocialTransport;";
                NpgsqlConnection conn = new NpgsqlConnection(connstring);
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM public.transport WHERE \"idTransport\" = " + transportId, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        public void deleteRecordFromTransportToRouteTable(int transportToRouteId, string login, string password)
        {
            try
            {
                string connstring = "Server=127.0.0.1; Port=5432; User Id=" + login + "; Password=" + password + "; Database = SocialTransport;";
                NpgsqlConnection conn = new NpgsqlConnection(connstring);
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM public.transporttoroute WHERE \"idTransportToRoute\" = " + transportToRouteId, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        public bool doesRouteExist(string routeName, string login, string password)
        {
            try
            {
                string connstring = "Server=127.0.0.1; Port=5432; User Id=" + login + "; Password=" + password + "; Database = SocialTransport;";
                NpgsqlConnection connection = new NpgsqlConnection(connstring);
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM route WHERE \"routeName\" = '" + routeName + "'", connection);
                NpgsqlDataReader dataReader = command.ExecuteReader();

                List<List<string>> dataItems = new List<List<string>>();
                for (int i = 0; dataReader.Read(); i++)
                {
                    List<string> row = new List<string>();
                    row.Add(dataReader[0].ToString());
                    row.Add(dataReader[6].ToString());
                    dataItems.Add(row);
                }
                connection.Close();

                try
                {
                    if (dataItems[0][1] == routeName)
                        return true;
                }
                catch
                {
                    return false;
                }

                return false;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        public bool doesStopExist(string stopName, string login, string password)
        {
            try
            {
                string connstring = "Server=127.0.0.1; Port=5432; User Id=" + login + "; Password=" + password + "; Database = SocialTransport;";
                NpgsqlConnection connection = new NpgsqlConnection(connstring);
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM stop WHERE \"stopName\" = '" + stopName + "'", connection);
                NpgsqlDataReader dataReader = command.ExecuteReader();

                List<List<string>> dataItems = new List<List<string>>();
                for (int i = 0; dataReader.Read(); i++)
                {
                    List<string> row = new List<string>();
                    row.Add(dataReader[0].ToString());
                    row.Add(dataReader[1].ToString());
                    dataItems.Add(row);
                }
                connection.Close();

                try
                {
                    if (dataItems[0][1] == stopName)
                        return true;
                }
                catch
                {
                    return false;
                }

                return false;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        public bool doesTransportExist(string transportName, string login, string password)
        {
            try
            {
                string connstring = "Server=127.0.0.1; Port=5432; User Id=" + login + "; Password=" + password + "; Database = SocialTransport;";
                NpgsqlConnection connection = new NpgsqlConnection(connstring);
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM transport WHERE \"typeOfTransport\" = '" + transportName + "'", connection);
                NpgsqlDataReader dataReader = command.ExecuteReader();

                List<List<string>> dataItems = new List<List<string>>();
                for (int i = 0; dataReader.Read(); i++)
                {
                    List<string> row = new List<string>();
                    row.Add(dataReader[0].ToString());
                    row.Add(dataReader[1].ToString());
                    dataItems.Add(row);
                }
                connection.Close();

                try
                {
                    if (dataItems[0][1] == transportName)
                        return true;
                }
                catch
                {
                    return false;
                }

                return false;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        public bool doesTransportToRouteExist(string typeOfTransport, string routeName, string login, string password)
        {
            try
            {
                string connstring = "Server=127.0.0.1; Port=5432; User Id=" + login + "; Password=" + password + "; Database = SocialTransport;";
                NpgsqlConnection connection = new NpgsqlConnection(connstring);
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("SELECT \"idTransportToRoute\", tr.\"typeOfTransport\", r.\"routeName\" FROM public.transporttoroute INNER JOIN public.transport AS tr ON transporttoroute.\"idTransport\" = tr.\"idTransport\" INNER JOIN public.route AS r ON transporttoroute.\"idRoute\" = r.\"idRoute\" WHERE tr.\"typeOfTransport\" = '" + typeOfTransport + "' AND r.\"routeName\" = '" + routeName + "'", connection);
                NpgsqlDataReader dataReader = command.ExecuteReader();

                List<List<string>> dataItems = new List<List<string>>();
                for (int i = 0; dataReader.Read(); i++)
                {
                    List<string> row = new List<string>();
                    row.Add(dataReader[0].ToString());
                    row.Add(dataReader[1].ToString());
                    row.Add(dataReader[2].ToString());
                    dataItems.Add(row);
                }
                connection.Close();

                try
                {
                    if (dataItems[0][1] == typeOfTransport && dataItems[0][2] == routeName)
                        return true;
                }
                catch
                {
                    return false;
                }

                return false;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        public int getStopIdByName(string stopName, string login, string password)
        {
            try
            {
                string connstring = "Server=127.0.0.1; Port=5432; User Id=" + login + "; Password=" + password + "; Database = SocialTransport;";
                NpgsqlConnection connection = new NpgsqlConnection(connstring);
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM public.stop", connection);
                NpgsqlDataReader dataReader = command.ExecuteReader();

                List<List<string>> dataItems = new List<List<string>>();
                for (int i = 0; dataReader.Read(); i++)
                {
                    List<string> row = new List<string>();
                    row.Add(dataReader[0].ToString());
                    row.Add(dataReader[1].ToString());
                    dataItems.Add(row);
                }

                connection.Close();

                
                int j = 0;
                while (j < dataItems.Count)
                {
                    if (dataItems[j].ElementAt(1) == stopName)
                        return Int32.Parse(dataItems[j].ElementAt(0));
                    j++;
                }

                return -1;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        public int getRouteIdByName(string routeName, string login, string password)
        {
            try
            {
                string connstring = "Server=127.0.0.1; Port=5432; User Id=" + login + "; Password=" + password + "; Database = SocialTransport;";
                NpgsqlConnection connection = new NpgsqlConnection(connstring);
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM public.route", connection);
                NpgsqlDataReader dataReader = command.ExecuteReader();

                List<List<string>> dataItems = new List<List<string>>();
                for (int i = 0; dataReader.Read(); i++)
                {
                    List<string> row = new List<string>();
                    row.Add(dataReader[0].ToString());
                    row.Add(dataReader[6].ToString());
                    dataItems.Add(row);
                }

                connection.Close();


                int j = 0;
                while (j < dataItems.Count)
                {
                    if (dataItems[j].ElementAt(1) == routeName)
                        return Int32.Parse(dataItems[j].ElementAt(0));
                    j++;
                }

                return -1;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        public int getTransportIdByName(string typeOfTransport, string login, string password)
        {
            try
            {
                string connstring = "Server=127.0.0.1; Port=5432; User Id=" + login + "; Password=" + password + "; Database = SocialTransport;";
                NpgsqlConnection connection = new NpgsqlConnection(connstring);
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM public.transport", connection);
                NpgsqlDataReader dataReader = command.ExecuteReader();

                List<List<string>> dataItems = new List<List<string>>();
                for (int i = 0; dataReader.Read(); i++)
                {
                    List<string> row = new List<string>();
                    row.Add(dataReader[0].ToString());
                    row.Add(dataReader[1].ToString());
                    dataItems.Add(row);
                }

                connection.Close();


                int j = 0;
                while (j < dataItems.Count)
                {
                    if (dataItems[j].ElementAt(1) == typeOfTransport)
                        return Int32.Parse(dataItems[j].ElementAt(0));
                    j++;
                }

                return -1;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
        }
    }
}
