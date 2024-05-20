using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Files_Queue_Program
{
    public partial class Form2 : Form
    {
        public Form2(object Queue)
        {
            InitializeComponent();
            this.Text = "All Files Details";

            if (Queue is QueueFiles)
            {
                DataFile[] arrFiles = ((QueueFiles)Queue).GetArray();
                foreach (DataFile file in arrFiles)
                {
                    lblPrintedDetails.Text += file.Dir();
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void lblPrintedDetails_Click(object sender, EventArgs e)
        {
           
        }
    }
}
