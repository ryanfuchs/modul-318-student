namespace TransportApp
{
    partial class SearchConnectionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchConnectionsForm));
            this.tlpForm = new System.Windows.Forms.TableLayoutPanel();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblDepature = new System.Windows.Forms.Label();
            this.dgvDepatures = new System.Windows.Forms.DataGridView();
            this.ColumnPlatform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDeparture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnArrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lsbFrom = new System.Windows.Forms.ListBox();
            this.txbFrom = new System.Windows.Forms.TextBox();
            this.lsbTo = new System.Windows.Forms.ListBox();
            this.txbTo = new System.Windows.Forms.TextBox();
            this.btnDeparturesForm = new System.Windows.Forms.Button();
            this.rdbNow = new System.Windows.Forms.RadioButton();
            this.lblNow = new System.Windows.Forms.Label();
            this.rdbDateTime = new System.Windows.Forms.RadioButton();
            this.dtpDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDepartureTime = new System.Windows.Forms.DateTimePicker();
            this.btnConnectionsForm = new System.Windows.Forms.Button();
            this.pbxLocation2 = new System.Windows.Forms.PictureBox();
            this.pbxLocation1 = new System.Windows.Forms.PictureBox();
            this.pbxMail = new System.Windows.Forms.PictureBox();
            this.tlpForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepatures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLocation2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLocation1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMail)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpForm
            // 
            this.tlpForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpForm.ColumnCount = 6;
            this.tlpForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.05586F));
            this.tlpForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.27928F));
            this.tlpForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.62138F));
            this.tlpForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.04348F));
            this.tlpForm.Controls.Add(this.lblFrom, 1, 3);
            this.tlpForm.Controls.Add(this.lblTo, 1, 5);
            this.tlpForm.Controls.Add(this.btnSearch, 2, 7);
            this.tlpForm.Controls.Add(this.lblDepature, 4, 2);
            this.tlpForm.Controls.Add(this.dgvDepatures, 2, 8);
            this.tlpForm.Controls.Add(this.lsbFrom, 2, 4);
            this.tlpForm.Controls.Add(this.txbFrom, 2, 3);
            this.tlpForm.Controls.Add(this.lsbTo, 2, 6);
            this.tlpForm.Controls.Add(this.txbTo, 2, 5);
            this.tlpForm.Controls.Add(this.btnDeparturesForm, 4, 0);
            this.tlpForm.Controls.Add(this.rdbNow, 3, 3);
            this.tlpForm.Controls.Add(this.lblNow, 4, 3);
            this.tlpForm.Controls.Add(this.rdbDateTime, 3, 5);
            this.tlpForm.Controls.Add(this.dtpDepartureDate, 4, 5);
            this.tlpForm.Controls.Add(this.dtpDepartureTime, 5, 5);
            this.tlpForm.Controls.Add(this.btnConnectionsForm, 0, 0);
            this.tlpForm.Controls.Add(this.pbxLocation2, 0, 5);
            this.tlpForm.Controls.Add(this.pbxLocation1, 0, 3);
            this.tlpForm.Controls.Add(this.pbxMail, 3, 7);
            this.tlpForm.Location = new System.Drawing.Point(12, 12);
            this.tlpForm.Name = "tlpForm";
            this.tlpForm.RowCount = 9;
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpForm.Size = new System.Drawing.Size(682, 473);
            this.tlpForm.TabIndex = 7;
            // 
            // lblFrom
            // 
            this.lblFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(38, 75);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(63, 30);
            this.lblFrom.TabIndex = 8;
            this.lblFrom.Text = "From:";
            this.lblFrom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTo
            // 
            this.lblTo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(38, 128);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(63, 30);
            this.lblTo.TabIndex = 9;
            this.lblTo.Text = "To:";
            this.lblTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(107, 184);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(340, 24);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search Connectons";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.SearchConnections);
            // 
            // lblDepature
            // 
            this.lblDepature.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDepature.AutoSize = true;
            this.lblDepature.Location = new System.Drawing.Point(473, 45);
            this.lblDepature.Name = "lblDepature";
            this.lblDepature.Size = new System.Drawing.Size(123, 30);
            this.lblDepature.TabIndex = 15;
            this.lblDepature.Text = "Departure:";
            this.lblDepature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvDepatures
            // 
            this.dgvDepatures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDepatures.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDepatures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepatures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPlatform,
            this.ColumnDeparture,
            this.ColumnArrival,
            this.ColumnDuration});
            this.tlpForm.SetColumnSpan(this.dgvDepatures, 3);
            this.dgvDepatures.Location = new System.Drawing.Point(107, 214);
            this.dgvDepatures.Name = "dgvDepatures";
            this.dgvDepatures.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvDepatures.Size = new System.Drawing.Size(489, 256);
            this.dgvDepatures.TabIndex = 16;
            this.dgvDepatures.TabStop = false;
            // 
            // ColumnPlatform
            // 
            this.ColumnPlatform.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnPlatform.HeaderText = "Platform";
            this.ColumnPlatform.Name = "ColumnPlatform";
            // 
            // ColumnDeparture
            // 
            this.ColumnDeparture.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDeparture.HeaderText = "Departure";
            this.ColumnDeparture.Name = "ColumnDeparture";
            // 
            // ColumnArrival
            // 
            this.ColumnArrival.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnArrival.HeaderText = "Arrival";
            this.ColumnArrival.Name = "ColumnArrival";
            // 
            // ColumnDuration
            // 
            this.ColumnDuration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDuration.HeaderText = "Duration";
            this.ColumnDuration.Name = "ColumnDuration";
            // 
            // lsbFrom
            // 
            this.lsbFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsbFrom.Enabled = false;
            this.lsbFrom.FormattingEnabled = true;
            this.lsbFrom.Location = new System.Drawing.Point(107, 108);
            this.lsbFrom.Name = "lsbFrom";
            this.lsbFrom.Size = new System.Drawing.Size(340, 17);
            this.lsbFrom.TabIndex = 5;
            this.lsbFrom.Visible = false;
            this.lsbFrom.SelectedIndexChanged += new System.EventHandler(this.SelectItemOutOfListBoxFrom);
            // 
            // txbFrom
            // 
            this.txbFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbFrom.BackColor = System.Drawing.SystemColors.Window;
            this.txbFrom.Location = new System.Drawing.Point(107, 78);
            this.txbFrom.Name = "txbFrom";
            this.txbFrom.Size = new System.Drawing.Size(340, 20);
            this.txbFrom.TabIndex = 4;
            this.txbFrom.TextChanged += new System.EventHandler(this.SearchStation);
            // 
            // lsbTo
            // 
            this.lsbTo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsbTo.Enabled = false;
            this.lsbTo.FormattingEnabled = true;
            this.lsbTo.Location = new System.Drawing.Point(107, 161);
            this.lsbTo.Name = "lsbTo";
            this.lsbTo.Size = new System.Drawing.Size(340, 17);
            this.lsbTo.TabIndex = 7;
            this.lsbTo.Visible = false;
            this.lsbTo.SelectedIndexChanged += new System.EventHandler(this.SelectItemOutOfListBoxTo);
            // 
            // txbTo
            // 
            this.txbTo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbTo.BackColor = System.Drawing.SystemColors.Window;
            this.txbTo.Location = new System.Drawing.Point(107, 131);
            this.txbTo.Name = "txbTo";
            this.txbTo.Size = new System.Drawing.Size(340, 20);
            this.txbTo.TabIndex = 6;
            this.txbTo.TextChanged += new System.EventHandler(this.SearchStation);
            // 
            // btnDeparturesForm
            // 
            this.btnDeparturesForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpForm.SetColumnSpan(this.btnDeparturesForm, 2);
            this.btnDeparturesForm.Location = new System.Drawing.Point(473, 3);
            this.btnDeparturesForm.Name = "btnDeparturesForm";
            this.btnDeparturesForm.Size = new System.Drawing.Size(206, 24);
            this.btnDeparturesForm.TabIndex = 3;
            this.btnDeparturesForm.Text = "Departures";
            this.btnDeparturesForm.UseVisualStyleBackColor = true;
            this.btnDeparturesForm.Click += new System.EventHandler(this.OtherForm);
            // 
            // rdbNow
            // 
            this.rdbNow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbNow.AutoSize = true;
            this.rdbNow.Checked = true;
            this.rdbNow.Location = new System.Drawing.Point(453, 78);
            this.rdbNow.Name = "rdbNow";
            this.rdbNow.Size = new System.Drawing.Size(14, 17);
            this.rdbNow.TabIndex = 9;
            this.rdbNow.TabStop = true;
            this.rdbNow.Text = "radioButton1";
            this.rdbNow.UseVisualStyleBackColor = true;
            // 
            // lblNow
            // 
            this.lblNow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNow.AutoSize = true;
            this.lblNow.Location = new System.Drawing.Point(473, 75);
            this.lblNow.Name = "lblNow";
            this.lblNow.Size = new System.Drawing.Size(123, 30);
            this.lblNow.TabIndex = 13;
            this.lblNow.Text = "Now";
            this.lblNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdbDateTime
            // 
            this.rdbDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbDateTime.AutoSize = true;
            this.rdbDateTime.Location = new System.Drawing.Point(453, 131);
            this.rdbDateTime.Name = "rdbDateTime";
            this.rdbDateTime.Size = new System.Drawing.Size(14, 17);
            this.rdbDateTime.TabIndex = 10;
            this.rdbDateTime.Text = "radioButton2";
            this.rdbDateTime.UseVisualStyleBackColor = true;
            // 
            // dtpDepartureDate
            // 
            this.dtpDepartureDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDepartureDate.Location = new System.Drawing.Point(473, 131);
            this.dtpDepartureDate.Name = "dtpDepartureDate";
            this.dtpDepartureDate.Size = new System.Drawing.Size(123, 20);
            this.dtpDepartureDate.TabIndex = 11;
            // 
            // dtpDepartureTime
            // 
            this.dtpDepartureTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDepartureTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpDepartureTime.Location = new System.Drawing.Point(602, 131);
            this.dtpDepartureTime.Name = "dtpDepartureTime";
            this.dtpDepartureTime.ShowUpDown = true;
            this.dtpDepartureTime.Size = new System.Drawing.Size(77, 20);
            this.dtpDepartureTime.TabIndex = 17;
            // 
            // btnConnectionsForm
            // 
            this.btnConnectionsForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnectionsForm.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tlpForm.SetColumnSpan(this.btnConnectionsForm, 4);
            this.btnConnectionsForm.Location = new System.Drawing.Point(3, 3);
            this.btnConnectionsForm.Name = "btnConnectionsForm";
            this.btnConnectionsForm.Size = new System.Drawing.Size(464, 24);
            this.btnConnectionsForm.TabIndex = 2;
            this.btnConnectionsForm.Text = "Connections";
            this.btnConnectionsForm.UseVisualStyleBackColor = false;
            this.btnConnectionsForm.Click += new System.EventHandler(this.OtherForm);
            // 
            // pbxLocation2
            // 
            this.pbxLocation2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxLocation2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxLocation2.Image = ((System.Drawing.Image)(resources.GetObject("pbxLocation2.Image")));
            this.pbxLocation2.Location = new System.Drawing.Point(3, 131);
            this.pbxLocation2.Name = "pbxLocation2";
            this.pbxLocation2.Size = new System.Drawing.Size(29, 24);
            this.pbxLocation2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLocation2.TabIndex = 18;
            this.pbxLocation2.TabStop = false;
            this.pbxLocation2.Click += new System.EventHandler(this.LocationClickTo);
            // 
            // pbxLocation1
            // 
            this.pbxLocation1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxLocation1.BackColor = System.Drawing.SystemColors.Control;
            this.pbxLocation1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxLocation1.BackgroundImage")));
            this.pbxLocation1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxLocation1.Image = ((System.Drawing.Image)(resources.GetObject("pbxLocation1.Image")));
            this.pbxLocation1.Location = new System.Drawing.Point(3, 78);
            this.pbxLocation1.Name = "pbxLocation1";
            this.pbxLocation1.Size = new System.Drawing.Size(29, 24);
            this.pbxLocation1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLocation1.TabIndex = 19;
            this.pbxLocation1.TabStop = false;
            this.pbxLocation1.Click += new System.EventHandler(this.LocationClickFrom);
            // 
            // pbxMail
            // 
            this.pbxMail.Image = ((System.Drawing.Image)(resources.GetObject("pbxMail.Image")));
            this.pbxMail.Location = new System.Drawing.Point(453, 184);
            this.pbxMail.Name = "pbxMail";
            this.pbxMail.Size = new System.Drawing.Size(14, 24);
            this.pbxMail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMail.TabIndex = 20;
            this.pbxMail.TabStop = false;
            this.pbxMail.Click += new System.EventHandler(this.SendMail);
            // 
            // SearchConnectionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 497);
            this.Controls.Add(this.tlpForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(722, 536);
            this.Name = "SearchConnectionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connections";
            this.tlpForm.ResumeLayout(false);
            this.tlpForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepatures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLocation2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLocation1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpForm;
        private System.Windows.Forms.Button btnDeparturesForm;
        private System.Windows.Forms.Button btnConnectionsForm;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpDepartureDate;
        private System.Windows.Forms.RadioButton rdbNow;
        private System.Windows.Forms.RadioButton rdbDateTime;
        private System.Windows.Forms.Label lblNow;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblDepature;
        private System.Windows.Forms.DataGridView dgvDepatures;
        public System.Windows.Forms.ListBox lsbFrom;
        private System.Windows.Forms.TextBox txbFrom;
        public System.Windows.Forms.ListBox lsbTo;
        private System.Windows.Forms.TextBox txbTo;
        private System.Windows.Forms.DateTimePicker dtpDepartureTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPlatform;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDeparture;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnArrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDuration;
        private System.Windows.Forms.PictureBox pbxLocation2;
        private System.Windows.Forms.PictureBox pbxLocation1;
        private System.Windows.Forms.PictureBox pbxMail;
    }
}