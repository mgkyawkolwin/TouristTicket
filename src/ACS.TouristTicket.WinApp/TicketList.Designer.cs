namespace ACS.TouristTicket.WinApp
{
    partial class TicketList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.colSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colSerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colZoneGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReport = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btnPrintView = new System.Windows.Forms.Button();
            this.chkSelected = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSerialNoTo = new System.Windows.Forms.MaskedTextBox();
            this.txtSerialNoFrom = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkCreatedDate = new System.Windows.Forms.CheckBox();
            this.chkTicketInZone = new System.Windows.Forms.CheckBox();
            this.chkTicketSerial = new System.Windows.Forms.CheckBox();
            this.dtCreated2 = new System.Windows.Forms.DateTimePicker();
            this.dtCreated1 = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboZoneGroup = new System.Windows.Forms.ComboBox();
            this.lblBetween1 = new System.Windows.Forms.Label();
            this.btnUnused = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(138, 46);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(180, 23);
            this.cboStatus.TabIndex = 103;
            this.cboStatus.SelectedIndexChanged += new System.EventHandler(this.cboTicket_Condition_SelectedIndexChanged);
            // 
            // dgvList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.dgvList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvList.BackgroundColor = System.Drawing.Color.White;
            this.dgvList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvList.ColumnHeadersHeight = 25;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSelect,
            this.colSerialNo,
            this.colStatus,
            this.colZoneGroup,
            this.colPrice,
            this.colCreatedBy,
            this.colCreatedDate});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvList.EnableHeadersVisualStyles = false;
            this.dgvList.GridColor = System.Drawing.Color.Black;
            this.dgvList.Location = new System.Drawing.Point(0, 203);
            this.dgvList.MultiSelect = false;
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 25;
            this.dgvList.Size = new System.Drawing.Size(1029, 530);
            this.dgvList.TabIndex = 114;
            this.dgvList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellContentClick);
            // 
            // colSelect
            // 
            this.colSelect.HeaderText = "Select";
            this.colSelect.Name = "colSelect";
            this.colSelect.Width = 60;
            // 
            // colSerialNo
            // 
            this.colSerialNo.DataPropertyName = "PKID";
            this.colSerialNo.HeaderText = "Serial No";
            this.colSerialNo.Name = "colSerialNo";
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "TicketStatus";
            this.colStatus.HeaderText = "Ticket Status";
            this.colStatus.Name = "colStatus";
            // 
            // colZoneGroup
            // 
            this.colZoneGroup.DataPropertyName = "ZoneGroupName";
            this.colZoneGroup.HeaderText = "Zone Group";
            this.colZoneGroup.Name = "colZoneGroup";
            this.colZoneGroup.Width = 200;
            // 
            // colPrice
            // 
            this.colPrice.DataPropertyName = "Price";
            this.colPrice.HeaderText = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Width = 60;
            // 
            // colCreatedBy
            // 
            this.colCreatedBy.DataPropertyName = "UserID";
            this.colCreatedBy.HeaderText = "Created By";
            this.colCreatedBy.Name = "colCreatedBy";
            // 
            // colCreatedDate
            // 
            this.colCreatedDate.DataPropertyName = "CreatedDate";
            dataGridViewCellStyle3.Format = "dd, MMM yyyy [hh:mm tt]";
            this.colCreatedDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.colCreatedDate.HeaderText = "Created Date";
            this.colCreatedDate.Name = "colCreatedDate";
            this.colCreatedDate.Width = 150;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(851, 167);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(84, 30);
            this.btnReport.TabIndex = 119;
            this.btnReport.Text = "Report View";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Tan;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1029, 30);
            this.toolStrip1.TabIndex = 122;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.toolStripLabel1.ForeColor = System.Drawing.Color.Black;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(159, 27);
            this.toolStripLabel1.Text = "   Ticket Management   |";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.toolStripLabel2.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(61, 27);
            this.toolStripLabel2.Text = "Ticket List";
            // 
            // btnPrintView
            // 
            this.btnPrintView.Enabled = false;
            this.btnPrintView.Location = new System.Drawing.Point(941, 167);
            this.btnPrintView.Name = "btnPrintView";
            this.btnPrintView.Size = new System.Drawing.Size(84, 30);
            this.btnPrintView.TabIndex = 119;
            this.btnPrintView.Text = "Print View";
            this.btnPrintView.UseVisualStyleBackColor = true;
            this.btnPrintView.Click += new System.EventHandler(this.btnPrintView_Click);
            // 
            // chkSelected
            // 
            this.chkSelected.AutoSize = true;
            this.chkSelected.BackColor = System.Drawing.Color.White;
            this.chkSelected.Location = new System.Drawing.Point(12, 180);
            this.chkSelected.Name = "chkSelected";
            this.chkSelected.Size = new System.Drawing.Size(94, 17);
            this.chkSelected.TabIndex = 124;
            this.chkSelected.Text = "Selection Only";
            this.chkSelected.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 15);
            this.label2.TabIndex = 102;
            this.label2.Text = "Select Ticket Status:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtSerialNoTo);
            this.panel1.Controls.Add(this.txtSerialNoFrom);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.chkCreatedDate);
            this.panel1.Controls.Add(this.chkTicketInZone);
            this.panel1.Controls.Add(this.chkTicketSerial);
            this.panel1.Controls.Add(this.dtCreated2);
            this.panel1.Controls.Add(this.dtCreated1);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.cboZoneGroup);
            this.panel1.Controls.Add(this.lblBetween1);
            this.panel1.Location = new System.Drawing.Point(4, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 86);
            this.panel1.TabIndex = 125;
            // 
            // txtSerialNoTo
            // 
            this.txtSerialNoTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSerialNoTo.Enabled = false;
            this.txtSerialNoTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerialNoTo.Location = new System.Drawing.Point(264, 14);
            this.txtSerialNoTo.Mask = "0000000";
            this.txtSerialNoTo.Name = "txtSerialNoTo";
            this.txtSerialNoTo.PromptChar = '0';
            this.txtSerialNoTo.Size = new System.Drawing.Size(102, 21);
            this.txtSerialNoTo.TabIndex = 163;
            this.txtSerialNoTo.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // txtSerialNoFrom
            // 
            this.txtSerialNoFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSerialNoFrom.Enabled = false;
            this.txtSerialNoFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerialNoFrom.Location = new System.Drawing.Point(133, 14);
            this.txtSerialNoFrom.Mask = "0000000";
            this.txtSerialNoFrom.Name = "txtSerialNoFrom";
            this.txtSerialNoFrom.PromptChar = '0';
            this.txtSerialNoFrom.Size = new System.Drawing.Size(100, 21);
            this.txtSerialNoFrom.TabIndex = 162;
            this.txtSerialNoFrom.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 161;
            this.label3.Text = "< >";
            // 
            // chkCreatedDate
            // 
            this.chkCreatedDate.AutoSize = true;
            this.chkCreatedDate.Location = new System.Drawing.Point(406, 16);
            this.chkCreatedDate.Name = "chkCreatedDate";
            this.chkCreatedDate.Size = new System.Drawing.Size(118, 17);
            this.chkCreatedDate.TabIndex = 158;
            this.chkCreatedDate.Text = "Created Date From:";
            this.chkCreatedDate.UseVisualStyleBackColor = true;
            // 
            // chkTicketInZone
            // 
            this.chkTicketInZone.AutoSize = true;
            this.chkTicketInZone.Location = new System.Drawing.Point(25, 53);
            this.chkTicketInZone.Name = "chkTicketInZone";
            this.chkTicketInZone.Size = new System.Drawing.Size(99, 17);
            this.chkTicketInZone.TabIndex = 159;
            this.chkTicketInZone.Text = "Ticket In Zone:";
            this.chkTicketInZone.UseVisualStyleBackColor = true;
            // 
            // chkTicketSerial
            // 
            this.chkTicketSerial.AutoSize = true;
            this.chkTicketSerial.Location = new System.Drawing.Point(25, 17);
            this.chkTicketSerial.Name = "chkTicketSerial";
            this.chkTicketSerial.Size = new System.Drawing.Size(102, 17);
            this.chkTicketSerial.TabIndex = 160;
            this.chkTicketSerial.Text = "Ticket SerialNo:";
            this.chkTicketSerial.UseVisualStyleBackColor = true;
            // 
            // dtCreated2
            // 
            this.dtCreated2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtCreated2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCreated2.Location = new System.Drawing.Point(530, 51);
            this.dtCreated2.Name = "dtCreated2";
            this.dtCreated2.Size = new System.Drawing.Size(155, 21);
            this.dtCreated2.TabIndex = 156;
            // 
            // dtCreated1
            // 
            this.dtCreated1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtCreated1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCreated1.Location = new System.Drawing.Point(530, 13);
            this.dtCreated1.Name = "dtCreated1";
            this.dtCreated1.Size = new System.Drawing.Size(155, 21);
            this.dtCreated1.TabIndex = 157;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(701, 42);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(84, 30);
            this.btnSearch.TabIndex = 155;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboZoneGroup
            // 
            this.cboZoneGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboZoneGroup.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboZoneGroup.FormattingEnabled = true;
            this.cboZoneGroup.Location = new System.Drawing.Point(133, 50);
            this.cboZoneGroup.Name = "cboZoneGroup";
            this.cboZoneGroup.Size = new System.Drawing.Size(231, 23);
            this.cboZoneGroup.TabIndex = 154;
            // 
            // lblBetween1
            // 
            this.lblBetween1.AutoSize = true;
            this.lblBetween1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBetween1.Location = new System.Drawing.Point(500, 52);
            this.lblBetween1.Name = "lblBetween1";
            this.lblBetween1.Size = new System.Drawing.Size(24, 15);
            this.lblBetween1.TabIndex = 153;
            this.lblBetween1.Text = "To:";
            // 
            // btnUnused
            // 
            this.btnUnused.Enabled = false;
            this.btnUnused.Location = new System.Drawing.Point(726, 167);
            this.btnUnused.Name = "btnUnused";
            this.btnUnused.Size = new System.Drawing.Size(119, 30);
            this.btnUnused.TabIndex = 119;
            this.btnUnused.Text = "Unused Ticket Detail";
            this.btnUnused.UseVisualStyleBackColor = true;
            this.btnUnused.Click += new System.EventHandler(this.btnUnused_Click);
            // 
            // TicketList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1029, 733);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chkSelected);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnPrintView);
            this.Controls.Add(this.btnUnused);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboStatus);
            this.Name = "TicketList";
            this.Text = "Ticket Report";
            this.Load += new System.EventHandler(this.TicketList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.Button btnPrintView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colZoneGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedDate;
        private System.Windows.Forms.CheckBox chkSelected;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox txtSerialNoTo;
        private System.Windows.Forms.MaskedTextBox txtSerialNoFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkCreatedDate;
        private System.Windows.Forms.CheckBox chkTicketInZone;
        private System.Windows.Forms.CheckBox chkTicketSerial;
        private System.Windows.Forms.DateTimePicker dtCreated2;
        private System.Windows.Forms.DateTimePicker dtCreated1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboZoneGroup;
        private System.Windows.Forms.Label lblBetween1;
        private System.Windows.Forms.Button btnUnused;
    }
}