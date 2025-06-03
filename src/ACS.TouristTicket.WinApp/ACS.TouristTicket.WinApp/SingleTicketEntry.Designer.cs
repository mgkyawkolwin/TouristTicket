namespace ACS.TouristTicket.WinApp
{
    partial class SingleTicketEntry
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
            this.mspClose = new System.Windows.Forms.MenuStrip();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tsmiClose = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pb1D = new System.Windows.Forms.PictureBox();
            this.pb2D2 = new System.Windows.Forms.PictureBox();
            this.pb2D1 = new System.Windows.Forms.PictureBox();
            this.lblSerialNo = new System.Windows.Forms.Label();
            this.cboZoneID = new System.Windows.Forms.ComboBox();
            this.txtEntryAllowed = new System.Windows.Forms.TextBox();
            this.txtExpiryDate = new System.Windows.Forms.TextBox();
            this.txtAllowedDays = new System.Windows.Forms.TextBox();
            this.txtIssued = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtEncryptedTicketID = new System.Windows.Forms.TextBox();
            this.txtTicket2DID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblZoneName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSerialNo = new System.Windows.Forms.TextBox();
            this.btnGenerate2D = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.mspClose.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2D2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2D1)).BeginInit();
            this.SuspendLayout();
            // 
            // mspClose
            // 
            this.mspClose.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiClose});
            this.mspClose.Location = new System.Drawing.Point(0, 0);
            this.mspClose.Name = "mspClose";
            this.mspClose.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mspClose.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mspClose.Size = new System.Drawing.Size(1071, 24);
            this.mspClose.TabIndex = 70;
            this.mspClose.Text = "menuStrip1";
            this.mspClose.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(-138, 30);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 19);
            this.checkBox1.TabIndex = 69;
            this.checkBox1.Text = "Manual Entry";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tsmiClose
            // 
            this.tsmiClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmiClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tsmiClose.Name = "tsmiClose";
            this.tsmiClose.Size = new System.Drawing.Size(50, 20);
            this.tsmiClose.Text = "&Close";
            this.tsmiClose.Click += new System.EventHandler(this.tsmiClose_Click);
            // 
            // pnlBody
            // 
            this.pnlBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBody.Controls.Add(this.label18);
            this.pnlBody.Controls.Add(this.pnlCard);
            this.pnlBody.Controls.Add(this.cboZoneID);
            this.pnlBody.Controls.Add(this.txtEntryAllowed);
            this.pnlBody.Controls.Add(this.txtExpiryDate);
            this.pnlBody.Controls.Add(this.txtAllowedDays);
            this.pnlBody.Controls.Add(this.txtIssued);
            this.pnlBody.Controls.Add(this.txtPrice);
            this.pnlBody.Controls.Add(this.txtEncryptedTicketID);
            this.pnlBody.Controls.Add(this.txtTicket2DID);
            this.pnlBody.Controls.Add(this.label13);
            this.pnlBody.Controls.Add(this.label4);
            this.pnlBody.Controls.Add(this.label11);
            this.pnlBody.Controls.Add(this.label7);
            this.pnlBody.Controls.Add(this.lblZoneName);
            this.pnlBody.Controls.Add(this.label8);
            this.pnlBody.Controls.Add(this.label10);
            this.pnlBody.Controls.Add(this.label5);
            this.pnlBody.Controls.Add(this.label9);
            this.pnlBody.Controls.Add(this.label3);
            this.pnlBody.Controls.Add(this.label2);
            this.pnlBody.Controls.Add(this.label6);
            this.pnlBody.Controls.Add(this.label1);
            this.pnlBody.Controls.Add(this.txtSerialNo);
            this.pnlBody.Controls.Add(this.btnGenerate2D);
            this.pnlBody.Controls.Add(this.btnAdd);
            this.pnlBody.Controls.Add(this.btnNew);
            this.pnlBody.Location = new System.Drawing.Point(12, 12);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1047, 716);
            this.pnlBody.TabIndex = 93;
            // 
            // pnlCard
            // 
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard.Controls.Add(this.label12);
            this.pnlCard.Controls.Add(this.label14);
            this.pnlCard.Controls.Add(this.label15);
            this.pnlCard.Controls.Add(this.label16);
            this.pnlCard.Controls.Add(this.label17);
            this.pnlCard.Controls.Add(this.pb1D);
            this.pnlCard.Controls.Add(this.pb2D2);
            this.pnlCard.Controls.Add(this.pb2D1);
            this.pnlCard.Controls.Add(this.lblSerialNo);
            this.pnlCard.Controls.Add(this.label19);
            this.pnlCard.Location = new System.Drawing.Point(619, 64);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(425, 224);
            this.pnlCard.TabIndex = 116;
            this.pnlCard.Visible = false;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(335, 156);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 57);
            this.label12.TabIndex = 8;
            this.label12.Text = "5";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(255, 156);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 57);
            this.label14.TabIndex = 7;
            this.label14.Text = "4";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(176, 156);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 57);
            this.label15.TabIndex = 6;
            this.label15.Text = "3";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(97, 156);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 57);
            this.label16.TabIndex = 5;
            this.label16.Text = "2";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(17, 156);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 57);
            this.label17.TabIndex = 4;
            this.label17.Text = "1";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb1D
            // 
            this.pb1D.BackColor = System.Drawing.Color.White;
            this.pb1D.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb1D.Location = new System.Drawing.Point(113, 46);
            this.pb1D.Name = "pb1D";
            this.pb1D.Size = new System.Drawing.Size(195, 46);
            this.pb1D.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb1D.TabIndex = 3;
            this.pb1D.TabStop = false;
            // 
            // pb2D2
            // 
            this.pb2D2.BackColor = System.Drawing.Color.White;
            this.pb2D2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb2D2.Location = new System.Drawing.Point(313, 36);
            this.pb2D2.Name = "pb2D2";
            this.pb2D2.Size = new System.Drawing.Size(101, 101);
            this.pb2D2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb2D2.TabIndex = 2;
            this.pb2D2.TabStop = false;
            // 
            // pb2D1
            // 
            this.pb2D1.BackColor = System.Drawing.Color.White;
            this.pb2D1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb2D1.Location = new System.Drawing.Point(10, 36);
            this.pb2D1.Margin = new System.Windows.Forms.Padding(0);
            this.pb2D1.Name = "pb2D1";
            this.pb2D1.Size = new System.Drawing.Size(99, 101);
            this.pb2D1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb2D1.TabIndex = 1;
            this.pb2D1.TabStop = false;
            // 
            // lblSerialNo
            // 
            this.lblSerialNo.AutoSize = true;
            this.lblSerialNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerialNo.Location = new System.Drawing.Point(177, 95);
            this.lblSerialNo.Name = "lblSerialNo";
            this.lblSerialNo.Size = new System.Drawing.Size(64, 17);
            this.lblSerialNo.TabIndex = 0;
            this.lblSerialNo.Text = "1234567";
            // 
            // cboZoneID
            // 
            this.cboZoneID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboZoneID.FormattingEnabled = true;
            this.cboZoneID.Items.AddRange(new object[] {
            "[Select Zone ID]",
            "100",
            "101",
            "102",
            "103"});
            this.cboZoneID.Location = new System.Drawing.Point(155, 118);
            this.cboZoneID.Name = "cboZoneID";
            this.cboZoneID.Size = new System.Drawing.Size(172, 23);
            this.cboZoneID.TabIndex = 115;
            this.cboZoneID.SelectedIndexChanged += new System.EventHandler(this.cboZoneID_SelectedIndexChanged);
            // 
            // txtEntryAllowed
            // 
            this.txtEntryAllowed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEntryAllowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntryAllowed.Location = new System.Drawing.Point(157, 251);
            this.txtEntryAllowed.Name = "txtEntryAllowed";
            this.txtEntryAllowed.Size = new System.Drawing.Size(85, 23);
            this.txtEntryAllowed.TabIndex = 114;
            this.txtEntryAllowed.Text = "5";
            // 
            // txtExpiryDate
            // 
            this.txtExpiryDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExpiryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpiryDate.Location = new System.Drawing.Point(157, 315);
            this.txtExpiryDate.Name = "txtExpiryDate";
            this.txtExpiryDate.Size = new System.Drawing.Size(171, 23);
            this.txtExpiryDate.TabIndex = 113;
            // 
            // txtAllowedDays
            // 
            this.txtAllowedDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAllowedDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAllowedDays.Location = new System.Drawing.Point(157, 221);
            this.txtAllowedDays.Name = "txtAllowedDays";
            this.txtAllowedDays.Size = new System.Drawing.Size(85, 23);
            this.txtAllowedDays.TabIndex = 112;
            this.txtAllowedDays.Text = "7";
            // 
            // txtIssued
            // 
            this.txtIssued.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIssued.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIssued.Location = new System.Drawing.Point(157, 285);
            this.txtIssued.Name = "txtIssued";
            this.txtIssued.Size = new System.Drawing.Size(171, 23);
            this.txtIssued.TabIndex = 111;
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(157, 187);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(171, 23);
            this.txtPrice.TabIndex = 110;
            this.txtPrice.Text = "10.00";
            // 
            // txtEncryptedTicketID
            // 
            this.txtEncryptedTicketID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEncryptedTicketID.Enabled = false;
            this.txtEncryptedTicketID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncryptedTicketID.ForeColor = System.Drawing.Color.Gray;
            this.txtEncryptedTicketID.Location = new System.Drawing.Point(157, 381);
            this.txtEncryptedTicketID.Multiline = true;
            this.txtEncryptedTicketID.Name = "txtEncryptedTicketID";
            this.txtEncryptedTicketID.Size = new System.Drawing.Size(493, 99);
            this.txtEncryptedTicketID.TabIndex = 108;
            // 
            // txtTicket2DID
            // 
            this.txtTicket2DID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTicket2DID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicket2DID.Location = new System.Drawing.Point(157, 347);
            this.txtTicket2DID.Name = "txtTicket2DID";
            this.txtTicket2DID.Size = new System.Drawing.Size(375, 23);
            this.txtTicket2DID.TabIndex = 109;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 255);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 15);
            this.label13.TabIndex = 107;
            this.label13.Text = "Entry Allowance Times:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 105;
            this.label4.Text = "Allowed Days:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(69, 319);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 15);
            this.label11.TabIndex = 106;
            this.label11.Text = "Expiry Date :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 15);
            this.label7.TabIndex = 104;
            this.label7.Text = "Issued Date :";
            // 
            // lblZoneName
            // 
            this.lblZoneName.AutoSize = true;
            this.lblZoneName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblZoneName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblZoneName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZoneName.ForeColor = System.Drawing.Color.Black;
            this.lblZoneName.Location = new System.Drawing.Point(157, 146);
            this.lblZoneName.Name = "lblZoneName";
            this.lblZoneName.Size = new System.Drawing.Size(81, 17);
            this.lblZoneName.TabIndex = 101;
            this.lblZoneName.Text = "[Zone Name]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 15);
            this.label8.TabIndex = 102;
            this.label8.Text = "Zone Group ID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(145, 381);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 15);
            this.label10.TabIndex = 99;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 103;
            this.label5.Text = "Ticket Price :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 387);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 15);
            this.label9.TabIndex = 97;
            this.label9.Text = "Encrypted Ticket ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 98;
            this.label2.Text = "Ticket 2D ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(94, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 15);
            this.label6.TabIndex = 95;
            this.label6.Text = "[Click New Button To Get Ticket Serial No]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 96;
            this.label1.Text = "Ticket Serial No:";
            // 
            // txtSerialNo
            // 
            this.txtSerialNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSerialNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerialNo.Location = new System.Drawing.Point(155, 64);
            this.txtSerialNo.Name = "txtSerialNo";
            this.txtSerialNo.Size = new System.Drawing.Size(171, 23);
            this.txtSerialNo.TabIndex = 91;
            // 
            // btnGenerate2D
            // 
            this.btnGenerate2D.Location = new System.Drawing.Point(539, 347);
            this.btnGenerate2D.Name = "btnGenerate2D";
            this.btnGenerate2D.Size = new System.Drawing.Size(111, 27);
            this.btnGenerate2D.TabIndex = 94;
            this.btnGenerate2D.Text = "Generate ID";
            this.btnGenerate2D.UseVisualStyleBackColor = true;
            this.btnGenerate2D.Click += new System.EventHandler(this.btnGenerate2D_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(539, 486);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 27);
            this.btnAdd.TabIndex = 93;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(334, 64);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(120, 27);
            this.btnNew.TabIndex = 92;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.SteelBlue;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Dock = System.Windows.Forms.DockStyle.Top;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(0, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(1045, 46);
            this.label18.TabIndex = 117;
            this.label18.Text = "Single Ticket Entry";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.SteelBlue;
            this.label19.Location = new System.Drawing.Point(166, 7);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(91, 15);
            this.label19.TabIndex = 95;
            this.label19.Text = "[Ticket Sample]";
            // 
            // SingleTicketEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1071, 740);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.mspClose);
            this.Controls.Add(this.checkBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SingleTicketEntry";
            this.Text = "Single Ticket Entry";
            this.Load += new System.EventHandler(this.TicketEntry_Load);
            this.mspClose.ResumeLayout(false);
            this.mspClose.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2D2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2D1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mspClose;
        private System.Windows.Forms.ToolStripMenuItem tsmiClose;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pb1D;
        private System.Windows.Forms.PictureBox pb2D2;
        private System.Windows.Forms.PictureBox pb2D1;
        private System.Windows.Forms.Label lblSerialNo;
        private System.Windows.Forms.ComboBox cboZoneID;
        private System.Windows.Forms.TextBox txtEntryAllowed;
        private System.Windows.Forms.TextBox txtExpiryDate;
        private System.Windows.Forms.TextBox txtAllowedDays;
        private System.Windows.Forms.TextBox txtIssued;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtEncryptedTicketID;
        private System.Windows.Forms.TextBox txtTicket2DID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblZoneName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSerialNo;
        private System.Windows.Forms.Button btnGenerate2D;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label19;
    }
}