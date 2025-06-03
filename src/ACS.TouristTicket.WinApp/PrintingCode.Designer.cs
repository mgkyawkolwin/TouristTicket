namespace ACS.TouristTicket.WinApp
{
    partial class PrintingCode
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
            this.txtPrintingCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPrintingCode
            // 
            this.txtPrintingCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrintingCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrintingCode.Location = new System.Drawing.Point(30, 73);
            this.txtPrintingCode.Name = "txtPrintingCode";
            this.txtPrintingCode.Size = new System.Drawing.Size(246, 23);
            this.txtPrintingCode.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(27, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 15);
            this.label1.TabIndex = 50;
            this.label1.Text = "Defined Printing Approved Code:";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(187, 102);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(89, 36);
            this.btnOk.TabIndex = 51;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // PrintingCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(300, 155);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtPrintingCode);
            this.Controls.Add(this.label1);
            this.Name = "PrintingCode";
            this.Text = "PrintingCode";
            this.Load += new System.EventHandler(this.PrintingCode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrintingCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
    }
}