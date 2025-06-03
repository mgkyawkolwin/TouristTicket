namespace ACS.TouristTicket.WinApp
{
    partial class Counter
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.cboZone = new System.Windows.Forms.ComboBox();
            this.cboZoneGroup = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtCounterID = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCounter = new System.Windows.Forms.DataGridView();
            this.colPKID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCounterID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colZoneName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colZoneGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCounter)).BeginInit();
            this.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(1025, 30);
            this.toolStrip1.TabIndex = 121;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.toolStripLabel1.ForeColor = System.Drawing.Color.Black;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(154, 27);
            this.toolStripLabel1.Text = "   Zone Management   |";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.toolStripLabel2.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(50, 27);
            this.toolStripLabel2.Text = "Counter";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnGenerate);
            this.panel2.Controls.Add(this.cboZone);
            this.panel2.Controls.Add(this.cboZoneGroup);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnNew);
            this.panel2.Controls.Add(this.txtCounterID);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(12, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(389, 279);
            this.panel2.TabIndex = 122;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Enabled = false;
            this.btnGenerate.Location = new System.Drawing.Point(102, 204);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(126, 30);
            this.btnGenerate.TabIndex = 72;
            this.btnGenerate.Text = "Generate Counter";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // cboZone
            // 
            this.cboZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboZone.Enabled = false;
            this.cboZone.FormattingEnabled = true;
            this.cboZone.Location = new System.Drawing.Point(32, 127);
            this.cboZone.Name = "cboZone";
            this.cboZone.Size = new System.Drawing.Size(339, 23);
            this.cboZone.TabIndex = 71;
            this.cboZone.SelectedIndexChanged += new System.EventHandler(this.cboZone_SelectedIndexChanged);
            // 
            // cboZoneGroup
            // 
            this.cboZoneGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboZoneGroup.Enabled = false;
            this.cboZoneGroup.FormattingEnabled = true;
            this.cboZoneGroup.Location = new System.Drawing.Point(32, 69);
            this.cboZoneGroup.Name = "cboZoneGroup";
            this.cboZoneGroup.Size = new System.Drawing.Size(339, 23);
            this.cboZoneGroup.TabIndex = 69;
            this.cboZoneGroup.SelectedIndexChanged += new System.EventHandler(this.cboZoneGroup_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(306, 204);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 30);
            this.btnCancel.TabIndex = 67;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(30, 204);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(65, 30);
            this.btnNew.TabIndex = 66;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtCounterID
            // 
            this.txtCounterID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCounterID.Enabled = false;
            this.txtCounterID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCounterID.Location = new System.Drawing.Point(32, 176);
            this.txtCounterID.Name = "txtCounterID";
            this.txtCounterID.Size = new System.Drawing.Size(338, 23);
            this.txtCounterID.TabIndex = 65;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(234, 204);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 30);
            this.btnSave.TabIndex = 61;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 64;
            this.label3.Text = "CounterID:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Tan;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(387, 25);
            this.label2.TabIndex = 62;
            this.label2.Text = "Counter Entry - Edit";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 62;
            this.label4.Text = "Zone Group:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 62;
            this.label1.Text = "Zone Name:";
            // 
            // dgvCounter
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.AntiqueWhite;
            this.dgvCounter.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCounter.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCounter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCounter.ColumnHeadersHeight = 25;
            this.dgvCounter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPKID,
            this.colCounterID,
            this.colZoneName,
            this.colZoneGroup});
            this.dgvCounter.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCounter.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCounter.EnableHeadersVisualStyles = false;
            this.dgvCounter.Location = new System.Drawing.Point(407, 36);
            this.dgvCounter.MultiSelect = false;
            this.dgvCounter.Name = "dgvCounter";
            this.dgvCounter.ReadOnly = true;
            this.dgvCounter.RowTemplate.Height = 25;
            this.dgvCounter.Size = new System.Drawing.Size(618, 545);
            this.dgvCounter.TabIndex = 123;
            this.dgvCounter.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCounter_CellClick);
            // 
            // colPKID
            // 
            this.colPKID.DataPropertyName = "PKID";
            this.colPKID.HeaderText = "PKID";
            this.colPKID.Name = "colPKID";
            this.colPKID.ReadOnly = true;
            this.colPKID.Visible = false;
            // 
            // colCounterID
            // 
            this.colCounterID.DataPropertyName = "CounterID";
            this.colCounterID.HeaderText = "CounterID";
            this.colCounterID.Name = "colCounterID";
            this.colCounterID.ReadOnly = true;
            this.colCounterID.Width = 80;
            // 
            // colZoneName
            // 
            this.colZoneName.DataPropertyName = "ZoneName";
            this.colZoneName.HeaderText = "Zone Name";
            this.colZoneName.Name = "colZoneName";
            this.colZoneName.ReadOnly = true;
            this.colZoneName.Width = 200;
            // 
            // colZoneGroup
            // 
            this.colZoneGroup.DataPropertyName = "ZoneGroupName";
            this.colZoneGroup.HeaderText = "Zone Group";
            this.colZoneGroup.Name = "colZoneGroup";
            this.colZoneGroup.ReadOnly = true;
            this.colZoneGroup.Width = 150;
            // 
            // Counter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1025, 581);
            this.Controls.Add(this.dgvCounter);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Counter";
            this.Text = "Counter";
            this.Load += new System.EventHandler(this.Counter_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCounter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cboZone;
        private System.Windows.Forms.ComboBox cboZoneGroup;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtCounterID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DataGridView dgvCounter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPKID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCounterID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colZoneName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colZoneGroup;
    }
}