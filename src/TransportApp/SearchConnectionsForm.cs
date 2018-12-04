using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;
using SwissTransport;

namespace TransportApp
{
    public partial class SearchConnectionsForm : Form
    {
        public SearchConnectionsForm()//Aufruf beim öffnen der Form
        {
            InitializeComponent();
            this.lsbFrom.AutoSize = true;
            this.lsbTo.AutoSize = true;
            this.txbFrom.Focus();
        }

        private void SearchStation(object sender, EventArgs e)//Methode für das Suchen einer Station
        {
            var SenderTextBox = sender as TextBox;

            string TextBoxInput = SenderTextBox.Text;
            string TextBoxName = SenderTextBox.Name;

            if (TextBoxName == "txbFrom")
            {
                this.lsbFrom.Items.Clear();
                this.lsbFrom.Enabled = true;
                this.lsbFrom.Visible = true;
            }

            if (TextBoxName == "txbTo")
            {
                this.lsbTo.Items.Clear();
                this.lsbTo.Enabled = true;
                this.lsbTo.Visible = true;
            }

            SwissTransport.Transport Station = new Transport();
            List<SwissTransport.Station> TempStation = new List<SwissTransport.Station>();//List für Temporäre Stationen in ComboBox From

            TempStation = Station.GetStations(TextBoxInput).StationList;
            
            foreach (Station t in TempStation)
            {
                if (t.Name == null) continue;
                switch (TextBoxName)
                {
                    case "txbFrom":
                        this.lsbFrom.Items.Add(t.Name);
                        break;
                    case "txbTo":
                        this.lsbTo.Items.Add(t.Name);
                        break;
                }
            }

            this.dgvDepatures.Rows.Clear();
        }

        private void SearchConnections(object sender, EventArgs e)//Methode für das Suchen der Verbindungen
        {
            SwissTransport.Transport TempConnectionVar = new Transport();
            List<SwissTransport.Connection> TempConnectionsList = new List<SwissTransport.Connection>();//List für Temporäre Connection in ListBox
            this.dgvDepatures.Rows.Clear();
            this.LeaveFocus();

            if (this.rdbDateTime.Checked == true)
            {
                TempConnectionsList = TempConnectionVar.GetConnections(this.txbFrom.Text, this.txbTo.Text,
                    this.dtpDepartureTime.Value, this.dtpDepartureDate.Value).ConnectionList;
            }
            else
            {
                TempConnectionsList = TempConnectionVar.GetConnections(this.txbFrom.Text, this.txbTo.Text,
                    DateTime.Now, DateTime.Now).ConnectionList;
            }
            foreach (Connection t in TempConnectionsList)
            {
                string Platform = "";
                string DepartureTime = t.From.Departure.Substring(11, 5);
                string ArrivalTime = t.To.Arrival.Substring(11, 5);
                Platform = t.From.Platform ?? "No Information";
                string Duration = t.Duration.Substring(3, 5);

                this.dgvDepatures.Rows.Add(Platform,DepartureTime, ArrivalTime, Duration);
            }
        }

        public void LeaveFocus()//Listboxen werden geschlossen aufruf in Methode
        {
            this.lsbFrom.Items.Clear();
            this.lsbFrom.Size = this.lsbFrom.MinimumSize;
            this.lsbFrom.Enabled = false;
            this.lsbFrom.Visible = false;
            
            this.lsbTo.Items.Clear();
            this.lsbTo.Enabled = false;
            this.lsbTo.Size = this.lsbFrom.MinimumSize;
            this.lsbTo.Visible = false;
        }

        private void SelectItemOutOfListBoxFrom(object sender, EventArgs e)//Item aus lsb wird in txb gemoved
        {
            this.txbFrom.Text = Convert.ToString(this.lsbFrom.SelectedItem);

            this.LeaveFocus();
        }

        private void SelectItemOutOfListBoxTo(object sender, EventArgs e)//Item aus lsb wird in txb gemoved
        {
            this.txbTo.Text = Convert.ToString(this.lsbTo.SelectedItem);

            this.LeaveFocus();
        }

        private void OtherForm(object sender, EventArgs e)//Wird beim betätigen der beiden btn für das Öffnen der Forms ausgelöst
        {
            this.LeaveFocus();

            var SenderButton = sender as Button;

            if (SenderButton.Name == this.btnDeparturesForm.Name)
            {
                this.Hide();
                Forms.OpenSearchDeparturesForm(this);
            }

        }

        private void LocationClickFrom(object sender, EventArgs e)//Location wird auf Google maps Angezeigt
        {
            SwissTransport.Transport Station = new Transport();
            List<SwissTransport.Station> TempStation = new List<SwissTransport.Station>();//List für Temporäre Stationen in ComboBox From

            TempStation = Station.GetStations(this.txbFrom.Text).StationList;

            Station S;

            if (TempStation.Count == 0 || TempStation.First().Coordinate.XCoordinate == null)
            {
                MessageBox.Show("No Coordinates avivable!");
            }
            else
            {
                S = TempStation.First();
                System.Diagnostics.Process.Start("https://www.google.com/maps/place/" + S.Coordinate.XCoordinate.ToString().Replace(",", ".") + "," + S.Coordinate.YCoordinate)?.ToString().Replace(",", ".");
            }
        }

        private void LocationClickTo(object sender, EventArgs e)//Location wird auf Google maps Angezeigt
        {
            SwissTransport.Transport Station = new Transport();
            List<SwissTransport.Station> TempStation = new List<SwissTransport.Station>();//List für Temporäre Stationen in ComboBox From

            TempStation = Station.GetStations(this.txbTo.Text).StationList;

            Station S;

            if (TempStation.Count == 0 || TempStation.First().Coordinate.XCoordinate == null)
            {
                MessageBox.Show("No Coordinates avivable!");
            }
            else
            {
                S = TempStation.First();
                System.Diagnostics.Process.Start("https://www.google.com/maps/place/" + S.Coordinate.XCoordinate + "," + S.Coordinate.YCoordinate);
            }
        }

        public void ShowForm()//Methode zu Anzeigen der Connections Form
        {
            this.Show();
        }

        private void SendMail(object sender, EventArgs e)//Methode für das Versenden eines Mails
        {
            var MailMessage = new MailMessage();
            {
                MailMessage.Subject = "Connections";
                MailMessage.From = new MailAddress("info@transportgate.ch");
                MailMessage.IsBodyHtml = true;

                const string NewLine = "%0D%0A"; //UniCode
                MailMessage.Body = "Connections:" + NewLine + NewLine;
                MailMessage.Body += "Form:" + this.txbFrom.Text + ", " + "To:" + this.txbTo.Text + NewLine + NewLine;

                for (int i = 0; i < this.dgvDepatures.RowCount - 1; i++)
                {
                    MailMessage.Body += "Platform: " + this.dgvDepatures.Rows[i].Cells[0].Value + NewLine +
                                        "Departure: " + this.dgvDepatures.Rows[i].Cells[1].Value + NewLine +
                                        "Arrival: " + this.dgvDepatures.Rows[i].Cells[2].Value + NewLine +
                                        "Duration: " + this.dgvDepatures.Rows[i].Cells[3].Value + NewLine + NewLine;
                }

                Process.Start(@"mailto:?subject=" + MailMessage.Subject + "&body=" + MailMessage.Body);
            }
        }

        private void LeaveFocus(object sender, EventArgs e)//Listboxen werden geschlossen aufruff durch Event
        {
            this.lsbFrom.Items.Clear();
            this.lsbFrom.Size = this.lsbFrom.MinimumSize;
            this.lsbFrom.Enabled = false;
            this.lsbFrom.Visible = false;

            this.lsbTo.Items.Clear();
            this.lsbTo.Enabled = false;
            this.lsbTo.Size = this.lsbFrom.MinimumSize;
            this.lsbTo.Visible = false;
        }
    }
}
