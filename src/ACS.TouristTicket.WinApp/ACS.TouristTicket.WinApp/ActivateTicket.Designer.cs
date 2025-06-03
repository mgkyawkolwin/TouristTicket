namespace ACS.TouristTicket.WinApp
{
    partial class ActivateTicket
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnActivate = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.mspClose = new System.Windows.Forms.MenuStrip();
            this.tsmiClose = new System.Windows.Forms.ToolStripMenuItem();
            this.txtEntryCount = new System.Windows.Forms.TextBox();
            this.txtEntryAllowed = new System.Windows.Forms.TextBox();
            this.txtExpiryDate = new System.Windows.Forms.TextBox();
            this.txtActivatedDate = new System.Windows.Forms.TextBox();
            this.txtIssued = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtTicketID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSerialNo = new System.Windows.Forms.TextBox();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAllowedDays = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mspClose.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 10);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 17);
            this.checkBox1.TabIndex = 46;
            this.checkBox1.Text = "Manual Entry";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnActivate
            // 
            this.btnActivate.Enabled = false;
            this.btnActivate.Location = new System.Drawing.Point(299, 53);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(107, 23);
            this.btnActivate.TabIndex = 27;
            this.btnActivate.Text = "Activate Ticket";
            this.btnActivate.UseVisualStyleBackColor = true;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.White;
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblMessage.Location = new System.Drawing.Point(207, 387);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(304, 57);
            this.lblMessage.TabIndex = 38;
            this.lblMessage.Text = "ACTIVATED";
            // 
            // mspClose
            // 
            this.mspClose.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiClose});
            this.mspClose.Location = new System.Drawing.Point(0, 0);
            this.mspClose.Name = "mspClose";
            this.mspClose.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mspClose.Size = new System.Drawing.Size(905, 24);
            this.mspClose.TabIndex = 47;
            this.mspClose.Text = "menuStrip1";
            this.mspClose.Visible = false;
            // 
            // tsmiClose
            // 
            this.tsmiClose.Name = "tsmiClose";
            this.tsmiClose.Size = new System.Drawing.Size(48, 20);
            this.tsmiClose.Text = "&Close";
            this.tsmiClose.Click += new System.EventHandler(this.tsmiClose_Click);
            // 
            // txtEntryCount
            // 
            this.txtEntryCount.Location = new System.Drawing.Point(193, 356);
            this.txtEntryCount.Name = "txtEntryCount";
            this.txtEntryCount.Size = new System.Drawing.Size(322, 20);
            this.txtEntryCount.TabIndex = 64;
            // 
            // txtEntryAllowed
            // 
            this.txtEntryAllowed.Location = new System.Drawing.Point(193, 322);
            this.txtEntryAllowed.Name = "txtEntryAllowed";
            this.txtEntryAllowed.Size = new System.Drawing.Size(322, 20);
            this.txtEntryAllowed.TabIndex = 63;
            // 
            // txtExpiryDate
            // 
            this.txtExpiryDate.Location = new System.Drawing.Point(193, 290);
            this.txtExpiryDate.Name = "txtExpiryDate";
            this.txtExpiryDate.Size = new System.Drawing.Size(322, 20);
            this.txtExpiryDate.TabIndex = 62;
            // 
            // txtActivatedDate
            // 
            this.txtActivatedDate.Location = new System.Drawing.Point(193, 225);
            this.txtActivatedDate.Name = "txtActivatedDate";
            this.txtActivatedDate.Size = new System.Drawing.Size(322, 20);
            this.txtActivatedDate.TabIndex = 61;
            // 
            // txtIssued
            // 
            this.txtIssued.Location = new System.Drawing.Point(193, 193);
            this.txtIssued.Name = "txtIssued";
            this.txtIssued.Size = new System.Drawing.Size(322, 20);
            this.txtIssued.TabIndex = 60;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(193, 159);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(322, 20);
            this.txtPrice.TabIndex = 59;
            // 
            // txtTicketID
            // 
            this.txtTicketID.Location = new System.Drawing.Point(193, 127);
            this.txtTicketID.Name = "txtTicketID";
            this.txtTicketID.Size = new System.Drawing.Size(322, 20);
            this.txtTicketID.TabIndex = 58;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(94, 358);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 13);
            this.label15.TabIndex = 57;
            this.label15.Text = "Total Entries Pass:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(72, 326);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 13);
            this.label13.TabIndex = 56;
            this.label13.Text = "Entry Allowance Times:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(122, 293);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 55;
            this.label11.Text = "Expiry Date :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(105, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 54;
            this.label9.Text = "Activated Date :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(119, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Issued Date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Ticket Price :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Ticket Serial No/ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Ticket Serial No/ID";
            // 
            // txtSerialNo
            // 
            this.txtSerialNo.Location = new System.Drawing.Point(193, 56);
            this.txtSerialNo.Name = "txtSerialNo";
            this.txtSerialNo.Size = new System.Drawing.Size(100, 20);
            this.txtSerialNo.TabIndex = 0;
            this.txtSerialNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSerialNo_KeyDown);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Enabled = false;
            this.btnCheckIn.Location = new System.Drawing.Point(412, 53);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(103, 23);
            this.btnCheckIn.TabIndex = 27;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Allowed Days:";
            // 
            // txtAllowedDays
            // 
            this.txtAllowedDays.Location = new System.Drawing.Point(193, 251);
            this.txtAllowedDays.Name = "txtAllowedDays";
            this.txtAllowedDays.Size = new System.Drawing.Size(322, 20);
            this.txtAllowedDays.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Enter Ticket Serial No. and Press Enter";
            // 
            // ActivateTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 511);
            this.Controls.Add(this.txtEntryCount);
            this.Controls.Add(this.txtEntryAllowed);
            this.Controls.Add(this.txtExpiryDate);
            this.Controls.Add(this.txtAllowedDays);
            this.Controls.Add(this.txtActivatedDate);
            this.Controls.Add(this.txtIssued);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtTicketID);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSerialNo);
            this.Controls.Add(this.mspClose);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.btnActivate);
            this.Name = "ActivateTicket";
            this.Text = "ActivateTicket";
            this.mspClose.ResumeLayout(false);
            this.mspClose.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.MenuStrip mspClose;
        private System.Windows.Forms.ToolStripMenuItem tsmiClose;
        private System.Windows.Forms.TextBox txtEntryCount;
        private System.Windows.Forms.TextBox txtEntryAllowed;
        private System.Windows.Forms.TextBox txtExpiryDate;
        private System.Windows.Forms.TextBox txtActivatedDate;
        private System.Windows.Forms.TextBox txtIssued;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtTicketID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSerialNo;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAllowedDays;
        private System.Windows.Forms.Label label6;
    }
}