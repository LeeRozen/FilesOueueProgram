namespace Files_Queue_Program
{
    partial class Form2
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblPrintedDetails = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTitle.Location = new System.Drawing.Point(36, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(724, 30);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "File Managment System";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle2
            // 
            this.lblTitle2.BackColor = System.Drawing.Color.White;
            this.lblTitle2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTitle2.Location = new System.Drawing.Point(36, 68);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(724, 25);
            this.lblTitle2.TabIndex = 7;
            this.lblTitle2.Text = "All Files Details";
            this.lblTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrintedDetails
            // 
            this.lblPrintedDetails.BackColor = System.Drawing.Color.Beige;
            this.lblPrintedDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrintedDetails.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrintedDetails.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblPrintedDetails.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblPrintedDetails.Location = new System.Drawing.Point(36, 119);
            this.lblPrintedDetails.Name = "lblPrintedDetails";
            this.lblPrintedDetails.Size = new System.Drawing.Size(724, 303);
            this.lblPrintedDetails.TabIndex = 8;
            this.lblPrintedDetails.Click += new System.EventHandler(this.lblPrintedDetails_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPrintedDetails);
            this.Controls.Add(this.lblTitle2);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Label lblPrintedDetails;
    }
}