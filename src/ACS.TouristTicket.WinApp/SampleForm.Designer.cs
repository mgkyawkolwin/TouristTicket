namespace ACS.TouristTicket.WinApp
{
    partial class SampleForm
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
            this.txtRetrieve = new System.Windows.Forms.Button();
            this.txtSampleData = new System.Windows.Forms.TextBox();
            this.txtInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(655, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtRetrieve
            // 
            this.txtRetrieve.Location = new System.Drawing.Point(19, 9);
            this.txtRetrieve.Name = "txtRetrieve";
            this.txtRetrieve.Size = new System.Drawing.Size(75, 23);
            this.txtRetrieve.TabIndex = 1;
            this.txtRetrieve.Text = "Retrieve";
            this.txtRetrieve.UseVisualStyleBackColor = true;
            this.txtRetrieve.Click += new System.EventHandler(this.txtRetrieve_Click);
            // 
            // txtSampleData
            // 
            this.txtSampleData.Location = new System.Drawing.Point(14, 212);
            this.txtSampleData.Name = "txtSampleData";
            this.txtSampleData.Size = new System.Drawing.Size(100, 20);
            this.txtSampleData.TabIndex = 2;
            // 
            // txtInsert
            // 
            this.txtInsert.Location = new System.Drawing.Point(120, 210);
            this.txtInsert.Name = "txtInsert";
            this.txtInsert.Size = new System.Drawing.Size(75, 23);
            this.txtInsert.TabIndex = 3;
            this.txtInsert.Text = "Insert";
            this.txtInsert.UseVisualStyleBackColor = true;
            this.txtInsert.Click += new System.EventHandler(this.txtInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(111, 9);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // SampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 368);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtInsert);
            this.Controls.Add(this.txtSampleData);
            this.Controls.Add(this.txtRetrieve);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SampleForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SampleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button txtRetrieve;
        private System.Windows.Forms.TextBox txtSampleData;
        private System.Windows.Forms.Button txtInsert;
        private System.Windows.Forms.Button btnUpdate;
    }
}

