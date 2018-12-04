using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
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

        //private void OtherForm(object sender, EventArgs e)
        //{
        //    var SenderButton = sender as Button;

        //    if (SenderButton.Name == this.btnConnectionsForm.Name)
        //    {
        //        this.Close();
        //    }
        //}

        private void CurrentLocationMapClick(object sender, EventArgs e)//Location wird auf Googel-Maps angezeigt
        {
            SwissTransport.Transport Station = new Transport();
            List<SwissTransport.Station> TempStation = new List<SwissTransport.Station>();//List für Temporäre Stationen in ComboBox From

            TempStation = Station.GetStations(this.txbCurrentLocation.Text).StationList;

            if (TempStation.Count == 0 || TempStation.First().Coordinate.XCoordinate == null)
            {
                MessageBox.Show("No Coordinates avivable!");
            }
            else
            {
                Station s = TempStation.First();
                System.Diagnostics.Process.Start("https://www.google.com/maps/place/" + s.Coordinate.XCoordinate + "," + s.Coordinate.YCoordinate);
            }
        }

        private void StationNameMapClick(object sender, EventArgs e)//Station der From TextBox wird in GoogleMaps angezeigt
        {
            SwissTransport.Transport Station = new Transport();
            List<SwissTransport.Station> TempStation = new List<SwissTransport.Station>();//List für Temporäre Stationen in ComboBox From

            TempStation = Station.GetStations(this.txbStationName.Text).StationList;
            if (TempStation.Count == 0 || TempStation.First().Coordinate.XCoordinate == null)
            {
                MessageBox.Show("No Coordinates avivable!");
            }
            else
            {
                Station s = TempStation.First();
                System.Diagnostics.Process.Start("https://www.google.com/maps/place/" + s.Coordinate.XCoordinate.ToString().Replace(",", ".") + "," + s.Coordinate.YCoordinate).ToString().Replace(",", ".");
            }
        }

        private void SearchStation(object sender, EventArgs e)//Für die Suche von Stationen
        {
            this.dgvDepatures.Rows.Clear();

            var SenderTextBox = sender as TextBox;

            string TextBoxInput = SenderTextBox.Text;
            string TextBoxName = SenderTextBox.Name;

            Station TempStationObject;

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
            List<SwissTransport.Station> TempStation = new List<SwissTransport.Station>();//List für Temporäre Stationen in ListBox From

            TempStation = Station.GetStations(TextBoxInput).StationList;

            if (TextBoxName == "txbCurrentLocation")
            {
                if (TempStation.Count != 0 && this.txbCurrentLocation.Text != "")
                {

                    TempStationObject = TempStation.First();

                    SwissTransport.Transport StationLocation = new Transport();
                    List<SwissTransport.Station>TempStationLocation = new List<SwissTransport.Station>(); //List für Temporäre Stationen in ListBox From

                    TempStation = Station.GetStationsCordinates(TempStationObject).StationList;
                }
                else
                {
                    this.LeaveFocus();
                }
                

            }

            foreach (Station t in TempStation)
            {
                if (t.Name != null) //Abfangen von stationen die Keinen Namen haben
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

            this.dgvDepatures.Rows.Clear();
            
        }

        private void SearchDepartures(object sender, EventArgs e)//Abfahrten ab einer Bestimmtem Station werden gesucht und angezeigt
        {
            SwissTransport.Transport TempStationBoardVar = new Transport();
            List<SwissTransport.StationBoard> TempStationBoardList = new List<SwissTransport.StationBoard>();//List für Temporäre Connection in ListBox

            this.LeaveFocus();

            string StationName;
            Station TempStationObject = new Station();


            if (this.rdbCurrentLocation.Checked == true)
            {
                SwissTransport.Transport Station = new Transport();
                List<SwissTransport.Station> TempStation = new List<SwissTransport.Station>();//List für Temporäre Stationen in ListBox From

                TempStation = Station.GetStations(this.txbCurrentLocation.Text).StationList;

                if (this.txbCurrentLocation.Text == "" || TempStation == null)
                {
                    MessageBox.Show("Pleas enter your current location.");
                }
                else
                {
                    TempStationObject = TempStation.First();
                }

                StationName = this.txbCurrentLocation.Text;
            }
            else
            {
                SwissTransport.Transport Station = new Transport();
                List<SwissTransport.Station> TempStation = new List<SwissTransport.Station>();//List für Temporäre Stationen in ListBox From

                TempStation = Station.GetStations(this.txbStationName.Text).StationList;

                if (TempStation.Count != 0)
                {
                    TempStationObject = TempStation.First();
                }
                else
                {
                    MessageBox.Show("Pleas enter a correct stationname.");
                }

                StationName = this.txbStationName.Text;
            }
            TempStationBoardList = TempStationBoardVar.GetStationBoard(TempStationObject.Id).Entries;


            foreach (StationBoard t in TempStationBoardList)
            {
                string Departure = Convert.ToString(t.Stop.Departure);
                string Line = t.Category;
                string To = t.To;

                this.dgvDepatures.Rows.Add(StationName, Departure, Line, To);
            }
            
            this.LeaveFocus();
        }

        public void LeaveFocus() //Listboxen werden geschlossen durch Methodenaufruf
        {
            this.lsbCurrentLocation.Items.Clear();
            this.lsbCurrentLocation.Size = this.lsbCurrentLocation.MinimumSize;
            this.lsbCurrentLocation.Enabled = false;
            this.lsbCurrentLocation.Visible = false;

            this.lsbStationName.Items.Clear();
            this.lsbStationName.Enabled = false;
            this.lsbStationName.Size = this.lsbStationName.MinimumSize;
            this.lsbStationName.Visible = false;
        }

        private void SelectItemOutOfListBoxStationName(object sender, EventArgs e)//Item wird von lsb in txb gemoved
        {
            this.txbStationName.Text = this.lsbStationName.SelectedItem.ToString();

            this.LeaveFocus();
        }

        private void SelectItemOutOfListBoxCurrentLocation(object sender, EventArgs e)//Item wird von lsb in txb gemoved
        {
            this.txbCurrentLocation.Text = this.lsbCurrentLocation.SelectedItem.ToString();
        }

        private void SendMail(object sender, EventArgs e)//Methode für das versenden eines Mails
        {
            var mailMessage = new MailMessage();
            {
                mailMessage.Subject = "Connections";
                mailMessage.From = new MailAddress("info@transportgate.ch");
                mailMessage.IsBodyHtml = true;

                var NewLine = "%0D%0A"; //UniCode
                mailMessage.Body = "Connections:" + NewLine + NewLine;
                mailMessage.Body += "Form:" + this.dgvDepatures.Rows[1].Cells[0].Value + NewLine + NewLine;

                for (int i = 0; i < this.dgvDepatures.RowCount - 1; i++)
                {
                    mailMessage.Body += "Departure: " + this.dgvDepatures.Rows[i].Cells[1].Value + NewLine +
                                        "Line: " + this.dgvDepatures.Rows[i].Cells[2].Value + NewLine +
                                        "To: " + this.dgvDepatures.Rows[i].Cells[3].Value + NewLine + NewLine;
                }

                Process.Start(@"mailto:?subject=" + mailMessage.Subject + "&body=" + mailMessage.Body);
            }
        }

        private void OpenConnectionsForm(object sender, EventArgs e)//Öffnen der Connections Form
        {
            this.Close();
        }

        private void LeaveFocus(object sender, EventArgs e)//Listboxen werden geschlossen durch Eventaufruf
        {
            this.lsbCurrentLocation.Items.Clear();
            this.lsbCurrentLocation.Size = this.lsbCurrentLocation.MinimumSize;
            this.lsbCurrentLocation.Enabled = false;
            this.lsbCurrentLocation.Visible = false;

            this.lsbStationName.Items.Clear();
            this.lsbStationName.Enabled = false;
            this.lsbStationName.Size = this.lsbStationName.MinimumSize;
            this.lsbStationName.Visible = false;
        }
    }
}
