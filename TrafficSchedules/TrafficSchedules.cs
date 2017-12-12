using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using SwissTransport;
using GMap;
using GMap.NET;
using GMap.NET.WindowsForms;

namespace TrafficSchedules
{
    public partial class TrafficSchedules : Form
    {

        TextBox activetextbox = null;
        Transport route = new Transport();

        public TrafficSchedules()
        {
            InitializeComponent();
        }

        //display station name suggestions in the stations listbox
        public void showStations(String searchquery)
        {
            
            Stations stationlist = route.GetStations(searchquery);

            //clear previous entries
            lbox_stations.Items.Clear();

            //show station names
            foreach (Station s in stationlist.StationList)
            {
                lbox_stations.Items.Add(s.Name);
            }
        }

        //show connections in the datagridview
        public void showConnections(String startpoint, String endpoint)
        {
            //get the connections via opendata
            Connections conlist = route.GetConnections(startpoint, endpoint, getDate(), getTime());

            //clear previous entries
            clearDGVEntries();

            //columns to display in the datagridview
            String[] columns = new String[] { "Von", "Bis", "Abfahrt", "Ankunft", "Dauer", "Gleis"};
            CreateDataGridViewColumns(columns);

            foreach (Connection c in conlist.ConnectionList)
            {
                
                int row = addRowtoDataGridView();

                //parse for prettier data
                String departure = DateTime.Parse(c.From.Departure).ToString("HH:mm");
                String arrival = DateTime.Parse(c.To.Arrival).ToString("HH:mm");
                String duration = c.Duration.Substring(3, 2) + " h " + c.Duration.Substring(6, 2) + " min";

                String[] values = new String[]
                {
                    c.From.Station.Name,
                    c.To.Station.Name,
                    departure,
                    arrival,
                    duration,
                    c.From.Platform
                };

                FillDataGrid(values, row);
                startpoint = c.From.Station.Name;
                endpoint = c.To.Station.Name;
                
            }
            //in case the names were not completed but had to be guessed by the api
            tb_start.Text = startpoint;
            tb_destination.Text = endpoint;

            //show the map of the departure station
            Openmap(startpoint);
        }

        //show departure table in the datagridview
        public void showDepartureTable()
        {
            //get the requested station and the appropriate stationboard
            String departurestation = lbox_stations.Items[0].ToString();
            tb_start.Text = departurestation;
            StationBoardRoot sbroot = route.GetStationBoard(departurestation, getDate() + getTime());
            Openmap(departurestation);

            //clear previous entries
            clearDGVEntries();

            //columns to display for the stationboard
            String[] stationboardcolumns = new String[] { "Abfahrt", "Nach", "Nummer", "Gleis", "Betreiber" };
            CreateDataGridViewColumns(stationboardcolumns);

            foreach (StationBoard sb in sbroot.Entries)
            {
                int row = addRowtoDataGridView();

                String[] stationboardproperties = new String[]
                {
                    sb.Stop.Departure.ToShortTimeString(),                  
                    sb.To,
                    sb.Number,
                    sb.Stop.Platform,                   
                    sb.Operator
                };

                FillDataGrid(stationboardproperties, row);
                
            }
            
        }

        public int addRowtoDataGridView()
        {
            int i = dgv_connections.Rows.Add();
            return i;
        }

        public void CreateDataGridViewColumns(String[] displayedcolumns)
        {
            //create the columns
            foreach (String col in displayedcolumns)
            {
                dgv_connections.Columns.Add(col, col);
            }
        }

        //fill in the data. requires columns to be set by CreateDataGridViewColumns
        public void FillDataGrid(String[] valuesarray, int rowindex)
        {
        
            //iterate through the columns
            for (int i = 0; i < valuesarray.Count(); i++)
            {
                //fill in the data
                dgv_connections.Rows[rowindex].Cells[i].Value = valuesarray[i];
                    
            }
        }

        public String getTime()
        {
            return datetimepicker.Value.ToString("HH:mm");
        }

        public String getDate()
        {
            return datetimepicker.Value.ToString("yyyy-MM-dd");
        }

        public void ClearForm()
        {
            tb_start.Text = "";
            tb_destination.Text = "";
            lbox_stations.Items.Clear();
            dgv_connections.Rows.Clear();
            dgv_connections.Columns.Clear();
            datetimepicker.Value = DateTime.Now;
        }

        public void clearDGVEntries()
        {
            dgv_connections.Rows.Clear();
            dgv_connections.Columns.Clear();
        }

        //open map of requested city/position
        public void Openmap(String address)
        {
            // Initialize map
            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            try
            {               
                gmap.SetPositionByKeywords(address);
                gmap.ShowCenter = false;
                gmap.CanDragMap = true;
                gmap.Zoom = 15;

            }
            catch (Exception)
            {
                MessageBox.Show("Die aktuelle Station konnte auf der Karte nicht gefunden werden.");
                throw;
            }

        }

        //textbox start events
        //Provide search suggestions while typing
        private void tb_start_TextChanged(object sender, EventArgs e)
        {
            activetextbox = tb_start;
            showStations(tb_start.Text);
        }

        private void tb_start_Click(object sender, EventArgs e)
        {
            activetextbox = tb_start;
            tb_start.Clear();
        }

        //textbox destination events
        private void tb_destination_TextChanged(object sender, EventArgs e)
        {
            activetextbox = tb_destination;
            showStations(tb_destination.Text);

        }

        private void tb_destination_Click(object sender, EventArgs e)
        {
            activetextbox = tb_destination;
            tb_destination.Clear();
        }

        //listbox stations events
        private void lbox_stations_Click(object sender, EventArgs e)
            {
                activetextbox.Text = lbox_stations.SelectedItem.ToString();
            }

        //put the selected object into the textbox on pressing space
        private void lbox_stations_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if(lbox_stations.SelectedItem != null)
                {
                activetextbox.Text = lbox_stations.SelectedItem.ToString();
                }
            }
        }
        //show the requested data in the grid view
        private void bt_show_Click(object sender, EventArgs e)
        {
            try
            {
                if (rb_connections.Checked == true)
                {
                    showConnections(tb_start.Text, tb_destination.Text);
                }
                else if (rb_departure.Checked == true)
                {
                    showDepartureTable();
                }
                
            } catch(Exception ex)
            {
                //if a home address without saved coordinates has been selected
                String converterror = "Error converting value";
                if (ex.Message.Substring(0, 22) == converterror)
                {
                MessageBox.Show("Bitte verwenden Sie nur Bahnhöfe oder Bushaltestellen. Eine oder mehrere Adressen sind ungültig.");
                }
                ClearForm();
                return;
            }

            if (dgv_connections.Rows.Count <= 1)
            {
                //date out of bounds or non existing stations entered by the user
                MessageBox.Show("Es wurden keine Verbindungen gefunden. Nur Daten des aktuellen Fahrplanjahres sind verfügbar. Stellen Sie ausserdem sicher, dass der Abfahrts- und Zielort existieren.");
                datetimepicker.Value = DateTime.Now;
                return;
            }

        }

        private void rb_departure_CheckedChanged(object sender, EventArgs e)
        {
            tb_destination.Visible = false;
            lb_ziel.Visible = false;
            picbox_switchendstart.Visible = false;
            lb_start.Text = "Abfahrtsort: ";
            tb_start.Focus();
        }

        private void rb_connections_CheckedChanged(object sender, EventArgs e)
        {
            tb_destination.Visible = true;
            lb_ziel.Visible = true;
            picbox_switchendstart.Visible = true;
            lb_start.Text = "Start: ";
            tb_start.Focus();
        }
        //switch departure and arrival station
        private void picbox_switchendstart_Click(object sender, EventArgs e)
        {
            String startpoint = tb_start.Text;
            tb_start.Text = tb_destination.Text;
            tb_destination.Text = startpoint;
            bt_show.PerformClick();
        }

        private void bt_newsearch_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        
        private void bt_email_Click(object sender, EventArgs e)
        {
            //Show Prompt to enter email address
            emailprompt prompt = new emailprompt();
            String recipientemail = "";

            if (prompt.ShowDialog(this) == DialogResult.OK)
            {
                recipientemail = prompt.tb_emailaddress.Text;
            } else
            {
                return;
            }

            prompt.Dispose();

            /* iterate through the rows from the datagridview 
             * convert the data into an html table to be able to keep the formatting
             */
            String datatable = "<table width='100%' style='border:Solid 1px Black;'>";

            foreach (DataGridViewRow row in dgv_connections.Rows)
            {
                datatable += "<tr>";
                foreach (DataGridViewCell cell in row.Cells)
                {
                    datatable += "<td style='color:black;'>" + cell.Value + "</td>";
                }
                datatable += "</tr>";
            }
            datatable += "</table>";

            MailAddress senderaddress = new MailAddress("trafficschedules@gmail.com", "Traffic Schedules");
            MailAddress recipientaddress = new MailAddress(recipientemail);
            SendEmail(senderaddress, recipientaddress, datatable);
        }

        public void SendEmail(MailAddress sender, MailAddress recipient, String message)
        {
            //create a new smtp client and add the credentials
            //from a google account created for this project
            SmtpClient smtpcl = new SmtpClient();
            smtpcl.Host = "smtp.gmail.com";
            smtpcl.EnableSsl = true;
            System.Net.NetworkCredential credentials = new System.Net.NetworkCredential("trafficschedules@gmail.com", "lgTPve7u8G06");
            smtpcl.Credentials = credentials;

            //create the message to send
            MailMessage msgtosend = new MailMessage();
            msgtosend.From = sender;
            msgtosend.To.Add(recipient);
            msgtosend.Subject = "Exported Traffic Schedules";
            msgtosend.Body = message;
            msgtosend.IsBodyHtml = true;
            try
            {
                smtpcl.Send(msgtosend);
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            
            msgtosend.Dispose();
        }

        

        
    }
}
