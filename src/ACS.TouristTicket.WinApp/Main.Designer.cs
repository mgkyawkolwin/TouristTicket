namespace ACS.TouristTicket.WinApp
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Single Entry", 1, 6);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Batch Entry", 1, 6);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Unused Ticket");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Ticket Report", 1, 6);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Printing Approved Code");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Ticket Management", 1, 6, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Zone");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Zone Group");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Counter");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Zone Report");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Zone Management", 0, 6, new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("User", 2, 6);
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("My Account");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("User Report", 2, -2);
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("User Management", 2, 6, new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Export Data", 4, 6);
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Import Data", 5, 6);
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Reporting", 3, 6);
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Data Management", 3, 6, new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17,
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Ticket Security Management", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode11,
            treeNode15,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("About Ticket Admin");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Help");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleTicketEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.multipleTicketEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoneManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createZoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.createZoneGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.ticketLimitationInZoneGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.importDataFromWebServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlNavigators = new System.Windows.Forms.Panel();
            this.tvManu = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlUserInfo = new System.Windows.Forms.Panel();
            this.tsUserInfo = new System.Windows.Forms.ToolStrip();
            this.tslLoggedInTime = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tslUserID = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslConnectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslLastDownloadedDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslLastUploadedDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.pnlNavigators.SuspendLayout();
            this.pnlUserInfo.SuspendLayout();
            this.tsUserInfo.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Lavender;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.entryToolStripMenuItem,
            this.zoneManagementToolStripMenuItem,
            this.userManagementToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(908, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInToolStripMenuItem,
            this.toolStripMenuItem5,
            this.logOutToolStripMenuItem,
            this.toolStripMenuItem6,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.fileToolStripMenuItem.Text = "System";
            // 
            // logInToolStripMenuItem
            // 
            this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            this.logInToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.logInToolStripMenuItem.Text = "Log In";
            this.logInToolStripMenuItem.Click += new System.EventHandler(this.logInToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(114, 6);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Enabled = false;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(114, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // entryToolStripMenuItem
            // 
            this.entryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singleTicketEntryToolStripMenuItem,
            this.toolStripMenuItem1,
            this.multipleTicketEntryToolStripMenuItem});
            this.entryToolStripMenuItem.Enabled = false;
            this.entryToolStripMenuItem.Name = "entryToolStripMenuItem";
            this.entryToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.entryToolStripMenuItem.Text = "Ticket Management";
            // 
            // singleTicketEntryToolStripMenuItem
            // 
            this.singleTicketEntryToolStripMenuItem.Name = "singleTicketEntryToolStripMenuItem";
            this.singleTicketEntryToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.singleTicketEntryToolStripMenuItem.Text = "Single Ticket Entry";
            this.singleTicketEntryToolStripMenuItem.Click += new System.EventHandler(this.singleTicketEntryToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 6);
            // 
            // multipleTicketEntryToolStripMenuItem
            // 
            this.multipleTicketEntryToolStripMenuItem.Name = "multipleTicketEntryToolStripMenuItem";
            this.multipleTicketEntryToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.multipleTicketEntryToolStripMenuItem.Text = "Multiple Ticket Entry";
            this.multipleTicketEntryToolStripMenuItem.Click += new System.EventHandler(this.multipleTicketEntryToolStripMenuItem_Click);
            // 
            // zoneManagementToolStripMenuItem
            // 
            this.zoneManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createZoneToolStripMenuItem,
            this.toolStripMenuItem3,
            this.createZoneGroupToolStripMenuItem,
            this.toolStripMenuItem4,
            this.ticketLimitationInZoneGroupToolStripMenuItem});
            this.zoneManagementToolStripMenuItem.Enabled = false;
            this.zoneManagementToolStripMenuItem.Name = "zoneManagementToolStripMenuItem";
            this.zoneManagementToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.zoneManagementToolStripMenuItem.Text = "Zone Management";
            // 
            // createZoneToolStripMenuItem
            // 
            this.createZoneToolStripMenuItem.Name = "createZoneToolStripMenuItem";
            this.createZoneToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.createZoneToolStripMenuItem.Text = "Create Zone";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(239, 6);
            // 
            // createZoneGroupToolStripMenuItem
            // 
            this.createZoneGroupToolStripMenuItem.Name = "createZoneGroupToolStripMenuItem";
            this.createZoneGroupToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.createZoneGroupToolStripMenuItem.Text = "Create Zone Group";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(239, 6);
            // 
            // ticketLimitationInZoneGroupToolStripMenuItem
            // 
            this.ticketLimitationInZoneGroupToolStripMenuItem.Name = "ticketLimitationInZoneGroupToolStripMenuItem";
            this.ticketLimitationInZoneGroupToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.ticketLimitationInZoneGroupToolStripMenuItem.Text = "Ticket Limitation in Zone Group";
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createUserToolStripMenuItem});
            this.userManagementToolStripMenuItem.Enabled = false;
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.userManagementToolStripMenuItem.Text = "User Management";
            // 
            // createUserToolStripMenuItem
            // 
            this.createUserToolStripMenuItem.Name = "createUserToolStripMenuItem";
            this.createUserToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.createUserToolStripMenuItem.Text = "User Management";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportDataToolStripMenuItem,
            this.toolStripMenuItem2,
            this.importDataFromWebServerToolStripMenuItem});
            this.settingsToolStripMenuItem.Enabled = false;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.settingsToolStripMenuItem.Text = "Synchronization";
            // 
            // exportDataToolStripMenuItem
            // 
            this.exportDataToolStripMenuItem.Name = "exportDataToolStripMenuItem";
            this.exportDataToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.exportDataToolStripMenuItem.Text = "Export Data from Web Server";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(225, 6);
            // 
            // importDataFromWebServerToolStripMenuItem
            // 
            this.importDataFromWebServerToolStripMenuItem.Name = "importDataFromWebServerToolStripMenuItem";
            this.importDataFromWebServerToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.importDataFromWebServerToolStripMenuItem.Text = "Import Data from Web Server";
            // 
            // pnlNavigators
            // 
            this.pnlNavigators.BackColor = System.Drawing.Color.White;
            this.pnlNavigators.Controls.Add(this.tvManu);
            this.pnlNavigators.Controls.Add(this.label1);
            this.pnlNavigators.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavigators.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlNavigators.Location = new System.Drawing.Point(0, 24);
            this.pnlNavigators.Name = "pnlNavigators";
            this.pnlNavigators.Size = new System.Drawing.Size(249, 578);
            this.pnlNavigators.TabIndex = 3;
            // 
            // tvManu
            // 
            this.tvManu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tvManu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvManu.ForeColor = System.Drawing.Color.Black;
            this.tvManu.HotTracking = true;
            this.tvManu.ImageIndex = 0;
            this.tvManu.ImageList = this.imageList1;
            this.tvManu.ItemHeight = 25;
            this.tvManu.LineColor = System.Drawing.Color.SteelBlue;
            this.tvManu.Location = new System.Drawing.Point(0, 30);
            this.tvManu.Margin = new System.Windows.Forms.Padding(5);
            this.tvManu.Name = "tvManu";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "Node9";
            treeNode1.SelectedImageIndex = 6;
            treeNode1.Text = "Single Entry";
            treeNode2.ImageIndex = 1;
            treeNode2.Name = "Node10";
            treeNode2.SelectedImageIndex = 6;
            treeNode2.Text = "Batch Entry";
            treeNode3.ImageIndex = -2;
            treeNode3.Name = "Node0";
            treeNode3.Text = "Unused Ticket";
            treeNode4.ImageIndex = 1;
            treeNode4.Name = "Node10";
            treeNode4.SelectedImageIndex = 6;
            treeNode4.Text = "Ticket Report";
            treeNode5.Name = "Node0";
            treeNode5.Text = "Printing Approved Code";
            treeNode6.ImageIndex = 1;
            treeNode6.Name = "Node1";
            treeNode6.SelectedImageIndex = 6;
            treeNode6.Text = "Ticket Management";
            treeNode7.Name = "Node0";
            treeNode7.SelectedImageIndex = 6;
            treeNode7.Text = "Zone";
            treeNode8.Name = "Node1";
            treeNode8.SelectedImageIndex = 6;
            treeNode8.Text = "Zone Group";
            treeNode9.Name = "Node0";
            treeNode9.Text = "Counter";
            treeNode10.Name = "Node12";
            treeNode10.SelectedImageIndex = 6;
            treeNode10.Text = "Zone Report";
            treeNode11.ImageIndex = 0;
            treeNode11.Name = "Node2";
            treeNode11.SelectedImageIndex = 6;
            treeNode11.Text = "Zone Management";
            treeNode12.ImageIndex = 2;
            treeNode12.Name = "Node2";
            treeNode12.SelectedImageIndex = 6;
            treeNode12.Text = "User";
            treeNode13.ImageKey = "(default)";
            treeNode13.Name = "Node0";
            treeNode13.SelectedImageIndex = -2;
            treeNode13.Text = "My Account";
            treeNode14.ImageIndex = 2;
            treeNode14.Name = "Node13";
            treeNode14.SelectedImageIndex = -2;
            treeNode14.Text = "User Report";
            treeNode15.ImageIndex = 2;
            treeNode15.Name = "Node3";
            treeNode15.SelectedImageIndex = 6;
            treeNode15.Text = "User Management";
            treeNode16.ImageIndex = 4;
            treeNode16.Name = "Node3";
            treeNode16.SelectedImageIndex = 6;
            treeNode16.Text = "Export Data";
            treeNode17.ImageIndex = 5;
            treeNode17.Name = "Node4";
            treeNode17.SelectedImageIndex = 6;
            treeNode17.Text = "Import Data";
            treeNode18.ImageIndex = 3;
            treeNode18.Name = "Node11";
            treeNode18.SelectedImageIndex = 6;
            treeNode18.Text = "Reporting";
            treeNode19.ImageIndex = 3;
            treeNode19.Name = "Node8";
            treeNode19.SelectedImageIndex = 6;
            treeNode19.Text = "Data Management";
            treeNode20.ForeColor = System.Drawing.Color.Black;
            treeNode20.Name = "Node0";
            treeNode20.Text = "Ticket Security Management";
            treeNode21.Name = "Node4";
            treeNode21.SelectedImageIndex = 6;
            treeNode21.Text = "About Ticket Admin";
            treeNode22.Name = "Node8";
            treeNode22.Text = "Help";
            this.tvManu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode21,
            treeNode22});
            this.tvManu.SelectedImageIndex = 0;
            this.tvManu.Size = new System.Drawing.Size(249, 548);
            this.tvManu.TabIndex = 0;
            this.tvManu.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvManu_BeforeCollapse);
            this.tvManu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvManu_AfterSelect);
            this.tvManu.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvManu_NodeMouseClick);
            this.tvManu.Click += new System.EventHandler(this.tvManu_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Navigation";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(249, 24);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 578);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // pnlUserInfo
            // 
            this.pnlUserInfo.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlUserInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUserInfo.Controls.Add(this.tsUserInfo);
            this.pnlUserInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUserInfo.Location = new System.Drawing.Point(252, 24);
            this.pnlUserInfo.Name = "pnlUserInfo";
            this.pnlUserInfo.Size = new System.Drawing.Size(656, 30);
            this.pnlUserInfo.TabIndex = 7;
            // 
            // tsUserInfo
            // 
            this.tsUserInfo.AutoSize = false;
            this.tsUserInfo.BackColor = System.Drawing.Color.Transparent;
            this.tsUserInfo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsUserInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslLoggedInTime,
            this.toolStripLabel2,
            this.toolStripLabel3,
            this.tslUserID,
            this.toolStripLabel1});
            this.tsUserInfo.Location = new System.Drawing.Point(0, 0);
            this.tsUserInfo.Name = "tsUserInfo";
            this.tsUserInfo.Size = new System.Drawing.Size(654, 30);
            this.tsUserInfo.TabIndex = 0;
            this.tsUserInfo.Text = "toolStrip1";
            this.tsUserInfo.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tslLoggedInTime
            // 
            this.tslLoggedInTime.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslLoggedInTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tslLoggedInTime.ForeColor = System.Drawing.Color.Tan;
            this.tslLoggedInTime.Name = "tslLoggedInTime";
            this.tslLoggedInTime.Size = new System.Drawing.Size(99, 27);
            this.tslLoggedInTime.Text = "[Logged In Time]";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.toolStripLabel2.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(99, 27);
            this.toolStripLabel2.Text = "Logged In Time :";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(10, 27);
            this.toolStripLabel3.Text = "|";
            // 
            // tslUserID
            // 
            this.tslUserID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tslUserID.ForeColor = System.Drawing.Color.Tan;
            this.tslUserID.Name = "tslUserID";
            this.tslUserID.Size = new System.Drawing.Size(54, 27);
            this.tslUserID.Text = "[User ID]";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.toolStripLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(39, 27);
            this.toolStripLabel1.Text = "User :";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tslConnectionStatus,
            this.toolStripStatusLabel3,
            this.tslLastDownloadedDate,
            this.toolStripStatusLabel5,
            this.tslLastUploadedDate,
            this.tslStatus});
            this.statusStrip1.Location = new System.Drawing.Point(252, 580);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(656, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(107, 17);
            this.toolStripStatusLabel1.Text = "Connection Status:";
            // 
            // tslConnectionStatus
            // 
            this.tslConnectionStatus.Name = "tslConnectionStatus";
            this.tslConnectionStatus.Size = new System.Drawing.Size(12, 17);
            this.tslConnectionStatus.Text = "-";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(128, 17);
            this.toolStripStatusLabel3.Text = "Last Downloaded Date:";
            // 
            // tslLastDownloadedDate
            // 
            this.tslLastDownloadedDate.Name = "tslLastDownloadedDate";
            this.tslLastDownloadedDate.Size = new System.Drawing.Size(12, 17);
            this.tslLastDownloadedDate.Text = "-";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(112, 17);
            this.toolStripStatusLabel5.Text = "Last Uploaded Date:";
            // 
            // tslLastUploadedDate
            // 
            this.tslLastUploadedDate.Name = "tslLastUploadedDate";
            this.tslLastUploadedDate.Size = new System.Drawing.Size(12, 17);
            this.tslLastUploadedDate.Text = "-";
            // 
            // tslStatus
            // 
            this.tslStatus.Name = "tslStatus";
            this.tslStatus.Size = new System.Drawing.Size(12, 17);
            this.tslStatus.Text = "-";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 602);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlUserInfo);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnlNavigators);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Gate Pass Security System - Ticket Admin";
            this.Activated += new System.EventHandler(this.Main_Activated);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlNavigators.ResumeLayout(false);
            this.pnlUserInfo.ResumeLayout(false);
            this.tsUserInfo.ResumeLayout(false);
            this.tsUserInfo.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singleTicketEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem multipleTicketEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoneManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem importDataFromWebServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createZoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem createZoneGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem ticketLimitationInZoneGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createUserToolStripMenuItem;
        private System.Windows.Forms.Panel pnlNavigators;
        private System.Windows.Forms.TreeView tvManu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel pnlUserInfo;
        private System.Windows.Forms.ToolStrip tsUserInfo;
        private System.Windows.Forms.ToolStripLabel tslLoggedInTime;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel tslUserID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tslConnectionStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tslLastDownloadedDate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel tslLastUploadedDate;
        private System.Windows.Forms.ToolStripStatusLabel tslStatus;

    }
}