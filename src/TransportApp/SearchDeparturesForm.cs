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

namespace TransportApp
{
    public partial class SearchDeparturesForm : Form
    {
        public SearchDeparturesForm()
        {
            InitializeComponent();
            this.lsbCurrentLocation.AutoSize = true;
            this.lsbStationName.AutoSize = true;
        }

        private void OtherForm(object sender, EventArgs e)
        {
            var SenderButton = sender as Button;

            if (SenderButton.Name == this.btnConnectionsForm.Name)
            {
                this.Close();
            }
        }

        private void CurrentLocationMapClick(object sender, EventArgs e)//Location wird auf Googel-Maps angezeigt
        {
            SwissTransport.Transport Station = new Transport();
            List<SwissTransport.Station> TempStation = new List<SwissTransport.Station>();//List für Temporäre Stationen in ComboBox From

            TempStation = Station.GetStations(this.txbCurrentLocation.Text).StationList;

            Station s = TempStation.First();

            System.Diagnostics.Process.Start("https://www.google.com/maps/place/" + s.Coordinate.XCoordinate + "," + s.Coordinate.YCoordinate);
        }

        private void StationNameMapClick(object sender, EventArgs e)
        {
            SwissTransport.Transport Station = new Transport();
            List<SwissTransport.Station> TempStation = new List<SwissTransport.Station>();//List für Temporäre Stationen in ComboBox From

            TempStation = Station.GetStations(this.txbStationName.Text).StationList;

            Station s = TempStation.First();

            System.Diagnostics.Process.Start("https://www.google.com/maps/place/" + s.Coordinate.XCoordinate + "," + s.Coordinate.YCoordinate);
        }

        private void SearchStation(object sender, EventArgs e)
        {
            var SenderTextBox = sender as TextBox;

            string TextBoxInput = SenderTextBox.Text;
            string TextBoxName = SenderTextBox.Name;

            if (TextBoxName == "txbStationName")
            {
                this.lsbStationName.Items.Clear();
                this.lsbStationName.Enabled = true;
                this.lsbStationName.Visible = true;
            }

            if (TextBoxName == "txbCurrentLocation")
            {
                this.lsbCurrentLocation.Items.Clear();
                this.lsbCurrentLocation.Enabled = true;
                this.lsbCurrentLocation.Visible = true;
            }

            SwissTransport.Transport Station = new Transport();
            List<SwissTransport.Station> TempStation = new List<SwissTransport.Station>();//List für Temporäre Stationen in ComboBox From

            TempStation = Station.GetStations(TextBoxInput).StationList;

            foreach (Station t in TempStation)
            {
                if (t.Name != null)//Abfangen von stationen die Keinen Namen haben
                {
                    if (TextBoxName == "txbStationName")
                    {
                        this.lsbStationName.Items.Add(t.Name);
                    }

                    if (TextBoxName == "txbCurrentLocation")
                    {
                        this.lsbCurrentLocation.Items.Add(t.Name);
                    }
                }
            }
        }

        private void btnConnectionsForm_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
