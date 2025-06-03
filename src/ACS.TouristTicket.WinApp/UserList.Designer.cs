namespace ACS.TouristTicket.WinApp
{
    partial class UserList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.cboUserStatus = new System.Windows.Forms.ComboBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.chkLoginDate = new System.Windows.Forms.CheckBox();
            this.chkCreatedDate = new System.Windows.Forms.CheckBox();
            this.chkDisplayName = new System.Windows.Forms.CheckBox();
            this.dtpLoginDateTo = new System.Windows.Forms.DateTimePicker();
            this.dtpLoginDateFrom = new System.Windows.Forms.DateTimePicker();
            this.lblBetween1 = new System.Windows.Forms.Label();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpCreatedDateFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpCreatedDateTo = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.colUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastLoginDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(543, 128);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 30);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(705, 128);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 30);
            this.btnPrint.TabIndex = 12;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // cboUserStatus
            // 
            this.cboUserStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUserStatus.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUserStatus.FormattingEnabled = true;
            this.cboUserStatus.Location = new System.Drawing.Point(156, 43);
            this.cboUserStatus.Name = "cboUserStatus";
            this.cboUserStatus.Size = new System.Drawing.Size(165, 23);
            this.cboUserStatus.TabIndex = 1;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.dgvList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvList.ColumnHeadersHeight = 25;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUserID,
            this.colDisplayName,
            this.colStatus,
            this.colLastLoginDate,
            this.colCreatedDate,
            this.colCreatedBy});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvList.EnableHeadersVisualStyles = false;
            this.dgvList.GridColor = System.Drawing.Color.Tan;
            this.dgvList.Location = new System.Drawing.Point(0, 164);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowTemplate.Height = 25;
            this.dgvList.Size = new System.Drawing.Size(893, 569);
            this.dgvList.TabIndex = 12;
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
            this.toolStrip1.Size = new System.Drawing.Size(893, 30);
            this.toolStrip1.TabIndex = 135;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.toolStripLabel1.ForeColor = System.Drawing.Color.Black;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(151, 27);
            this.toolStripLabel1.Text = "   User Management   |";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.toolStripLabel2.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(55, 27);
            this.toolStripLabel2.Text = "User List";
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Location = new System.Drawing.Point(13, 46);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(84, 17);
            this.chkStatus.TabIndex = 0;
            this.chkStatus.Text = "User Status:";
            this.chkStatus.UseVisualStyleBackColor = true;
            this.chkStatus.CheckedChanged += new System.EventHandler(this.chkStatus_CheckedChanged);
            // 
            // chkLoginDate
            // 
            this.chkLoginDate.AutoSize = true;
            this.chkLoginDate.Location = new System.Drawing.Point(13, 106);
            this.chkLoginDate.Name = "chkLoginDate";
            this.chkLoginDate.Size = new System.Drawing.Size(107, 17);
            this.chkLoginDate.TabIndex = 4;
            this.chkLoginDate.Text = "Login Date From:";
            this.chkLoginDate.UseVisualStyleBackColor = true;
            this.chkLoginDate.CheckedChanged += new System.EventHandler(this.chkLoginDate_CheckedChanged);
            // 
            // chkCreatedDate
            // 
            this.chkCreatedDate.AutoSize = true;
            this.chkCreatedDate.Location = new System.Drawing.Point(13, 135);
            this.chkCreatedDate.Name = "chkCreatedDate";
            this.chkCreatedDate.Size = new System.Drawing.Size(118, 17);
            this.chkCreatedDate.TabIndex = 7;
            this.chkCreatedDate.Text = "Created Date From:";
            this.chkCreatedDate.UseVisualStyleBackColor = true;
            this.chkCreatedDate.CheckedChanged += new System.EventHandler(this.chkCreatedDate_CheckedChanged);
            // 
            // chkDisplayName
            // 
            this.chkDisplayName.AutoSize = true;
            this.chkDisplayName.Location = new System.Drawing.Point(13, 77);
            this.chkDisplayName.Name = "chkDisplayName";
            this.chkDisplayName.Size = new System.Drawing.Size(94, 17);
            this.chkDisplayName.TabIndex = 2;
            this.chkDisplayName.Text = "Display Name:";
            this.chkDisplayName.UseVisualStyleBackColor = true;
            this.chkDisplayName.CheckedChanged += new System.EventHandler(this.chkDisplayName_CheckedChanged);
            // 
            // dtpLoginDateTo
            // 
            this.dtpLoginDateTo.CustomFormat = "dd-MMM-yyyy";
            this.dtpLoginDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpLoginDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLoginDateTo.Location = new System.Drawing.Point(357, 102);
            this.dtpLoginDateTo.Name = "dtpLoginDateTo";
            this.dtpLoginDateTo.Size = new System.Drawing.Size(155, 21);
            this.dtpLoginDateTo.TabIndex = 6;
            // 
            // dtpLoginDateFrom
            // 
            this.dtpLoginDateFrom.CustomFormat = "dd-MMM-yyyy";
            this.dtpLoginDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpLoginDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLoginDateFrom.Location = new System.Drawing.Point(156, 102);
            this.dtpLoginDateFrom.Name = "dtpLoginDateFrom";
            this.dtpLoginDateFrom.Size = new System.Drawing.Size(165, 21);
            this.dtpLoginDateFrom.TabIndex = 5;
            // 
            // lblBetween1
            // 
            this.lblBetween1.AutoSize = true;
            this.lblBetween1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBetween1.Location = new System.Drawing.Point(327, 106);
            this.lblBetween1.Name = "lblBetween1";
            this.lblBetween1.Size = new System.Drawing.Size(24, 15);
            this.lblBetween1.TabIndex = 158;
            this.lblBetween1.Text = "To:";
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDisplayName.Location = new System.Drawing.Point(156, 75);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(165, 20);
            this.txtDisplayName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 158;
            this.label1.Text = "To:";
            // 
            // dtpCreatedDateFrom
            // 
            this.dtpCreatedDateFrom.CustomFormat = "dd-MMM-yyyy";
            this.dtpCreatedDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCreatedDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCreatedDateFrom.Location = new System.Drawing.Point(156, 133);
            this.dtpCreatedDateFrom.Name = "dtpCreatedDateFrom";
            this.dtpCreatedDateFrom.Size = new System.Drawing.Size(165, 21);
            this.dtpCreatedDateFrom.TabIndex = 8;
            // 
            // dtpCreatedDateTo
            // 
            this.dtpCreatedDateTo.CustomFormat = "dd-MMM-yyyy";
            this.dtpCreatedDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCreatedDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCreatedDateTo.Location = new System.Drawing.Point(357, 133);
            this.dtpCreatedDateTo.Name = "dtpCreatedDateTo";
            this.dtpCreatedDateTo.Size = new System.Drawing.Size(155, 21);
            this.dtpCreatedDateTo.TabIndex = 9;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(624, 128);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // colUserID
            // 
            this.colUserID.DataPropertyName = "UserID";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.colUserID.DefaultCellStyle = dataGridViewCellStyle3;
            this.colUserID.HeaderText = "UserID";
            this.colUserID.Name = "colUserID";
            this.colUserID.ReadOnly = true;
            this.colUserID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colUserID.Width = 120;
            // 
            // colDisplayName
            // 
            this.colDisplayName.DataPropertyName = "DisplayName";
            this.colDisplayName.HeaderText = "Display Name";
            this.colDisplayName.Name = "colDisplayName";
            this.colDisplayName.ReadOnly = true;
            this.colDisplayName.Width = 220;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "Status";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colStatus.DefaultCellStyle = dataGridViewCellStyle4;
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 90;
            // 
            // colLastLoginDate
            // 
            this.colLastLoginDate.DataPropertyName = "AccessDate";
            dataGridViewCellStyle5.Format = "dd - MMM  -yyyy ";
            dataGridViewCellStyle5.NullValue = null;
            this.colLastLoginDate.DefaultCellStyle = dataGridViewCellStyle5;
            this.colLastLoginDate.HeaderText = "Last Login Date";
            this.colLastLoginDate.Name = "colLastLoginDate";
            this.colLastLoginDate.ReadOnly = true;
            this.colLastLoginDate.Width = 120;
            // 
            // colCreatedDate
            // 
            this.colCreatedDate.DataPropertyName = "CreatedDate";
            dataGridViewCellStyle6.Format = "dd - MMM - yyyy";
            dataGridViewCellStyle6.NullValue = null;
            this.colCreatedDate.DefaultCellStyle = dataGridViewCellStyle6;
            this.colCreatedDate.HeaderText = "Created Date";
            this.colCreatedDate.Name = "colCreatedDate";
            this.colCreatedDate.ReadOnly = true;
            this.colCreatedDate.Width = 120;
            // 
            // colCreatedBy
            // 
            this.colCreatedBy.DataPropertyName = "CreatedBy_DisplayName";
            dataGridViewCellStyle7.NullValue = null;
            this.colCreatedBy.DefaultCellStyle = dataGridViewCellStyle7;
            this.colCreatedBy.HeaderText = "Created By";
            this.colCreatedBy.Name = "colCreatedBy";
            this.colCreatedBy.ReadOnly = true;
            this.colCreatedBy.Width = 120;
            // 
            // UserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(893, 733);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtDisplayName);
            this.Controls.Add(this.dtpCreatedDateTo);
            this.Controls.Add(this.dtpLoginDateTo);
            this.Controls.Add(this.dtpCreatedDateFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpLoginDateFrom);
            this.Controls.Add(this.lblBetween1);
            this.Controls.Add(this.chkDisplayName);
            this.Controls.Add(this.chkCreatedDate);
            this.Controls.Add(this.chkLoginDate);
            this.Controls.Add(this.chkStatus);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.cboUserStatus);
            this.Name = "UserList";
            this.Text = "List of User";
            this.Load += new System.EventHandler(this.List_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ComboBox cboUserStatus;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.CheckBox chkLoginDate;
        private System.Windows.Forms.CheckBox chkCreatedDate;
        private System.Windows.Forms.CheckBox chkDisplayName;
        private System.Windows.Forms.DateTimePicker dtpLoginDateTo;
        private System.Windows.Forms.DateTimePicker dtpLoginDateFrom;
        private System.Windows.Forms.Label lblBetween1;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpCreatedDateFrom;
        private System.Windows.Forms.DateTimePicker dtpCreatedDateTo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDisplayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastLoginDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedBy;
    }
}