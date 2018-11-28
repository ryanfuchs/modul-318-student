using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace TransportApp
{
    public partial class SearchConnectionsForm : Form
    {
        public SearchConnectionsForm()
        {
            InitializeComponent();
        }

        private void SearchStationFrom(object sender, EventArgs e)
        {
            this.cmbFrom.Items.Clear();

            SwissTransport.Transport Station = new Transport();
            List<SwissTransport.Station> TempStation = new List<SwissTransport.Station>();//List für Temporäre Stationen in ComboBox From

            TempStation = Station.GetStations(this.cmbFrom.Text).StationList;
            
            foreach (Station t in TempStation)
            {
                this.cmbFrom.Items.Add(t.Name);
            }

        }

        private void SearchStationTo(object sender, EventArgs e)
        {
            this.cmbTo.Items.Clear();

            SwissTransport.Transport TempStationVar = new Transport();
            List<SwissTransport.Station> TempStationList = new List<SwissTransport.Station>();//List für Temporäre Stationen in ComboBox To

            TempStationList = TempStationVar.GetStations(this.cmbTo.Text).StationList;

            foreach (Station t in TempStationList)
            {
                this.cmbTo.Items.Add(t.Name);
            }

        }

        private void SearchConnections(object sender, EventArgs e)
        {
            SwissTransport.Transport TempConnectionVar = new Transport();   
            List<SwissTransport.Connection> TempConnectionsList = new List<SwissTransport.Connection>();//List für Temporäre Connection in ListBox

            TempConnectionsList = TempConnectionVar.GetConnections(this.cmbFrom.Text, this.cmbTo.Text).ConnectionList;

            foreach (Connection t in TempConnectionsList)
            {
                string DepartureTime = t.From.Departure.Substring(11, 5);
                string ArrivalTime = t.To.Arrival.Substring(11, 5);
                string Platform = t.From.Platform;
                string Duration = t.Duration.Substring(6, 5);

                this.dgvDepatures.Rows.Add(Platform,DepartureTime, ArrivalTime, Duration);
            }
        }
    }
}
