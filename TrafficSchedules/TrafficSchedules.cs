using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

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

        //Load event of the main form
        private void TrafficSchedules_Load(object sender, EventArgs e)
        {

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

        //textbox destination/ziel events
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

        public void showConnections(String startpoint, String endpoint)
        {

            Connections conlist = route.GetConnections(startpoint, endpoint, getDate(), getTime());

            //clear previous entries
            clearDGVEntries();

            //columns to display in the datagridview
            String[] columns = new String[] { "Von", "Bis", "Abfahrt", "Ankunft", "Dauer", "Gleis"};
            CreateDataGridViewColumns(columns);

            foreach (Connection c in conlist.ConnectionList)
            {
                //add a new row for each connection
                int row = dgv_connections.Rows.Add();

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

            }

        }

        public void showDepartureTable()
        {
            
            String departurestation = tb_start.Text;
            StationBoardRoot sbroot = route.GetStationBoard(departurestation, getDate() + getTime());

            clearDGVEntries();

            String[] stationboardcolumns = new String[] { "Abfahrt", "Nach", "Nummer", "Gleis", "Betreiber" };
            CreateDataGridViewColumns(stationboardcolumns);

            foreach (StationBoard sb in sbroot.Entries)
            {
                int row = dgv_connections.Rows.Add();

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

        //listbox stations events
        private void lbox_stations_Click(object sender, EventArgs e)
        {
            activetextbox.Text = lbox_stations.SelectedItem.ToString();
        }

        private void lbox_stations_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                activetextbox.Text = lbox_stations.SelectedItem.ToString();
            }
        }

        private void bt_show_Click(object sender, EventArgs e)
        {
            if(rb_connections.Checked == true)
            {
                showConnections(tb_start.Text, tb_destination.Text);
            }
            else if (rb_departure.Checked == true)
            {
                showDepartureTable();
            }
        }

        private void rb_departure_CheckedChanged(object sender, EventArgs e)
        {
            tb_destination.Visible = false;
            lb_ziel.Visible = false;
            picbox_switchendstart.Visible = false;
            lb_start.Text = "Abfahrtsort: ";
        }

        private void rb_connections_CheckedChanged(object sender, EventArgs e)
        {
            tb_destination.Visible = true;
            lb_ziel.Visible = true;
            picbox_switchendstart.Visible = true;
            lb_start.Text = "Start: ";
        }

        private void picbox_switchendstart_Click(object sender, EventArgs e)
        {
            String startpoint = tb_start.Text;
            tb_start.Text = tb_destination.Text;
            tb_destination.Text = startpoint;
            bt_show.PerformClick();
        }

        private void bt_newsearch_Click(object sender, EventArgs e)
        {
            tb_start.Text = "";
            tb_destination.Text = "";
            lbox_stations.Items.Clear();
            dgv_connections.Rows.Clear();
            dgv_connections.Columns.Clear();

        }

        public void clearDGVEntries()
        {
            //clear previous entries
            dgv_connections.Rows.Clear();
            dgv_connections.Columns.Clear();
        }

        
    }
}
