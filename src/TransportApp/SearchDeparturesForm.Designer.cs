namespace TransportApp
{
    partial class SearchDeparturesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchDeparturesForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblStationName = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.rdbStationName = new System.Windows.Forms.RadioButton();
            this.lblStationNameRDB = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblLocation = new System.Windows.Forms.Label();
            this.dgvDepatures = new System.Windows.Forms.DataGridView();
            this.ColumnStationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDeparture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lsbStationName = new System.Windows.Forms.ListBox();
            this.txbCurrentLocation = new System.Windows.Forms.TextBox();
            this.btnDeparturesForm = new System.Windows.Forms.Button();
            this.rdbCurrentLocation = new System.Windows.Forms.RadioButton();
            this.txbStationName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxLocation1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lsbCurrentLocation = new System.Windows.Forms.ListBox();
            this.btnConnectionsForm = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepatures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLocation1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.05586F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.27928F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.62138F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.04348F));
            this.tableLayoutPanel1.Controls.Add(this.lblStationName, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblTo, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.rdbStationName, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblStationNameRDB, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSearch, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblLocation, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvDepatures, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.lsbStationName, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.txbCurrentLocation, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnDeparturesForm, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.rdbCurrentLocation, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.txbStationName, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.pbxLocation1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lsbCurrentLocation, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnConnectionsForm, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(682, 473);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // lblStationName
            // 
            this.lblStationName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStationName.AutoSize = true;
            this.lblStationName.Location = new System.Drawing.Point(33, 74);
            this.lblStationName.Name = "lblStationName";
            this.lblStationName.Size = new System.Drawing.Size(63, 31);
            this.lblStationName.TabIndex = 8;
            this.lblStationName.Text = "Station Name:";
            this.lblStationName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTo
            // 
            this.lblTo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(33, 128);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(63, 30);
            this.lblTo.TabIndex = 9;
            this.lblTo.Text = "Current Location:";
            this.lblTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdbStationName
            // 
            this.rdbStationName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbStationName.AutoSize = true;
            this.rdbStationName.Checked = true;
            this.rdbStationName.Location = new System.Drawing.Point(451, 77);
            this.rdbStationName.Name = "rdbStationName";
            this.rdbStationName.Size = new System.Drawing.Size(14, 17);
            this.rdbStationName.TabIndex = 9;
            this.rdbStationName.TabStop = true;
            this.rdbStationName.Text = "radioButton1";
            this.rdbStationName.UseVisualStyleBackColor = true;
            // 
            // lblStationNameRDB
            // 
            this.lblStationNameRDB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStationNameRDB.AutoSize = true;
            this.lblStationNameRDB.Location = new System.Drawing.Point(471, 74);
            this.lblStationNameRDB.Name = "lblStationNameRDB";
            this.lblStationNameRDB.Size = new System.Drawing.Size(124, 31);
            this.lblStationNameRDB.TabIndex = 13;
            this.lblStationNameRDB.Text = "Search by Station Name";
            this.lblStationNameRDB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(102, 184);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(343, 24);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search Departures";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.SearchDepartures);
            // 
            // lblLocation
            // 
            this.lblLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(471, 45);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(124, 29);
            this.lblLocation.TabIndex = 15;
            this.lblLocation.Text = "Location";
            this.lblLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvDepatures
            // 
            this.dgvDepatures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDepatures.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDepatures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepatures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnStationName,
            this.ColumnDeparture,
            this.ColumnLine,
            this.ColumnTo});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvDepatures, 3);
            this.dgvDepatures.Location = new System.Drawing.Point(102, 214);
            this.dgvDepatures.Name = "dgvDepatures";
            this.dgvDepatures.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvDepatures.Size = new System.Drawing.Size(493, 279);
            this.dgvDepatures.TabIndex = 16;
            this.dgvDepatures.TabStop = false;
            // 
            // ColumnStationName
            // 
            this.ColumnStationName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnStationName.HeaderText = "Station Name";
            this.ColumnStationName.Name = "ColumnStationName";
            // 
            // ColumnDeparture
            // 
            this.ColumnDeparture.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDeparture.HeaderText = "Departure";
            this.ColumnDeparture.Name = "ColumnDeparture";
            // 
            // ColumnLine
            // 
            this.ColumnLine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnLine.HeaderText = "Line";
            this.ColumnLine.Name = "ColumnLine";
            // 
            // ColumnTo
            // 
            this.ColumnTo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnTo.HeaderText = "To";
            this.ColumnTo.Name = "ColumnTo";
            // 
            // lsbStationName
            // 
            this.lsbStationName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsbStationName.Enabled = false;
            this.lsbStationName.FormattingEnabled = true;
            this.lsbStationName.Location = new System.Drawing.Point(102, 108);
            this.lsbStationName.Name = "lsbStationName";
            this.lsbStationName.Size = new System.Drawing.Size(343, 17);
            this.lsbStationName.TabIndex = 5;
            this.lsbStationName.Visible = false;
            this.lsbStationName.SelectedIndexChanged += new System.EventHandler(this.SelectItemOutOfListBoxStationName);
            // 
            // txbCurrentLocation
            // 
            this.txbCurrentLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbCurrentLocation.BackColor = System.Drawing.SystemColors.Window;
            this.txbCurrentLocation.Location = new System.Drawing.Point(102, 131);
            this.txbCurrentLocation.Name = "txbCurrentLocation";
            this.txbCurrentLocation.Size = new System.Drawing.Size(343, 20);
            this.txbCurrentLocation.TabIndex = 6;
            this.txbCurrentLocation.TextChanged += new System.EventHandler(this.SearchStation);
            // 
            // btnDeparturesForm
            // 
            this.btnDeparturesForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.btnDeparturesForm, 2);
            this.btnDeparturesForm.Location = new System.Drawing.Point(471, 3);
            this.btnDeparturesForm.Name = "btnDeparturesForm";
            this.btnDeparturesForm.Size = new System.Drawing.Size(208, 24);
            this.btnDeparturesForm.TabIndex = 2;
            this.btnDeparturesForm.Text = "Departures";
            this.btnDeparturesForm.UseVisualStyleBackColor = true;
            // 
            // rdbCurrentLocation
            // 
            this.rdbCurrentLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbCurrentLocation.AutoSize = true;
            this.rdbCurrentLocation.Location = new System.Drawing.Point(451, 131);
            this.rdbCurrentLocation.Name = "rdbCurrentLocation";
            this.rdbCurrentLocation.Size = new System.Drawing.Size(14, 17);
            this.rdbCurrentLocation.TabIndex = 10;
            this.rdbCurrentLocation.Text = "rdbCurrentLocation";
            this.rdbCurrentLocation.UseVisualStyleBackColor = true;
            // 
            // txbStationName
            // 
            this.txbStationName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbStationName.BackColor = System.Drawing.SystemColors.Window;
            this.txbStationName.Location = new System.Drawing.Point(102, 77);
            this.txbStationName.Name = "txbStationName";
            this.txbStationName.Size = new System.Drawing.Size(343, 20);
            this.txbStationName.TabIndex = 3;
            this.txbStationName.TextChanged += new System.EventHandler(this.SearchStation);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(471, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 30);
            this.label1.TabIndex = 17;
            this.label1.Text = "Search by Current Location";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.pbxLocation1.Location = new System.Drawing.Point(3, 77);
            this.pbxLocation1.Name = "pbxLocation1";
            this.pbxLocation1.Size = new System.Drawing.Size(24, 25);
            this.pbxLocation1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLocation1.TabIndex = 20;
            this.pbxLocation1.TabStop = false;
            this.pbxLocation1.Click += new System.EventHandler(this.StationNameMapClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // lsbCurrentLocation
            // 
            this.lsbCurrentLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsbCurrentLocation.Enabled = false;
            this.lsbCurrentLocation.FormattingEnabled = true;
            this.lsbCurrentLocation.Location = new System.Drawing.Point(102, 161);
            this.lsbCurrentLocation.Name = "lsbCurrentLocation";
            this.lsbCurrentLocation.Size = new System.Drawing.Size(343, 17);
            this.lsbCurrentLocation.TabIndex = 22;
            this.lsbCurrentLocation.Visible = false;
            this.lsbCurrentLocation.SelectedIndexChanged += new System.EventHandler(this.SelectItemOutOfListBoxCurrentLocation);
            // 
            // btnConnectionsForm
            // 
            this.btnConnectionsForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.btnConnectionsForm, 4);
            this.btnConnectionsForm.Location = new System.Drawing.Point(3, 3);
            this.btnConnectionsForm.Name = "btnConnectionsForm";
            this.btnConnectionsForm.Size = new System.Drawing.Size(462, 24);
            this.btnConnectionsForm.TabIndex = 1;
            this.btnConnectionsForm.Text = "Connections";
            this.btnConnectionsForm.UseVisualStyleBackColor = true;
            // 
            // SearchDeparturesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 497);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SearchDeparturesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Departures";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepatures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLocation1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnConnectionsForm;
        private System.Windows.Forms.Label lblStationName;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.RadioButton rdbStationName;
        private System.Windows.Forms.Label lblStationNameRDB;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.DataGridView dgvDepatures;
        public System.Windows.Forms.ListBox lsbStationName;
        private System.Windows.Forms.TextBox txbStationName;
        private System.Windows.Forms.TextBox txbCurrentLocation;
        private System.Windows.Forms.RadioButton rdbCurrentLocation;
        private System.Windows.Forms.Button btnDeparturesForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxLocation1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDeparture;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTo;
        public System.Windows.Forms.ListBox lsbCurrentLocation;
    }
}