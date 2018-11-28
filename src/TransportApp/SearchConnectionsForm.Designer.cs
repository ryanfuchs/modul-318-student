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
            this.cmbFrom = new System.Windows.Forms.ComboBox();
            this.cmbTo = new System.Windows.Forms.ComboBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpDepature = new System.Windows.Forms.DateTimePicker();
            this.rdbNow = new System.Windows.Forms.RadioButton();
            this.rdbDateTime = new System.Windows.Forms.RadioButton();
            this.lblNow = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDeparturesForm = new System.Windows.Forms.Button();
            this.lblDepature = new System.Windows.Forms.Label();
            this.dgvDepatures = new System.Windows.Forms.DataGridView();
            this.ColumnPlatform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDepartion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnArrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepatures)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.71424F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.57117F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.71459F));
            this.tableLayoutPanel1.Controls.Add(this.btnStationForm, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnConnectionsForm, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbFrom, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmbTo, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblFrom, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblTo, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.dtpDepature, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.rdbNow, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.rdbDateTime, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblNow, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSearch, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnDeparturesForm, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDepature, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvDepatures, 1, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(566, 627);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // btnStationForm
            // 
            this.btnStationForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStationForm.Location = new System.Drawing.Point(3, 3);
            this.btnStationForm.Name = "btnStationForm";
            this.btnStationForm.Size = new System.Drawing.Size(63, 24);
            this.btnStationForm.TabIndex = 4;
            this.btnStationForm.Text = "Station";
            this.btnStationForm.UseVisualStyleBackColor = true;
            // 
            // btnConnectionsForm
            // 
            this.btnConnectionsForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnectionsForm.Location = new System.Drawing.Point(72, 3);
            this.btnConnectionsForm.Name = "btnConnectionsForm";
            this.btnConnectionsForm.Size = new System.Drawing.Size(341, 24);
            this.btnConnectionsForm.TabIndex = 3;
            this.btnConnectionsForm.Text = "Connections";
            this.btnConnectionsForm.UseVisualStyleBackColor = true;
            // 
            // cmbFrom
            // 
            this.cmbFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFrom.FormattingEnabled = true;
            this.cmbFrom.Location = new System.Drawing.Point(72, 78);
            this.cmbFrom.Name = "cmbFrom";
            this.cmbFrom.Size = new System.Drawing.Size(341, 21);
            this.cmbFrom.TabIndex = 6;
            this.cmbFrom.DropDown += new System.EventHandler(this.SearchStationFrom);
            // 
            // cmbTo
            // 
            this.cmbTo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTo.FormattingEnabled = true;
            this.cmbTo.Location = new System.Drawing.Point(72, 108);
            this.cmbTo.Name = "cmbTo";
            this.cmbTo.Size = new System.Drawing.Size(341, 21);
            this.cmbTo.TabIndex = 7;
            this.cmbTo.DropDown += new System.EventHandler(this.SearchStationTo);
            // 
            // lblFrom
            // 
            this.lblFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(3, 75);
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
            this.lblTo.Location = new System.Drawing.Point(3, 105);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(63, 30);
            this.lblTo.TabIndex = 9;
            this.lblTo.Text = "To:";
            this.lblTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpDepature
            // 
            this.dtpDepature.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDepature.Location = new System.Drawing.Point(439, 108);
            this.dtpDepature.Name = "dtpDepature";
            this.dtpDepature.Size = new System.Drawing.Size(124, 20);
            this.dtpDepature.TabIndex = 10;
            // 
            // rdbNow
            // 
            this.rdbNow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbNow.AutoSize = true;
            this.rdbNow.Location = new System.Drawing.Point(419, 78);
            this.rdbNow.Name = "rdbNow";
            this.rdbNow.Size = new System.Drawing.Size(14, 24);
            this.rdbNow.TabIndex = 11;
            this.rdbNow.TabStop = true;
            this.rdbNow.Text = "radioButton1";
            this.rdbNow.UseVisualStyleBackColor = true;
            // 
            // rdbDateTime
            // 
            this.rdbDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbDateTime.AutoSize = true;
            this.rdbDateTime.Location = new System.Drawing.Point(419, 108);
            this.rdbDateTime.Name = "rdbDateTime";
            this.rdbDateTime.Size = new System.Drawing.Size(14, 24);
            this.rdbDateTime.TabIndex = 12;
            this.rdbDateTime.TabStop = true;
            this.rdbDateTime.Text = "radioButton2";
            this.rdbDateTime.UseVisualStyleBackColor = true;
            // 
            // lblNow
            // 
            this.lblNow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNow.AutoSize = true;
            this.lblNow.Location = new System.Drawing.Point(439, 75);
            this.lblNow.Name = "lblNow";
            this.lblNow.Size = new System.Drawing.Size(124, 30);
            this.lblNow.TabIndex = 13;
            this.lblNow.Text = "Now";
            this.lblNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(72, 138);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(341, 24);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "SearchConnectons";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.SearchConnections);
            // 
            // btnDeparturesForm
            // 
            this.btnDeparturesForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.btnDeparturesForm, 2);
            this.btnDeparturesForm.Location = new System.Drawing.Point(419, 3);
            this.btnDeparturesForm.Name = "btnDeparturesForm";
            this.btnDeparturesForm.Size = new System.Drawing.Size(144, 24);
            this.btnDeparturesForm.TabIndex = 5;
            this.btnDeparturesForm.Text = "Departures";
            this.btnDeparturesForm.UseVisualStyleBackColor = true;
            // 
            // lblDepature
            // 
            this.lblDepature.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDepature.AutoSize = true;
            this.lblDepature.Location = new System.Drawing.Point(439, 45);
            this.lblDepature.Name = "lblDepature";
            this.lblDepature.Size = new System.Drawing.Size(124, 30);
            this.lblDepature.TabIndex = 15;
            this.lblDepature.Text = "Departure";
            this.lblDepature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvDepatures
            // 
            this.dgvDepatures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDepatures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepatures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPlatform,
            this.ColumnDepartion,
            this.ColumnArrival,
            this.ColumnDuration});
            this.dgvDepatures.Location = new System.Drawing.Point(72, 168);
            this.dgvDepatures.Name = "dgvDepatures";
            this.dgvDepatures.Size = new System.Drawing.Size(341, 456);
            this.dgvDepatures.TabIndex = 16;
            // 
            // ColumnPlatform
            // 
            this.ColumnPlatform.HeaderText = "Platform";
            this.ColumnPlatform.Name = "ColumnPlatform";
            this.ColumnPlatform.Width = 75;
            // 
            // ColumnDepartion
            // 
            this.ColumnDepartion.HeaderText = "Departion";
            this.ColumnDepartion.Name = "ColumnDepartion";
            this.ColumnDepartion.Width = 75;
            // 
            // ColumnArrival
            // 
            this.ColumnArrival.HeaderText = "Arrival";
            this.ColumnArrival.Name = "ColumnArrival";
            this.ColumnArrival.Width = 75;
            // 
            // ColumnDuration
            // 
            this.ColumnDuration.HeaderText = "Duration";
            this.ColumnDuration.Name = "ColumnDuration";
            this.ColumnDuration.Width = 75;
            // 
            // SearchConnectionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 651);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(458, 572);
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
        private System.Windows.Forms.ComboBox cmbFrom;
        private System.Windows.Forms.ComboBox cmbTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpDepature;
        private System.Windows.Forms.RadioButton rdbNow;
        private System.Windows.Forms.RadioButton rdbDateTime;
        private System.Windows.Forms.Label lblNow;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblDepature;
        private System.Windows.Forms.DataGridView dgvDepatures;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPlatform;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDepartion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnArrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDuration;
    }
}