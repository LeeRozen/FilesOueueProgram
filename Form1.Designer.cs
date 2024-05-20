namespace Files_Queue_Program
{
    partial class Form1
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
            this.lblAddFile = new System.Windows.Forms.Label();
            this.lblRemove = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnPrintFiles = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmbFileType = new System.Windows.Forms.ComboBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.txtFileContent = new System.Windows.Forms.TextBox();
            this.cmbAddingOptions = new System.Windows.Forms.ComboBox();
            this.btnToAdd = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblContent = new System.Windows.Forms.Label();
            this.lblOptions = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.btnToRemove = new System.Windows.Forms.Button();
            this.lblTypesForSearch = new System.Windows.Forms.Label();
            this.cmbTypesForSearch = new System.Windows.Forms.ComboBox();
            this.txtFilesByTypeList = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lblLine = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddFile
            // 
            this.lblAddFile.BackColor = System.Drawing.Color.White;
            this.lblAddFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAddFile.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddFile.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblAddFile.Location = new System.Drawing.Point(38, 87);
            this.lblAddFile.Name = "lblAddFile";
            this.lblAddFile.Size = new System.Drawing.Size(306, 24);
            this.lblAddFile.TabIndex = 1;
            this.lblAddFile.Text = "Add File";
            this.lblAddFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAddFile.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblRemove
            // 
            this.lblRemove.BackColor = System.Drawing.Color.White;
            this.lblRemove.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRemove.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemove.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblRemove.Location = new System.Drawing.Point(38, 359);
            this.lblRemove.Name = "lblRemove";
            this.lblRemove.Size = new System.Drawing.Size(303, 24);
            this.lblRemove.TabIndex = 2;
            this.lblRemove.Text = "Remove File";
            this.lblRemove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSearch
            // 
            this.lblSearch.BackColor = System.Drawing.Color.White;
            this.lblSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSearch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblSearch.Location = new System.Drawing.Point(456, 87);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(306, 24);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "Search File";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSearch.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnPrintFiles
            // 
            this.btnPrintFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintFiles.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintFiles.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnPrintFiles.Location = new System.Drawing.Point(631, 418);
            this.btnPrintFiles.Name = "btnPrintFiles";
            this.btnPrintFiles.Size = new System.Drawing.Size(131, 29);
            this.btnPrintFiles.TabIndex = 4;
            this.btnPrintFiles.Text = "Print All Files";
            this.btnPrintFiles.UseVisualStyleBackColor = true;
            this.btnPrintFiles.Click += new System.EventHandler(this.btnPrintFiles_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTitle.Location = new System.Drawing.Point(38, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(724, 30);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "File Managment System";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // cmbFileType
            // 
            this.cmbFileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFileType.Enabled = false;
            this.cmbFileType.FormattingEnabled = true;
            this.cmbFileType.Items.AddRange(new object[] {
            Files_Queue_Program.FileTypeExtension.TXT,
            Files_Queue_Program.FileTypeExtension.DOC,
            Files_Queue_Program.FileTypeExtension.DOCX,
            Files_Queue_Program.FileTypeExtension.PDF,
            Files_Queue_Program.FileTypeExtension.PPTX});
            this.cmbFileType.Location = new System.Drawing.Point(200, 176);
            this.cmbFileType.Name = "cmbFileType";
            this.cmbFileType.Size = new System.Drawing.Size(144, 24);
            this.cmbFileType.TabIndex = 6;
            // 
            // txtFileName
            // 
            this.txtFileName.Enabled = false;
            this.txtFileName.Location = new System.Drawing.Point(35, 176);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(121, 22);
            this.txtFileName.TabIndex = 10;
            // 
            // txtFileContent
            // 
            this.txtFileContent.AccessibleDescription = "";
            this.txtFileContent.Enabled = false;
            this.txtFileContent.Location = new System.Drawing.Point(41, 230);
            this.txtFileContent.Multiline = true;
            this.txtFileContent.Name = "txtFileContent";
            this.txtFileContent.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtFileContent.Size = new System.Drawing.Size(303, 62);
            this.txtFileContent.TabIndex = 8;
            this.txtFileContent.TextChanged += new System.EventHandler(this.txtFileContent_TextChanged);
            // 
            // cmbAddingOptions
            // 
            this.cmbAddingOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddingOptions.FormattingEnabled = true;
            this.cmbAddingOptions.Items.AddRange(new object[] {
            "",
            "add default file",
            "add file with details"});
            this.cmbAddingOptions.Location = new System.Drawing.Point(165, 122);
            this.cmbAddingOptions.Name = "cmbAddingOptions";
            this.cmbAddingOptions.Size = new System.Drawing.Size(179, 24);
            this.cmbAddingOptions.TabIndex = 9;
            this.cmbAddingOptions.SelectedIndexChanged += new System.EventHandler(this.cmbAddingOptions_SelectedIndexChanged);
            // 
            // btnToAdd
            // 
            this.btnToAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToAdd.Enabled = false;
            this.btnToAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnToAdd.Location = new System.Drawing.Point(41, 298);
            this.btnToAdd.Name = "btnToAdd";
            this.btnToAdd.Size = new System.Drawing.Size(75, 23);
            this.btnToAdd.TabIndex = 11;
            this.btnToAdd.Text = "Add";
            this.btnToAdd.UseVisualStyleBackColor = true;
            this.btnToAdd.Click += new System.EventHandler(this.btnToAdd_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Enabled = false;
            this.lblName.Location = new System.Drawing.Point(38, 155);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(72, 16);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "File Name:";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Enabled = false;
            this.lblContent.Location = new System.Drawing.Point(38, 211);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(93, 16);
            this.lblContent.TabIndex = 13;
            this.lblContent.Text = "Content in File:";
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.Location = new System.Drawing.Point(38, 125);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(90, 16);
            this.lblOptions.TabIndex = 14;
            this.lblOptions.Text = "Select Option:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Enabled = false;
            this.lblType.Location = new System.Drawing.Point(197, 155);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(108, 16);
            this.lblType.TabIndex = 15;
            this.lblType.Text = "Select File Type:";
            // 
            // btnToRemove
            // 
            this.btnToRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnToRemove.Location = new System.Drawing.Point(38, 396);
            this.btnToRemove.Name = "btnToRemove";
            this.btnToRemove.Size = new System.Drawing.Size(90, 27);
            this.btnToRemove.TabIndex = 16;
            this.btnToRemove.Text = "Remove";
            this.btnToRemove.UseVisualStyleBackColor = true;
            this.btnToRemove.Click += new System.EventHandler(this.btnToRemove_Click);
            // 
            // lblTypesForSearch
            // 
            this.lblTypesForSearch.AutoSize = true;
            this.lblTypesForSearch.Location = new System.Drawing.Point(453, 120);
            this.lblTypesForSearch.Name = "lblTypesForSearch";
            this.lblTypesForSearch.Size = new System.Drawing.Size(108, 16);
            this.lblTypesForSearch.TabIndex = 18;
            this.lblTypesForSearch.Text = "Select File Type:";
            // 
            // cmbTypesForSearch
            // 
            this.cmbTypesForSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypesForSearch.FormattingEnabled = true;
            this.cmbTypesForSearch.Items.AddRange(new object[] {
            Files_Queue_Program.FileTypeExtension.TXT,
            Files_Queue_Program.FileTypeExtension.DOC,
            Files_Queue_Program.FileTypeExtension.DOCX,
            Files_Queue_Program.FileTypeExtension.PDF,
            Files_Queue_Program.FileTypeExtension.PPTX});
            this.cmbTypesForSearch.Location = new System.Drawing.Point(456, 139);
            this.cmbTypesForSearch.Name = "cmbTypesForSearch";
            this.cmbTypesForSearch.Size = new System.Drawing.Size(144, 24);
            this.cmbTypesForSearch.TabIndex = 17;
            this.cmbTypesForSearch.SelectedIndexChanged += new System.EventHandler(this.cmbTypesForSearch_SelectedIndexChanged);
            // 
            // txtFilesByTypeList
            // 
            this.txtFilesByTypeList.Location = new System.Drawing.Point(456, 183);
            this.txtFilesByTypeList.Multiline = true;
            this.txtFilesByTypeList.Name = "txtFilesByTypeList";
            this.txtFilesByTypeList.Size = new System.Drawing.Size(305, 182);
            this.txtFilesByTypeList.TabIndex = 19;
            this.txtFilesByTypeList.TextChanged += new System.EventHandler(this.txtFilesByTypeList_TextChanged);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 482);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.Location = new System.Drawing.Point(427, 378);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(335, 16);
            this.lblLine.TabIndex = 20;
            this.lblLine.Text = "---------------------------------------------------------------------------------" +
    "-";
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSearch.Location = new System.Drawing.Point(672, 150);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 27);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.txtFilesByTypeList);
            this.Controls.Add(this.lblTypesForSearch);
            this.Controls.Add(this.cmbTypesForSearch);
            this.Controls.Add(this.btnToRemove);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblOptions);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnToAdd);
            this.Controls.Add(this.cmbAddingOptions);
            this.Controls.Add(this.txtFileContent);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.cmbFileType);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnPrintFiles);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblRemove);
            this.Controls.Add(this.lblAddFile);
            this.Name = "Form1";
            this.Text = "Files Queue Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddFile;
        private System.Windows.Forms.Label lblRemove;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnPrintFiles;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmbFileType;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.TextBox txtFileContent;
        private System.Windows.Forms.ComboBox cmbAddingOptions;
        private System.Windows.Forms.Button btnToAdd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button btnToRemove;
        private System.Windows.Forms.Label lblTypesForSearch;
        private System.Windows.Forms.ComboBox cmbTypesForSearch;
        private System.Windows.Forms.TextBox txtFilesByTypeList;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Button btnSearch;
    }
}

