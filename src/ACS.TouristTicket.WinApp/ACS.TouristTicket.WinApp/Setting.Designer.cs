namespace ACS.TouristTicket.WinApp
{
    partial class Setting
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.cbcSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tbcSettingGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcSettingName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcSettingValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcSettingDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mspClose = new System.Windows.Forms.MenuStrip();
            this.tsmiClose = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.mspClose.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(718, 323);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 23);
            this.button3.TabIndex = 41;
            this.button3.Text = "Delete Selected Roles";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(254, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 23);
            this.button2.TabIndex = 40;
            this.button2.Text = "Update Role";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(155, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(322, 20);
            this.textBox2.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Setting Group :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Setting Name :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "Add New Role";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cbcSelected,
            this.tbcSettingGroup,
            this.tbcSettingName,
            this.tbcSettingValue,
            this.tbcSettingDescription});
            this.dataGridView1.Location = new System.Drawing.Point(10, 352);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(836, 167);
            this.dataGridView1.TabIndex = 34;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(322, 20);
            this.textBox1.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Setting Value :";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(156, 117);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(322, 20);
            this.textBox4.TabIndex = 45;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Setting Description :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(158, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(228, 21);
            this.comboBox1.TabIndex = 46;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(392, 59);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 23);
            this.button4.TabIndex = 47;
            this.button4.Text = "Add New Group";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // cbcSelected
            // 
            this.cbcSelected.HeaderText = "";
            this.cbcSelected.Name = "cbcSelected";
            // 
            // tbcSettingGroup
            // 
            this.tbcSettingGroup.HeaderText = "Setting Group";
            this.tbcSettingGroup.Name = "tbcSettingGroup";
            // 
            // tbcSettingName
            // 
            this.tbcSettingName.HeaderText = "Setting Name";
            this.tbcSettingName.Name = "tbcSettingName";
            // 
            // tbcSettingValue
            // 
            this.tbcSettingValue.HeaderText = "Setting Value";
            this.tbcSettingValue.Name = "tbcSettingValue";
            // 
            // tbcSettingDescription
            // 
            this.tbcSettingDescription.HeaderText = "Setting Description";
            this.tbcSettingDescription.Name = "tbcSettingDescription";
            // 
            // mspClose
            // 
            this.mspClose.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiClose});
            this.mspClose.Location = new System.Drawing.Point(0, 0);
            this.mspClose.Name = "mspClose";
            this.mspClose.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mspClose.Size = new System.Drawing.Size(1042, 26);
            this.mspClose.TabIndex = 50;
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
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 607);
            this.Controls.Add(this.mspClose);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Setting";
            this.Text = "Setting";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.mspClose.ResumeLayout(false);
            this.mspClose.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cbcSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcSettingGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcSettingName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcSettingValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcSettingDescription;
        private System.Windows.Forms.MenuStrip mspClose;
        private System.Windows.Forms.ToolStripMenuItem tsmiClose;
    }
}