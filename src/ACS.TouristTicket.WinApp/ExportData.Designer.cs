namespace ACS.TouristTicket.WinApp
{
    partial class ExportData
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnBrowserImportFolder = new System.Windows.Forms.Button();
            this.cboCounter = new System.Windows.Forms.ComboBox();
            this.txtExportFileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboZoneGroup = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboZone = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.ofdFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 15);
            this.label1.TabIndex = 125;
            this.label1.Text = "Choose File to Export :";
            // 
            // btnExport
            // 
            this.btnExport.Enabled = false;
            this.btnExport.Location = new System.Drawing.Point(588, 162);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(74, 23);
            this.btnExport.TabIndex = 124;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnBrowserImportFolder
            // 
            this.btnBrowserImportFolder.Location = new System.Drawing.Point(510, 162);
            this.btnBrowserImportFolder.Name = "btnBrowserImportFolder";
            this.btnBrowserImportFolder.Size = new System.Drawing.Size(75, 23);
            this.btnBrowserImportFolder.TabIndex = 123;
            this.btnBrowserImportFolder.Text = "Browse";
            this.btnBrowserImportFolder.UseVisualStyleBackColor = true;
            this.btnBrowserImportFolder.Click += new System.EventHandler(this.btnBrowserImportFolder_Click);
            // 
            // cboCounter
            // 
            this.cboCounter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCounter.FormattingEnabled = true;
            this.cboCounter.Items.AddRange(new object[] {
            "200100101",
            "200401102",
            "300209103"});
            this.cboCounter.Location = new System.Drawing.Point(156, 126);
            this.cboCounter.Name = "cboCounter";
            this.cboCounter.Size = new System.Drawing.Size(150, 21);
            this.cboCounter.TabIndex = 126;
            // 
            // txtExportFileName
            // 
            this.txtExportFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExportFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExportFileName.Location = new System.Drawing.Point(156, 162);
            this.txtExportFileName.Name = "txtExportFileName";
            this.txtExportFileName.Size = new System.Drawing.Size(348, 21);
            this.txtExportFileName.TabIndex = 127;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 125;
            this.label2.Text = "Select Zone Group:";
            // 
            // cboZoneGroup
            // 
            this.cboZoneGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboZoneGroup.FormattingEnabled = true;
            this.cboZoneGroup.Location = new System.Drawing.Point(156, 54);
            this.cboZoneGroup.Name = "cboZoneGroup";
            this.cboZoneGroup.Size = new System.Drawing.Size(150, 21);
            this.cboZoneGroup.TabIndex = 126;
            this.cboZoneGroup.SelectedIndexChanged += new System.EventHandler(this.cboZoneGroup_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 125;
            this.label3.Text = "Select Zone:";
            // 
            // cboZone
            // 
            this.cboZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboZone.FormattingEnabled = true;
            this.cboZone.Location = new System.Drawing.Point(156, 90);
            this.cboZone.Name = "cboZone";
            this.cboZone.Size = new System.Drawing.Size(150, 21);
            this.cboZone.TabIndex = 126;
            this.cboZone.SelectedIndexChanged += new System.EventHandler(this.cboZone_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 125;
            this.label4.Text = "Select Counter:";
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
            this.toolStrip1.Size = new System.Drawing.Size(836, 30);
            this.toolStrip1.TabIndex = 128;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.toolStripLabel1.ForeColor = System.Drawing.Color.Black;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(151, 27);
            this.toolStripLabel1.Text = "   Data Management   |";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.toolStripLabel2.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(71, 27);
            this.toolStripLabel2.Text = "Export Data";
            // 
            // ofdFileDialog
            // 
            this.ofdFileDialog.CheckFileExists = false;
            this.ofdFileDialog.FileName = "CounterData.std";
            this.ofdFileDialog.Filter = "Ticket File|*.std";
            this.ofdFileDialog.Title = "Save";
            // 
            // ExportData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(836, 500);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtExportFileName);
            this.Controls.Add(this.cboZone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboZoneGroup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboCounter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnBrowserImportFolder);
            this.Name = "ExportData";
            this.Text = "Export Data";
            this.Load += new System.EventHandler(this.ExportData_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnBrowserImportFolder;
        private System.Windows.Forms.ComboBox cboCounter;
        private System.Windows.Forms.TextBox txtExportFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboZoneGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboZone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.OpenFileDialog ofdFileDialog;
    }
}