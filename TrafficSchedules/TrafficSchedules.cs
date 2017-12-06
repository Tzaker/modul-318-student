﻿using System;
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

        //Provide search suggestions while typing
        private void tb_start_TextChanged(object sender, EventArgs e)
        {
            activetextbox = tb_start;
            showStations(tb_start.Text, "start");            
        }

        private void tb_destination_TextChanged(object sender, EventArgs e)
        {
            activetextbox = tb_destination;
            showStations(tb_destination.Text, "end");

        }


        //display station name suggestions in the stations listbox
        public void showStations(String searchquery, String stationtype)
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

            Connections conlist = route.GetConnections(startpoint, endpoint);

            //clear previous entries
            dgv_connections.Rows.Clear();
            dgv_connections.Columns.Clear();

            //adjust size
            dgv_connections.AutoSize = true;

            //columns to display in the datagridview
            String[] columns = new String[] { "Von", "Bis", "Abfahrt", "Ankunft", "Dauer", "Gleis" };

            //create the columns
            foreach (String col in columns)
            {
                dgv_connections.Columns.Add(col, col);
            }

            foreach(Connection c in conlist.ConnectionList)
            {
                //add a new row for each connection
                int row = dgv_connections.Rows.Add();
                String[] values = new String[] 
                {
                    c.From.Station.Name,
                    c.To.Station.Name,
                    c.From.Departure.Substring(12, 4),
                    c.To.Arrival.Substring(12, 4),
                    c.Duration.Substring(3, 5) + "h",
                    c.From.Platform
                };
                
                //iterate through the columns
                for(int i = 0; i < values.Count(); i++)
                {
                    //fill in the data
                    dgv_connections.Rows[row].Cells[i].Value = values[i];
                }


            }

            
            
        }

        private void lbox_stations_Click(object sender, EventArgs e)
        {
            activetextbox.Text = lbox_stations.SelectedItem.ToString();
        }

        private void bt_show_Click(object sender, EventArgs e)
        {
            showConnections(tb_start.Text, tb_destination.Text);
        }

        private void rb_departure_CheckedChanged(object sender, EventArgs e)
        {
            tb_destination.Visible = false;
            lb_ziel.Visible = false;
            picbox_switchendstart.Visible = false;
        }

        private void rb_connections_CheckedChanged(object sender, EventArgs e)
        {
            tb_destination.Visible = true;
            lb_ziel.Visible = true;
            picbox_switchendstart.Visible = true;
        }

        private void picbox_switchendstart_Click(object sender, EventArgs e)
        {
            String startpoint = tb_start.Text;

            tb_start.Text = tb_destination.Text;
            tb_destination.Text = startpoint;
        }
    }
}
