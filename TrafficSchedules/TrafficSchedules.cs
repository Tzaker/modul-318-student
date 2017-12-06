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

        Transport route = new Transport();
        Station departurestation = new Station();
        Stations stationlist = new Stations();


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
            stationlist = route.GetStations(tb_start.Text);
        }
    }
}
