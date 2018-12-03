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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnStationForm = new System.Windows.Forms.Button();
            this.btnConnectionsForm = new System.Windows.Forms.Button();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.rdbNow = new System.Windows.Forms.RadioButton();
            this.lblNow = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDeparturesForm = new System.Windows.Forms.Button();
            this.lblDepature = new System.Windows.Forms.Label();
            this.dgvDepatures = new System.Windows.Forms.DataGridView();
            this.lsbFrom = new System.Windows.Forms.ListBox();
            this.txbFrom = new System.Windows.Forms.TextBox();
            this.lsbTo = new System.Windows.Forms.ListBox();
            this.txbTo = new System.Windows.Forms.TextBox();
            this.dtpDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.rdbDateTime = new System.Windows.Forms.RadioButton();
            this.ColumnPlatform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDepartion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnArrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpDepartureTime = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepatures)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.05586F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.27928F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.62138F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.04348F));
            this.tableLayoutPanel1.Controls.Add(this.btnStationForm, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnConnectionsForm, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFrom, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblTo, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.rdbNow, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblNow, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSearch, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblDepature, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvDepatures, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.lsbFrom, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txbFrom, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lsbTo, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txbTo, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.dtpDepartureDate, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.rdbDateTime, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.dtpDepartureTime, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnDeparturesForm, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(682, 627);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // btnStationForm
            // 
            this.btnStationForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStationForm.Location = new System.Drawing.Point(3, 3);
            this.btnStationForm.Name = "btnStationForm";
            this.btnStationForm.Size = new System.Drawing.Size(67, 24);
            this.btnStationForm.TabIndex = 1;
            this.btnStationForm.Text = "Station";
            this.btnStationForm.UseVisualStyleBackColor = true;
            // 
            // btnConnectionsForm
            // 
            this.btnConnectionsForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.btnConnectionsForm, 3);
            this.btnConnectionsForm.Location = new System.Drawing.Point(76, 3);
            this.btnConnectionsForm.Name = "btnConnectionsForm";
            this.btnConnectionsForm.Size = new System.Drawing.Size(515, 24);
            this.btnConnectionsForm.TabIndex = 2;
            this.btnConnectionsForm.Text = "Connections";
            this.btnConnectionsForm.UseVisualStyleBackColor = true;
            // 
            // lblFrom
            // 
            this.lblFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(3, 75);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(67, 30);
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
            this.lblTo.Location = new System.Drawing.Point(3, 131);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(67, 30);
            this.lblTo.TabIndex = 9;
            this.lblTo.Text = "To:";
            this.lblTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdbNow
            // 
            this.rdbNow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbNow.AutoSize = true;
            this.rdbNow.Checked = true;
            this.rdbNow.Location = new System.Drawing.Point(441, 78);
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
            this.lblNow.Location = new System.Drawing.Point(461, 75);
            this.lblNow.Name = "lblNow";
            this.lblNow.Size = new System.Drawing.Size(130, 30);
            this.lblNow.TabIndex = 13;
            this.lblNow.Text = "Now";
            this.lblNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(76, 187);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(359, 24);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search Connectons";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.SearchConnections);
            // 
            // btnDeparturesForm
            // 
            this.btnDeparturesForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeparturesForm.Location = new System.Drawing.Point(597, 3);
            this.btnDeparturesForm.Name = "btnDeparturesForm";
            this.btnDeparturesForm.Size = new System.Drawing.Size(82, 24);
            this.btnDeparturesForm.TabIndex = 3;
            this.btnDeparturesForm.Text = "Departures";
            this.btnDeparturesForm.UseVisualStyleBackColor = true;
            // 
            // lblDepature
            // 
            this.lblDepature.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDepature.AutoSize = true;
            this.lblDepature.Location = new System.Drawing.Point(461, 45);
            this.lblDepature.Name = "lblDepature";
            this.lblDepature.Size = new System.Drawing.Size(130, 30);
            this.lblDepature.TabIndex = 15;
            this.lblDepature.Text = "Departure";
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
            this.ColumnDepartion,
            this.ColumnArrival,
            this.ColumnDuration});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvDepatures, 3);
            this.dgvDepatures.Location = new System.Drawing.Point(76, 217);
            this.dgvDepatures.Name = "dgvDepatures";
            this.dgvDepatures.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvDepatures.Size = new System.Drawing.Size(515, 456);
            this.dgvDepatures.TabIndex = 16;
            this.dgvDepatures.TabStop = false;
            // 
            // lsbFrom
            // 
            this.lsbFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsbFrom.Enabled = false;
            this.lsbFrom.FormattingEnabled = true;
            this.lsbFrom.Location = new System.Drawing.Point(76, 108);
            this.lsbFrom.Name = "lsbFrom";
            this.lsbFrom.Size = new System.Drawing.Size(359, 17);
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
            this.txbFrom.Location = new System.Drawing.Point(76, 78);
            this.txbFrom.Name = "txbFrom";
            this.txbFrom.Size = new System.Drawing.Size(359, 20);
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
            this.lsbTo.Location = new System.Drawing.Point(76, 164);
            this.lsbTo.Name = "lsbTo";
            this.lsbTo.Size = new System.Drawing.Size(359, 17);
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
            this.txbTo.Location = new System.Drawing.Point(76, 134);
            this.txbTo.Name = "txbTo";
            this.txbTo.Size = new System.Drawing.Size(359, 20);
            this.txbTo.TabIndex = 6;
            this.txbTo.TextChanged += new System.EventHandler(this.SearchStation);
            // 
            // dtpDepartureDate
            // 
            this.dtpDepartureDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDepartureDate.Location = new System.Drawing.Point(461, 108);
            this.dtpDepartureDate.Name = "dtpDepartureDate";
            this.dtpDepartureDate.Size = new System.Drawing.Size(130, 20);
            this.dtpDepartureDate.TabIndex = 11;
            // 
            // rdbDateTime
            // 
            this.rdbDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbDateTime.AutoSize = true;
            this.rdbDateTime.Location = new System.Drawing.Point(441, 108);
            this.rdbDateTime.Name = "rdbDateTime";
            this.rdbDateTime.Size = new System.Drawing.Size(14, 17);
            this.rdbDateTime.TabIndex = 10;
            this.rdbDateTime.Text = "radioButton2";
            this.rdbDateTime.UseVisualStyleBackColor = true;
            // 
            // ColumnPlatform
            // 
            this.ColumnPlatform.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnPlatform.HeaderText = "Platform";
            this.ColumnPlatform.Name = "ColumnPlatform";
            // 
            // ColumnDepartion
            // 
            this.ColumnDepartion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDepartion.HeaderText = "Departion";
            this.ColumnDepartion.Name = "ColumnDepartion";
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
            // dtpDepartureTime
            // 
            this.dtpDepartureTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDepartureTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpDepartureTime.Location = new System.Drawing.Point(597, 108);
            this.dtpDepartureTime.Name = "dtpDepartureTime";
            this.dtpDepartureTime.ShowUpDown = true;
            this.dtpDepartureTime.Size = new System.Drawing.Size(82, 20);
            this.dtpDepartureTime.TabIndex = 17;
            // 
            // SearchConnectionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 651);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(659, 690);
            this.Name = "SearchConnectionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connections";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepatures)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnDeparturesForm;
        private System.Windows.Forms.Button btnStationForm;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPlatform;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDepartion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnArrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDuration;
        private System.Windows.Forms.DateTimePicker dtpDepartureTime;
    }
}