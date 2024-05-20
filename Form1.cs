using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Files_Queue_Program
{
    public partial class Form1 : Form
    {
        QueueFiles QueueProg = new QueueFiles();
        public Form1()
        {
            InitializeComponent();
            this.Text = "Files Queue Program";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("There are no files in the program");
            this.BackColor = Color.Beige;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void cmbAddingOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAddingOptions.SelectedIndex == 0)
            {
                btnToAdd.Enabled = false;
                lblName.Enabled = false;
                txtFileName.Enabled = false;
                lblType.Enabled = false;
                cmbFileType.Enabled = false;
                lblContent.Enabled = false;
                txtFileContent.Enabled = false;
            }
            if (cmbAddingOptions.SelectedIndex == 1)
            {
                btnToAdd.Enabled = true;
                lblName.Enabled = false;
                txtFileName.Enabled = false;
                lblType.Enabled = false;
                cmbFileType.Enabled = false;
                lblContent.Enabled = false;
                txtFileContent.Enabled = false;

            }

            if (cmbAddingOptions.SelectedIndex == 2)
            {
                btnToAdd.Enabled = true;
                lblName.Enabled = true;
                txtFileName.Enabled = true;
                lblType.Enabled = true;
                cmbFileType.Enabled = true;
                lblContent.Enabled = true;
                txtFileContent.Enabled = true;
            }
        }

        private void btnToAdd_Click(object sender, EventArgs e)
        {
            if (cmbAddingOptions.SelectedIndex == 0)
            {
                MessageBox.Show("You must choose first adding option");
            }

            if (cmbAddingOptions.SelectedIndex == 1)
            {
                // ceate new object for DataFile class with default details:
                DataFile Deffile = new DataFile();
                QueueProg.Enqueue(Deffile);

                MessageBox.Show("File added successfully!","Add File",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }

            if (cmbAddingOptions.SelectedIndex == 2)
            {
                if (txtFileName.Text == "")
                {
                    MessageBox.Show("Please write file name");
                }

                if (cmbFileType.SelectedIndex == -1)
                {
                    MessageBox.Show("You must choose type file from the list above");
                }

                if (txtFileContent.Text == null)
                {
                    MessageBox.Show("Please write content file");
                }

                if (txtFileContent.Text != null)
                {
                    int c = 0;
                    string fileName = txtFileContent.Text;
                    char fileChar = fileName[c];
                    bool properName = true;
                    while (c < txtFileContent.Text.Length)
                    {
                        if (fileChar == '<' || fileChar == '?' || fileChar == '*' || fileChar == ':' || fileChar == '/' || fileChar == '\\' || fileChar == '|' || fileChar == '>')
                        {
                            MessageBox.Show("A file name can't contain any of the following characters:\\ / : * ? \" < > | ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            properName = false;
                        }
                        c++;
                    }

                    if (properName==true)
                    {
                        // ceate new object for DataFile class with the details that were chosen:
                        FileTypeExtension chosenType = (FileTypeExtension)cmbFileType.SelectedIndex + 1;
                        DataFile file = new DataFile(txtFileName.Text, txtFileContent.Text, chosenType);

                        QueueProg.Enqueue(file);

                        MessageBox.Show("File added successfully!", "Add File", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
        }

        private void txtFileContent_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnToRemove_Click(object sender, EventArgs e)
        {
            DialogResult res =  MessageBox.Show("This action will remove the first file in the queue files. \n\r Do you want to continue?", "Remove File", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                DataFile tmpFile = QueueProg.Dequeue();
                if (tmpFile==null) 
                { 
                    MessageBox.Show("Can not be acomplished, no files exsists in the queue"); 
                }

                else 
                {
                    string details = tmpFile.Dir();
                    MessageBox.Show("File removed successfully:\n\r" + details, "Removed File Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void cmbTypesForSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbTypesForSearch.SelectedIndex == -1)
            {
                MessageBox.Show("You must choose from type file for searching");
            }

            else
            {
                FileTypeExtension TypeToSearch = (FileTypeExtension)cmbTypesForSearch.SelectedIndex + 1;
                DataFile[] arrByType = QueueProg.SearchFileByType(TypeToSearch);
                
                foreach (DataFile file in arrByType)
                {
                    string str = file.Dir();
                    txtFilesByTypeList.AppendText(str);
                }
                
            }
           
        }

        private void txtFilesByTypeList_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btnPrintFiles_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(QueueProg);
            frm2.ShowDialog();
        }
    }
}
