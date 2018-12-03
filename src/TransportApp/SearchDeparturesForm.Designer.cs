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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblStationName = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.rdbStationName = new System.Windows.Forms.RadioButton();
            this.lblStationNameRDB = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblLocation = new System.Windows.Forms.Label();
            this.dgvDepatures = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnShowLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnArrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lsbStationName = new System.Windows.Forms.ListBox();
            this.txbCurrentLocation = new System.Windows.Forms.TextBox();
            this.btnConnectionsForm = new System.Windows.Forms.Button();
            this.btnDeparturesForm = new System.Windows.Forms.Button();
            this.rdbCurrentLocation = new System.Windows.Forms.RadioButton();
            this.txbStationName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel1.Controls.Add(this.lblStationName, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblTo, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.rdbStationName, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblStationNameRDB, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSearch, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblLocation, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvDepatures, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.lsbStationName, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txbCurrentLocation, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnConnectionsForm, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDeparturesForm, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.rdbCurrentLocation, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.txbStationName, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 3, 5);
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
            this.lblStationName.Location = new System.Drawing.Point(3, 74);
            this.lblStationName.Name = "lblStationName";
            this.lblStationName.Size = new System.Drawing.Size(67, 31);
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
            this.lblTo.Location = new System.Drawing.Point(3, 128);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(67, 30);
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
            this.rdbStationName.Location = new System.Drawing.Point(441, 77);
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
            this.lblStationNameRDB.Location = new System.Drawing.Point(461, 74);
            this.lblStationNameRDB.Name = "lblStationNameRDB";
            this.lblStationNameRDB.Size = new System.Drawing.Size(130, 31);
            this.lblStationNameRDB.TabIndex = 13;
            this.lblStationNameRDB.Text = "Search by Station Name";
            this.lblStationNameRDB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(76, 161);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(359, 24);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search Departures";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblLocation
            // 
            this.lblLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(461, 45);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(130, 29);
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
            this.ColumnName,
            this.ColumnShowLocation,
            this.ColumnArrival,
            this.ColumnDuration});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvDepatures, 3);
            this.dgvDepatures.Location = new System.Drawing.Point(76, 191);
            this.dgvDepatures.Name = "dgvDepatures";
            this.dgvDepatures.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvDepatures.Size = new System.Drawing.Size(515, 279);
            this.dgvDepatures.TabIndex = 16;
            this.dgvDepatures.TabStop = false;
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            // 
            // ColumnShowLocation
            // 
            this.ColumnShowLocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnShowLocation.HeaderText = "Show Location";
            this.ColumnShowLocation.Name = "ColumnShowLocation";
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
            // lsbStationName
            // 
            this.lsbStationName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsbStationName.Enabled = false;
            this.lsbStationName.FormattingEnabled = true;
            this.lsbStationName.Location = new System.Drawing.Point(76, 108);
            this.lsbStationName.Name = "lsbStationName";
            this.lsbStationName.Size = new System.Drawing.Size(359, 17);
            this.lsbStationName.TabIndex = 5;
            this.lsbStationName.Visible = false;
            // 
            // txbCurrentLocation
            // 
            this.txbCurrentLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbCurrentLocation.BackColor = System.Drawing.SystemColors.Window;
            this.txbCurrentLocation.Location = new System.Drawing.Point(76, 131);
            this.txbCurrentLocation.Name = "txbCurrentLocation";
            this.txbCurrentLocation.Size = new System.Drawing.Size(359, 20);
            this.txbCurrentLocation.TabIndex = 6;
            // 
            // btnConnectionsForm
            // 
            this.btnConnectionsForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.btnConnectionsForm, 3);
            this.btnConnectionsForm.Location = new System.Drawing.Point(3, 3);
            this.btnConnectionsForm.Name = "btnConnectionsForm";
            this.btnConnectionsForm.Size = new System.Drawing.Size(452, 24);
            this.btnConnectionsForm.TabIndex = 1;
            this.btnConnectionsForm.Text = "Connections";
            this.btnConnectionsForm.UseVisualStyleBackColor = true;
            // 
            // btnDeparturesForm
            // 
            this.btnDeparturesForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.btnDeparturesForm, 2);
            this.btnDeparturesForm.Location = new System.Drawing.Point(461, 3);
            this.btnDeparturesForm.Name = "btnDeparturesForm";
            this.btnDeparturesForm.Size = new System.Drawing.Size(218, 24);
            this.btnDeparturesForm.TabIndex = 2;
            this.btnDeparturesForm.Text = "Departures";
            this.btnDeparturesForm.UseVisualStyleBackColor = true;
            // 
            // rdbCurrentLocation
            // 
            this.rdbCurrentLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbCurrentLocation.AutoSize = true;
            this.rdbCurrentLocation.Location = new System.Drawing.Point(441, 131);
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
            this.txbStationName.Location = new System.Drawing.Point(76, 77);
            this.txbStationName.Name = "txbStationName";
            this.txbStationName.Size = new System.Drawing.Size(359, 20);
            this.txbStationName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(461, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 30);
            this.label1.TabIndex = 17;
            this.label1.Text = "Search by Current Location";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnShowLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnArrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDuration;
        private System.Windows.Forms.Label label1;
    }
}