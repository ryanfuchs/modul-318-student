using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Fsolutions.Fbase.Common.Mail;
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
            this.txbFrom.Focus();
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

            this.dgvDepatures.Rows.Clear();
        }

        private void SearchConnections(object sender, EventArgs e)
        {
            SwissTransport.Transport TempConnectionVar = new Transport();   
            List<SwissTransport.Connection> TempConnectionsList = new List<SwissTransport.Connection>();//List für Temporäre Connection in ListBox

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
            this.lsbFrom.Visible = false;
            
            this.lsbTo.Items.Clear();
            this.lsbTo.Enabled = false;
            this.lsbTo.Size = this.lsbFrom.MinimumSize;
            this.lsbTo.Visible = false;
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

        private void OtherForm(object sender, EventArgs e)//Wird beim betätigen der beiden btn für das Öffnen der Forms ausgelöst
        {
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

            Station s = TempStation.First();

            System.Diagnostics.Process.Start("https://www.google.com/maps/place/" + s.Coordinate.XCoordinate + "," + s.Coordinate.YCoordinate);
        }

        private void LocationClickTo(object sender, EventArgs e)//Location wird auf Google maps Angezeigt
        {
            SwissTransport.Transport Station = new Transport();
            List<SwissTransport.Station> TempStation = new List<SwissTransport.Station>();//List für Temporäre Stationen in ComboBox From

            TempStation = Station.GetStations(this.txbTo.Text).StationList;

            Station s = TempStation.First();

            if (s.Coordinate.YCoordinate == null || s.Coordinate.XCoordinate == null)
            {
                s.Coordinate.XCoordinate = 0.00;
                s.Coordinate.YCoordinate = 0.00;
            }

            System.Diagnostics.Process.Start("https://www.google.com/maps/place/" + s.Coordinate.XCoordinate + "," + s.Coordinate.YCoordinate);
        }

        public void ShowForm()
        {
            this.Show();
        }

        private void SendMail(object sender, EventArgs e)
        {
            //int Rows = 1;
            //int Cells = 0;

            //var MailStringBuilder = new StringBuilder();
            //MailStringBuilder.AppendLine("Connections");
            //MailStringBuilder.AppendLine($"From:{this.txbFrom.Text} To:{this.txbTo.Text}");
            //MailStringBuilder.Append("<tabel border='1' style='border-collapse:collapse' cellpadding='8'>");
            //MailStringBuilder.Append(
            //    "<tr><th>Platform</th><th>Departure</th><th>Arrival</th><th>Duration</th></tr>");
            //for(int i = 0; i <= this.dgvDepatures.RowCount; i++)
            //{
            //    MailStringBuilder.Append("<tr>");
            //    MailStringBuilder.Append($"<td>{this.dgvDepatures.Rows[Rows].Cells[Cells].Value}</td>");
            //    Cells++;
            //    MailStringBuilder.Append($"<td>{this.dgvDepatures.Rows[Rows].Cells[Cells].Value}</td>");
            //    Cells++;
            //    MailStringBuilder.Append($"<td>{this.dgvDepatures.Rows[Rows].Cells[Cells].Value}</td>");
            //    Cells++;
            //    MailStringBuilder.Append($"<td>{this.dgvDepatures.Rows[Rows].Cells[Cells].Value}</td>");
            //    MailStringBuilder.Append("</tr>");
            //    Cells = 0;
            //    Rows++;
            //}

            //MailStringBuilder.Append("</table>");



            var mailMessage = new MailMessage();
            {
                mailMessage.Subject = "Connections";
                mailMessage.From = new MailAddress("info@transportgate.ch");
                mailMessage.IsBodyHtml = true;

                var NewLine = "%0D%0A"; //UniCode
                mailMessage.Body = "Connection:" + NewLine;
                mailMessage.Body += "Form:" + this.txbFrom.Text + ", " + "To:" + this.txbTo.Text + NewLine +
                    "Platform: " + this.dgvDepatures.Rows[1].Cells[0].Value + NewLine +
                    "Departure: " + this.dgvDepatures.Rows[1].Cells[1].Value + NewLine +
                    "Arrival: " + this.dgvDepatures.Rows[1].Cells[2].Value + NewLine +
                    "Duration: " + this.dgvDepatures.Rows[1].Cells[3].Value;

                Process.Start(@"mailto:?subject=" + mailMessage.Subject + "&body=" + mailMessage.Body);
            }
        }
    }
}
