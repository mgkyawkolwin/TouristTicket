namespace ACS.TouristTicket.WinApp
{
    partial class Role
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.mspClose = new System.Windows.Forms.MenuStrip();
            this.tsmiClose = new System.Windows.Forms.ToolStripMenuItem();
            this.cbcSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tbcRoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcRoleDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcCreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcUpdatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcUpdatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.mspClose.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cbcSelected,
            this.tbcRoleName,
            this.tbcRoleDescription,
            this.tbcCreatedDate,
            this.tbcCreatedBy,
            this.tbcUpdatedDate,
            this.tbcUpdatedBy});
            this.dataGridView1.Location = new System.Drawing.Point(12, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(836, 167);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(157, 105);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(322, 20);
            this.textBox3.TabIndex = 31;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(157, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(322, 20);
            this.textBox2.TabIndex = 30;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Role Description :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Role Name :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Add New Role";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(265, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 23);
            this.button2.TabIndex = 32;
            this.button2.Text = "Update Role";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(720, 198);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 23);
            this.button3.TabIndex = 33;
            this.button3.Text = "Delete Selected Roles";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // mspClose
            // 
            this.mspClose.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiClose});
            this.mspClose.Location = new System.Drawing.Point(0, 0);
            this.mspClose.Name = "mspClose";
            this.mspClose.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mspClose.Size = new System.Drawing.Size(860, 26);
            this.mspClose.TabIndex = 48;
            this.mspClose.Text = "menuStrip1";
            this.mspClose.Visible = false;
            // 
            // tsmiClose
            // 
            this.tsmiClose.Name = "tsmiClose";
            this.tsmiClose.Size = new System.Drawing.Size(46, 22);
            this.tsmiClose.Text = "&Close";
            this.tsmiClose.Click += new System.EventHandler(this.tsmiClose_Click);
            // 
            // cbcSelected
            // 
            this.cbcSelected.HeaderText = "";
            this.cbcSelected.Name = "cbcSelected";
            // 
            // tbcRoleName
            // 
            this.tbcRoleName.HeaderText = "Role Name";
            this.tbcRoleName.Name = "tbcRoleName";
            // 
            // tbcRoleDescription
            // 
            this.tbcRoleDescription.HeaderText = "Role Description";
            this.tbcRoleDescription.Name = "tbcRoleDescription";
            // 
            // tbcCreatedDate
            // 
            this.tbcCreatedDate.HeaderText = "Created Date";
            this.tbcCreatedDate.Name = "tbcCreatedDate";
            // 
            // tbcCreatedBy
            // 
            this.tbcCreatedBy.HeaderText = "Created By";
            this.tbcCreatedBy.Name = "tbcCreatedBy";
            // 
            // tbcUpdatedDate
            // 
            this.tbcUpdatedDate.HeaderText = "UpdatedDate";
            this.tbcUpdatedDate.Name = "tbcUpdatedDate";
            // 
            // tbcUpdatedBy
            // 
            this.tbcUpdatedBy.HeaderText = "Updated By";
            this.tbcUpdatedBy.Name = "tbcUpdatedBy";
            // 
            // Role
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 406);
            this.Controls.Add(this.mspClose);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Role";
            this.Text = "Role";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.mspClose.ResumeLayout(false);
            this.mspClose.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip mspClose;
        private System.Windows.Forms.ToolStripMenuItem tsmiClose;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cbcSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcRoleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcRoleDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcCreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcCreatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcUpdatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcUpdatedBy;
    }
}