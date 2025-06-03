namespace ACS.TouristTicket.WinApp
{
    partial class ZoneGroup
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvZoneGroup = new System.Windows.Forms.DataGridView();
            this.dgcZoneGroupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcZoneGroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcDaysAllowed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcEntriesAllowed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDaysAllowed = new System.Windows.Forms.TextBox();
            this.txtEntriesAllowed = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtZoneGroupID = new System.Windows.Forms.TextBox();
            this.txtZoneGroupName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZoneGroup)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvZoneGroup
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.AntiqueWhite;
            this.dgvZoneGroup.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvZoneGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvZoneGroup.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvZoneGroup.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvZoneGroup.ColumnHeadersHeight = 25;
            this.dgvZoneGroup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcZoneGroupID,
            this.dgcZoneGroupName,
            this.dgcDaysAllowed,
            this.dgcEntriesAllowed,
            this.dgcPrice});
            this.dgvZoneGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvZoneGroup.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvZoneGroup.EnableHeadersVisualStyles = false;
            this.dgvZoneGroup.GridColor = System.Drawing.Color.Wheat;
            this.dgvZoneGroup.Location = new System.Drawing.Point(3, 186);
            this.dgvZoneGroup.MultiSelect = false;
            this.dgvZoneGroup.Name = "dgvZoneGroup";
            this.dgvZoneGroup.ReadOnly = true;
            this.dgvZoneGroup.RowTemplate.Height = 25;
            this.dgvZoneGroup.Size = new System.Drawing.Size(1146, 304);
            this.dgvZoneGroup.TabIndex = 21;
            this.dgvZoneGroup.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZoneGroup_CellClick);
            this.dgvZoneGroup.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZoneGroup_CellContentClick);
            // 
            // dgcZoneGroupID
            // 
            this.dgcZoneGroupID.DataPropertyName = "ZoneGroupID";
            this.dgcZoneGroupID.HeaderText = "Zone Group ID";
            this.dgcZoneGroupID.Name = "dgcZoneGroupID";
            this.dgcZoneGroupID.ReadOnly = true;
            // 
            // dgcZoneGroupName
            // 
            this.dgcZoneGroupName.DataPropertyName = "ZoneGroupName";
            this.dgcZoneGroupName.HeaderText = "Zone Group Name";
            this.dgcZoneGroupName.Name = "dgcZoneGroupName";
            this.dgcZoneGroupName.ReadOnly = true;
            this.dgcZoneGroupName.Width = 250;
            // 
            // dgcDaysAllowed
            // 
            this.dgcDaysAllowed.DataPropertyName = "DaysAllowed";
            this.dgcDaysAllowed.HeaderText = "Days Allowed";
            this.dgcDaysAllowed.Name = "dgcDaysAllowed";
            this.dgcDaysAllowed.ReadOnly = true;
            // 
            // dgcEntriesAllowed
            // 
            this.dgcEntriesAllowed.DataPropertyName = "EntriesAllowed";
            this.dgcEntriesAllowed.HeaderText = "Entries Allowed";
            this.dgcEntriesAllowed.Name = "dgcEntriesAllowed";
            this.dgcEntriesAllowed.ReadOnly = true;
            // 
            // dgcPrice
            // 
            this.dgcPrice.DataPropertyName = "Price";
            this.dgcPrice.HeaderText = "Price";
            this.dgcPrice.Name = "dgcPrice";
            this.dgcPrice.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.dgvZoneGroup);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1163, 495);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtDaysAllowed);
            this.panel2.Controls.Add(this.txtEntriesAllowed);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnNew);
            this.panel2.Controls.Add(this.txtZoneGroupID);
            this.panel2.Controls.Add(this.txtZoneGroupName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(3, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1147, 147);
            this.panel2.TabIndex = 122;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.Location = new System.Drawing.Point(155, 112);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 30);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Tag = "12";
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(608, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 75;
            this.label6.Text = "Ticket Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(687, 39);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(108, 23);
            this.txtPrice.TabIndex = 9;
            this.txtPrice.Tag = "12";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(379, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 73;
            this.label3.Text = "Days Allowed:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(379, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 15);
            this.label5.TabIndex = 71;
            this.label5.Text = "Entries Allowed:";
            // 
            // txtDaysAllowed
            // 
            this.txtDaysAllowed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDaysAllowed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDaysAllowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDaysAllowed.Location = new System.Drawing.Point(479, 39);
            this.txtDaysAllowed.Name = "txtDaysAllowed";
            this.txtDaysAllowed.ReadOnly = true;
            this.txtDaysAllowed.Size = new System.Drawing.Size(109, 23);
            this.txtDaysAllowed.TabIndex = 5;
            this.txtDaysAllowed.Tag = "12";
            // 
            // txtEntriesAllowed
            // 
            this.txtEntriesAllowed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEntriesAllowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntriesAllowed.Location = new System.Drawing.Point(479, 68);
            this.txtEntriesAllowed.Name = "txtEntriesAllowed";
            this.txtEntriesAllowed.ReadOnly = true;
            this.txtEntriesAllowed.Size = new System.Drawing.Size(109, 23);
            this.txtEntriesAllowed.TabIndex = 7;
            this.txtEntriesAllowed.Tag = "12";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDelete.Location = new System.Drawing.Point(297, 112);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(65, 30);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Tag = "2";
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdate.Location = new System.Drawing.Point(84, 112);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(65, 30);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Tag = "2";
            this.btnUpdate.Text = "&Edit";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(11, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 65;
            this.label1.Text = "Zone Group ID:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.Location = new System.Drawing.Point(226, 112);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 30);
            this.btnSave.TabIndex = 17;
            this.btnSave.Tag = "12";
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(11, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 63;
            this.label2.Text = "Zone Group Name:";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNew.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNew.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnNew.Location = new System.Drawing.Point(13, 112);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(65, 30);
            this.btnNew.TabIndex = 11;
            this.btnNew.Tag = "3";
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtZoneGroupID
            // 
            this.txtZoneGroupID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtZoneGroupID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtZoneGroupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZoneGroupID.Location = new System.Drawing.Point(129, 39);
            this.txtZoneGroupID.MaxLength = 3;
            this.txtZoneGroupID.Name = "txtZoneGroupID";
            this.txtZoneGroupID.ReadOnly = true;
            this.txtZoneGroupID.Size = new System.Drawing.Size(233, 23);
            this.txtZoneGroupID.TabIndex = 1;
            this.txtZoneGroupID.Tag = "4";
            // 
            // txtZoneGroupName
            // 
            this.txtZoneGroupName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtZoneGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZoneGroupName.Location = new System.Drawing.Point(129, 68);
            this.txtZoneGroupName.Name = "txtZoneGroupName";
            this.txtZoneGroupName.ReadOnly = true;
            this.txtZoneGroupName.Size = new System.Drawing.Size(233, 23);
            this.txtZoneGroupName.TabIndex = 3;
            this.txtZoneGroupName.Tag = "12";
            this.txtZoneGroupName.TextChanged += new System.EventHandler(this.txtZoneGroupName_TextChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.SteelBlue;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1145, 25);
            this.label4.TabIndex = 62;
            this.label4.Text = "Zone Entry - Edit";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1161, 30);
            this.toolStrip1.TabIndex = 120;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.toolStripLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(154, 27);
            this.toolStripLabel1.Text = "   Zone Management   |";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.toolStripLabel2.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(72, 27);
            this.toolStripLabel2.Text = "Zone Group";
            // 
            // ZoneGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1163, 495);
            this.Controls.Add(this.panel1);
            this.Name = "ZoneGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zone Group";
            this.Load += new System.EventHandler(this.ZoneGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZoneGroup)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZoneGroup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtZoneGroupID;
        private System.Windows.Forms.TextBox txtZoneGroupName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDaysAllowed;
        private System.Windows.Forms.TextBox txtEntriesAllowed;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcZoneGroupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcZoneGroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDaysAllowed;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcEntriesAllowed;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPrice;
    }
}