using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using SwissTransport;

namespace TransportApp
{
    public partial class SearchConnectionsForm : Form
    {
        public SearchConnectionsForm()
        {
            InitializeComponent();
            this.lsbFrom.AutoSize = true;
            this.lsbTo.AutoSize = true;
        }

        private void SearchStation(object sender, EventArgs e)
        {
            var SenderTextBox = sender as TextBox;

            string TextBoxInput = SenderTextBox.Text;
            string TextBoxName = SenderTextBox.Name;

            if (TextBoxName == "txbFrom")
            {
                this.lsbFrom.Items.Clear();
                this.lsbFrom.Enabled = true;
            }

            if (TextBoxName == "txbTo")
            {
                this.lsbTo.Items.Clear();
                this.lsbTo.Enabled = true;
            }

            SwissTransport.Transport Station = new Transport();
            List<SwissTransport.Station> TempStation = new List<SwissTransport.Station>();//List für Temporäre Stationen in ComboBox From

            TempStation = Station.GetStations(TextBoxInput).StationList;
            
            foreach (Station t in TempStation)
            {
                if (t.Name != null)//Abfangen von stationen die Keinen Namen haben
                {
                    if (TextBoxName == "txbFrom")
                    {
                        this.lsbFrom.Items.Add(t.Name);
                    }

                    if (TextBoxName == "txbTo")
                    {
                        this.lsbTo.Items.Add(t.Name);
                    }
                }
            }
        }

        private void SearchConnections(object sender, EventArgs e)
        {
            SwissTransport.Transport TempConnectionVar = new Transport();   
            List<SwissTransport.Connection> TempConnectionsList = new List<SwissTransport.Connection>();//List für Temporäre Connection in ListBox

            TempConnectionsList = TempConnectionVar.GetConnections(this.txbFrom.Text, this.txbTo.Text).ConnectionList;

            foreach (Connection t in TempConnectionsList)
            {
                string DepartureTime = t.From.Departure.Substring(11, 5);
                string ArrivalTime = t.To.Arrival.Substring(11, 5);
                string Platform = t.From.Platform;
                string Duration = t.Duration.Substring(3, 5);

                this.dgvDepatures.Rows.Add(Platform,DepartureTime, ArrivalTime, Duration);
            }
        }

        public void LeaveFocus()
        {
            this.lsbFrom.Items.Clear();
            this.lsbFrom.Size = this.lsbFrom.MinimumSize;
            this.lsbFrom.Enabled = false;
            
            this.lsbTo.Items.Clear();
            this.lsbTo.Enabled = false;
            this.lsbTo.Size = this.lsbFrom.MinimumSize;
        }

        private void SelectItemOutOfListBoxFrom(object sender, EventArgs e)
        {
            this.txbFrom.Text = Convert.ToString(this.lsbFrom.SelectedItem);

            this.LeaveFocus();
        }

        private void SelectItemOutOfListBoxTo(object sender, EventArgs e)
        {
            this.txbTo.Text = Convert.ToString(this.lsbTo.SelectedItem);

            this.LeaveFocus();
        }
    }
}
