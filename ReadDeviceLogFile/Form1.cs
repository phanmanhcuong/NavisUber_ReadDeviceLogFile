using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadDeviceLogFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_connect_Click(object sender, EventArgs e)
        {           

            if (!String.IsNullOrEmpty((txtbox_filename.Text))){
                string directoryPath = "C:\\Users\\Admin\\DevicesLogFiles";
                string[] devicesLogFiles = Directory.GetFiles(directoryPath);
                foreach (string deviceLogFile in devicesLogFiles)
                {
                    string fileName = Path.GetFileNameWithoutExtension(deviceLogFile);
                    if (fileName.StartsWith(txtbox_filename.Text)){
                        var listViewItem = new ListViewItem(fileName);
                        listView1.Items.Add(listViewItem);
                    }
                }
            }
        }

        private void checkbox_selectall_CheckedChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < listView1.Items.Count; i++)
            {
                listView1.Items[i].Checked = true;
            }
        }

        private void checkBox_unselectall_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                listView1.Items[i].Checked = false;
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {

        }

        private void btn_stop_Click(object sender, EventArgs e)
        {

        }
    }
}
